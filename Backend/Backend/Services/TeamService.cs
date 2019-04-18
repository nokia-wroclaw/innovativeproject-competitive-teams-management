using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

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

            return _appDbContext.Teams.ToList();
        }

        public Team GetTeamById(int id)
        {
            return _appDbContext.Teams.FirstOrDefault(x => x.Id == id);
        }

        public void AddTeam(Team team)
        {
            _appDbContext.Teams.Add(team);
            _appDbContext.SaveChanges();
        }

        public void EditTeam(int id, Team team)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.Id == id);
            if (_team != null)
            {
                _team.Name = team.Name;
               //_team.TeamMembers = new User user
                _appDbContext.SaveChanges();
            }

        }

        public void DeleteTeam(int id)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.Id == id);
            if (_team != null)
            {
                _appDbContext.Remove(_team);
                _appDbContext.SaveChanges();
            }
        }

        public void AddUserToTeam(int id, User user)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.Id == id);
            _team.TeamMembers.Add(user); // adding new TeamMember to team
            _appDbContext.SaveChanges();
        }
   
    }
}

