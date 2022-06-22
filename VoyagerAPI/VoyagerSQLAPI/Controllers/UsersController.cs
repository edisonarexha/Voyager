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


        [HttpGet("{email}")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetUserWithEmail(string email)
        {
            var users = _context.users.FirstOrDefault(acc => acc.Email == email);
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

        [HttpPut("{email}")]
        public async Task<IActionResult> PutUser(String email, Users userss)
        {
            if (email != userss.Email)
            {
                return BadRequest();
            }

            _context.Entry(userss).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool UserExists(String email)
        {
            return (_context.users?.Any(e => e.Email == email)).GetValueOrDefault();
        }


    }
}
