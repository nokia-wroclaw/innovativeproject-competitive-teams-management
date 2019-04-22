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
            var newUser = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                
            };
           
            _team.Users = new List<User>();
            _team.Users.Add(newUser);

            _appDbContext.SaveChanges();
        }

        /*
        public IEnumerable<User> Test(int id)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.Id == id);
            // _team.TeamMembers.ToList();
            List<string> testing = new List<string>();
                foreach (User user in _team.TeamMembers)
            {
                //var intToString = _team.TeamMembers[0].Id;
                //string laal = "";
                //testing.Add(laal.ToString(intToString));
                testing.Add(_team.TeamMembers[0].FirstName);
                testing.Add(" ");
                testing.Add(_team.TeamMembers[0].LastName);
            }

            //return _team.TeamMembers.ToList<User>();
            return _team.TeamMembers[0].FirstName;
        }
        */
        public User Test(int id)
        {
            var _team = _appDbContext.Teams.FirstOrDefault(x => x.Id == id);//1

            //var _team = _appDbContext.Teams.Include(x => x.TeamMembers).Where(x => x.Id == Id);
            //return _team.TeamMembers.ToList<User>();
            //return _team.TeamMembers[1].FirstName;
            return _team.Users[id];
        }
    }
}

