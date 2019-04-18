using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class UsersController : Controller
    {/*
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("api/teamss")]
        public string[] My()
        {
            return new[]
            {
                "Is the Microwave working?",
                "Where can i pick the washing machine from?",
            };
        }

        [HttpGet("api/userss")]
        public IActionResult GetUsers()
        {
            var usersFromRepo = _userService.GetAllUsers();

            return new JsonResult(usersFromRepo);
        }

        [HttpGet("api/users/{id}")]
        public IActionResult GetUsers(int id)
        {
           
            var userFromRepo = _userService.GetUserById(id);

            return new JsonResult(userFromRepo);
        }

        [HttpPost("api/user")]
        public IActionResult AddUser([FromBody] User user)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(user);
            }

            _userService.AddUser(user);

            return Ok();
        }

        [HttpPut("api/user/{id}")]
        public IActionResult EditUser(int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }

            _userService.EditUser(id, user);

            return Ok();
        }

        [HttpPatch("api/user/{id}")]
        public IActionResult PatchUser(int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }

            _userService.EditUser(id, user);

            return Ok();
        }

        [HttpDelete("api/user/{id}")]
        public IActionResult DeleteUser(int id)
        {
            
            _userService.DeleteUser(id);

            return Ok();
        }

        */


    }
}
