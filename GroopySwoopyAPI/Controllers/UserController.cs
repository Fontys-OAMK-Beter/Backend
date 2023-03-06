using Microsoft.AspNetCore.Mvc;
using GroopySwoopyLogic;
using GroopySwoopyDAL;
using GroopySwoopyDTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroopySwoopyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IEnumerable<User> Get(int id)
        {
            //var UserService = new UserService(new UserDataservice());
            //return UserService.GetAllUsers().ToArray();

            List<User> users = new List<User>();
            users.Add(new User());
            users.LastOrDefault().Id = id;
            users.LastOrDefault().Name = "VWVVHHOetroe";
            users.LastOrDefault().Email = "cbt@help.com";

            return users.ToArray();
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
