using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<string>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return "User added";
        }
        [Route("[action]")]
        [HttpGet]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}
