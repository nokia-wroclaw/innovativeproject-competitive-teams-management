using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {

        [HttpGet]
        [HttpGet("all")]
        public string[] GetTeams()
        {
            return new[]
            {
            "1 - Destroyers",
            "2 - Cowards",
            "3 - Winners"
            };
        }

        [HttpGet("search/{team_name}")]
        public string[] SearchTeam(string team_name)
        {

            return new[] { "There is no team " + team_name};

        }

    }
}