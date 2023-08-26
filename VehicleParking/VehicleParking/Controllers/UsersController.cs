using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using VehicleParking.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleParking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddUser(string email)
        {
            _userService.AddUser(email);
            return "User Added";
        }

        [HttpGet]
        [Route("Users")]
        public string Users()
        {
            _userService.Users();
            return "List of users";
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(string email)
        {
            _userService.DeleteUser(email);
            return "User Successfully deleted";
        }

    }
}
