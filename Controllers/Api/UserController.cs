using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQLAPICore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLAPICore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private MyDBContext myDbContext;

        public UserController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<User> Get()
        {
            return myDbContext.Users.ToList();
        }

        [HttpGet("{id}")]
        public User Get(string id)
        {
            return myDbContext.Users.FirstOrDefault(x => x.Email == id); ;
        }

 
        [HttpDelete("{id}")]
        [AcceptVerbs("DELETE")]
        
        public IActionResult Delete(string id)
        {
            var userid = myDbContext.Users.FirstOrDefault(x => x.Email == id);
            if (userid == null)
            {
                return NotFound();
            }

            myDbContext.Users.Remove(userid);
            myDbContext.SaveChanges();

            return NoContent();
        }

        [HttpPost]
       [AcceptVerbs("POST")]
        public IActionResult Post(User user)
        {
            myDbContext.Users.Add(user);
            myDbContext.SaveChanges();

            return Ok(user);
        }

 
        [HttpPut]
       [AcceptVerbs("PUT")]
        public IActionResult Put(User user)
        {
            myDbContext.Users.Update(user);
            myDbContext.SaveChanges();

            return Ok(user);
        }
    }
}
