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

        [HttpGet("api/teams")]
        public IActionResult GetTeams()
        {
            var teamsFromRepo = _teamService.GetAllTeams();

            
            return new JsonResult(teamsFromRepo);
        }

        [HttpGet("api/teams/{id}")]
        public IActionResult GetTeams(int id)
        {

            var teamFromRepo = _teamService.GetTeamById(id);

            return new JsonResult(teamFromRepo);
        }

        [HttpPost("api/team")]
        public IActionResult AddTeam([FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(team);
            }

            _teamService.AddTeam(team);

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

        [HttpPatch("api/team/{id}")]
        public IActionResult PatchTeam(int id, [FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(team);
            }

            _teamService.EditTeam(id, team);

            return Ok();
        }

        [HttpDelete("api/team/{id}")]
        public IActionResult DeleteTeam(int id)
        {

            _teamService.DeleteTeam(id);

            return Ok();
        }

        [HttpPost("api/team/{id}")]
        public IActionResult AddUserToTeam(int id,[FromBody] User user)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }
            _teamService.AddUserToTeam(id, user);

            return Ok();
        }


    }

}