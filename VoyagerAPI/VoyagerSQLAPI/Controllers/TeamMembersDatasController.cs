using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.TeamMembers;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersDatasController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public TeamMembersDatasController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamMembersDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMembersData>>> GetTeamMembersDatas()
        {
          if (_context.TeamMembersDatas == null)
          {
              return NotFound();
          }
            return await _context.TeamMembersDatas.ToListAsync();
        }

        // GET: api/TeamMembersDatas/5
        /*[HttpGet("{id}")]
        public async Task<ActionResult<TeamMembersData>> GetTeamMembersData(int id)
        {
          if (_context.TeamMembersDatas == null)
          {
              return NotFound();
          }
            var TeamMembersDatasData = await _context.TeamMembersDatas.FindAsync(id);

            if (TeamMembersDatasData == null)
            {
                return NotFound();
            }

            return TeamMembersDatasData;
        }*/

        // PUT: api/TeamMembersDatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamMembersData(int id, TeamMembersData TeamMembersDatasData)
        {
            if (id != TeamMembersDatasData.Id)
            {
                return BadRequest();
            }

            _context.Entry(TeamMembersDatasData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamMembersDataExists(id))
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

        // POST: api/TeamMembersDatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamMembersData>> PostTeamMembersData(TeamMembersData TeamMembersDatasData)
        {
          if (_context.TeamMembersDatas == null)
          {
              return Problem("Entity set 'VoyagerDbContext.TeamMembersDatas'  is null.");
          }
            _context.TeamMembersDatas.Add(TeamMembersDatasData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeamMembersData", new { id = TeamMembersDatasData.Id }, TeamMembersDatasData);
        }

        // DELETE: api/TeamMembersDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamMembersData(int id)
        {
            if (_context.TeamMembersDatas == null)
            {
                return NotFound();
            }
            var TeamMembersDatasData = await _context.TeamMembersDatas.FindAsync(id);
            if (TeamMembersDatasData == null)
            {
                return NotFound();
            }

            _context.TeamMembersDatas.Remove(TeamMembersDatasData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //nuk e besoj qe ka me bo ama se duhet me drysghu qet url
       // [HttpGet]
       // public IActionResult Get()
       // {
       //     var image = System.IO.File.OpenRead("C:\\test\\random_image.jpeg");
       //     return File(image, "image/jpeg");
       // }
        private bool TeamMembersDataExists(int id)
        {
            return (_context.TeamMembersDatas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
