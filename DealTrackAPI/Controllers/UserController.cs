using System;
using System.Collections.Generic;
using DealTrackAPI.Models;
using DealTrackAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealTrackAPI.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var userList = _userService.GetUsers();
            return Ok(userList);
        }

        [HttpGet("{userId}", Name = "GetUser")]
        public IActionResult GetUser(int userId)
        {
            var user = _userService.GetUser(userId);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _userService.CreateUser(user);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return NoContent();
        }
        
        [HttpDelete("{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            _userService.DeleteUser(userId);
            return NoContent();
        }


    }
}
