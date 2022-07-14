using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FormDemoAPI;
using FormDemo;
using FormDemo.Shared;

namespace FormDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> _users = new List<User>
        {
            new User
            {
                Name="Beyza",
                Surname="Sahingoz",
                Email="beyzas@gmail.com",
                Password="12321"

            }
        };
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await Task.FromResult(Ok(_users));
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUsers(User users)
        {
            _users.Add(users);
            return await Task.FromResult(Ok(_users));
        }
        [HttpDelete]
        public async Task<ActionResult<List<User>>> DeleteUsers(User users)
        {
            _users.Remove(users);
            return await Task.FromResult(Ok(_users));
        }
        }
}
