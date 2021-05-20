using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UserController: Controller
    {
        private readonly List<User> _users = new List<User>();

        public UserController()
        {
            _users.Add(new User()
            {
                Name = "John Doe",
                Age = 21,
                Gender = "Male"
            });
        }
        
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _users;
        }

        [HttpPost]
        public ActionResult<List<User>> Insert([FromBody] User user)
        {
            _users.Add(user);
            return _users;
        }
    }
}