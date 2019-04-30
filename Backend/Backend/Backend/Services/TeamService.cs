using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Services
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _appDbContext;// variable used for sending data to DataBase

        public TeamService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Team> GetAllTeams()
        {
            
            return _appDbContext.Teams.Include(u=>u.Users).ToList();
        }

        public Team GetTeamById(int id)
        {
            return _appDbContext.Teams.Include(u=>u.Users).FirstOrDefault(x => x.TeamId == id);
        }

        public void AddTeam(Team team)
        {
           
            _appDbContext.Teams.Add(team);
            _appDbContext.SaveChanges();
           
        }

        public void EditTeam(int id, Team team)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.TeamId == id);
            if (_team != null)
            {
                _team.Name = team.Name;
                _appDbContext.SaveChanges();
            }

        }

        public void DeleteTeam(int id)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.TeamId == id);
            if (_team != null)
            {
                _appDbContext.Remove(_team);
                _appDbContext.SaveChanges();
            }
        }

        public void AddUsertoTeam(int id, string userNick)
        {
            var user = _appDbContext.Users.FirstOrDefault(u => u.Nick.Equals(userNick));//searching user by his Nick
            
            var team = _appDbContext.Teams.FirstOrDefault(x => x.TeamId.Equals(id));//searching team by TeamId\
                                                                                  
            user.Team = team;
            team.Users.Add(user);//adding User to Team ICollection<User> Users
            
            _appDbContext.Teams.Update(team);
            _appDbContext.SaveChanges();
        }

    }
}