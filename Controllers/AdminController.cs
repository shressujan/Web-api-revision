using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class AdminController: Controller
    {
        private readonly List<Admin> _admins = new();

        public AdminController()
        {
            _admins.Add(new Admin()
            {
                Id = 1,
                Name = "Jane Doe",
                Age = 22,
                Gender = "Female",
                AccessLevel = 4
            });
            _admins.Add(new Admin()
            {
                Id =2,
                Name = "Jenny Farham",
                Age = 32,
                Gender = "Female",
                AccessLevel = 10
            });
            
        }

        //Example of appending endpoint to uri
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Admin>> GetAdmins()
        {
            return _admins;
        }

        //Example of Using path variable in uri 
        [HttpGet("{id}")]
        public ActionResult<Admin> GetAdminInfo(int id)
        {
            return _admins.Find(a => a.Id == id);
        }

        //Example of using request parameters
        [HttpGet]
        public ActionResult<Admin> GetAdmin([FromQuery] string name)
        {
            return _admins.Find(a => a.Name.Equals(name));
        }   
        
    }
}