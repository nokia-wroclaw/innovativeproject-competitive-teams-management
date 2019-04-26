using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public interface ITeamService
    {
        IEnumerable<Team> GetAllTeams();
        Team GetTeamById(int id);
        void AddTeam(Team team);
        void EditTeam(int id, Team team);
        void DeleteTeam(int id);
        
    }
}