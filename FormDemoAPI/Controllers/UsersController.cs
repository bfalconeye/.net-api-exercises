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
                Ad="Beyza",
                Soyad="Sahingoz",
                Email="beyzas@gmail.com",
                Password="12321"

            },new User
            {
                Ad="Yaman",
                Soyad="Atahan",
                Email="yatahan@gmail.com",
                Password="12321"

            }
        };
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await Task.FromResult(Ok(_users));
        }
        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUsers(User user)
        {
            _users.Add(user);
            return Ok(_users);
        }
    }
}
