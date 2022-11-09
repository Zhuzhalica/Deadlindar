using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServer.Models;

namespace WebApiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        public IUserRepository UserRepository { get; set; }
        public ClientController(IUserRepository userItems)
        {
            UserRepository = userItems;
        }

        public IEnumerable<User> GetAll()
        {
            return UserRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult Get(string id)
        {
            var user = UserRepository.FindUserInBase(id);
            if (user is null)
                return NotFound();
            return new ObjectResult(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (user is null)
                return BadRequest();
            UserRepository.AddUserInBase(user);
            return CreatedAtRoute("GetUser", new { id = user.ID }, user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        { 
            UserRepository.RemoveUserInBase(id);
            return new NoContentResult();
        }
    }
}
