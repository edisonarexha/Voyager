using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Users;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public UsersController(VoyagerDbContext context) => _context = context;
        ////[AcceptVerbs("getAllUsers")]
        //[ActionName("getAllUsers")]
        [HttpGet("Users")]
        public async Task<IEnumerable<Users>> GetUsers() =>
            await _context.users.ToListAsync();

        ////[AcceptVerbs("getUsersById")]
        //[ActionName("getUsersById")]
        [HttpGet("id")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserDetails(int id)
        {
            var users = await _context.users.FindAsync(id);
            return users == null ? NotFound() : Ok(users);
        }
        //[AcceptVerbs("sendUserData")]
        //[ActionName("sendUserData")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateUsers(Users userss)
        {
            await _context.users.AddAsync(userss);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUserDetails), new { id = userss.UserId });

        }

    }
}
