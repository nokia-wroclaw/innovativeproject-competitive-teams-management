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
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("api/users")]
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
            //User temp = new User();
            //new JsonResult(user);

            //temp.FirstName = user.FirstName;
            //temp.LastName = user.LastName;

            _userService.AddUser(user);

            return Ok();
        }

    }
}
