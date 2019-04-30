using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{

    public class TeamsController : Controller
    {
        private ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }


        [HttpGet("api/test")]
        public IActionResult Test()
        {

            return new JsonResult(_teamService.GetAllTeams());
        }

        [HttpGet("api/teams")]
        public IActionResult GetTeams()
        {
            var teamsFromRepo = _teamService.GetAllTeams();


            return new JsonResult(teamsFromRepo);
        }

        [HttpGet("api/teams/{id}")]
        public IActionResult GetTeams(int id)
        {
            var userFromRepo = _teamService.GetTeamById(id);


            return new JsonResult(userFromRepo);
        }

        [HttpPost("api/team")]
        public IActionResult AddTeam([FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(team);
            }

            _teamService.AddTeam(team);
            //_teamService.AddUsertoTeam(teamId, userNick);
            return Ok();
        }

        [HttpPut("api/team/{id}")]
        public IActionResult EditTeam(int id, [FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(team);
            }

            _teamService.EditTeam(id, team);

            return Ok();
        }

        [HttpPatch("api/team/edit/{id}")]
        public IActionResult PatchTeam(int id, [FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(team);
            }

            _teamService.EditTeam(id, team);

            return Ok();
        }

        [HttpDelete("api/team/edit/delete/{id}")]
        public IActionResult DeleteTeam(int id)
        {

            _teamService.DeleteTeam(id);

            return Ok();
        }

        [HttpPatch("api/team/add/{id}")]
        public IActionResult AddUser(int id,[FromBody]User user)//without validating Model
        {
           
            
            var userFromRepo = _teamService.GetTeamById(id);
            _teamService.AddUsertoTeam(id, user.Nick);

            return new JsonResult(userFromRepo);
        }
    }

}