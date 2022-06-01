using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Tickets;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketDetailsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public TicketDetailsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/TicketDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDetails>>> GetTicketsDetails()
        {
          if (_context.TicketsDetails == null)
          {
              return NotFound();
          }
            return await _context.TicketsDetails.ToListAsync();
        }

        // GET: api/TicketDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDetails>> GetTicketDetails(int id)
        {
          if (_context.TicketsDetails == null)
          {
              return NotFound();
          }
            var ticketDetails = await _context.TicketsDetails.FindAsync(id);

            if (ticketDetails == null)
            {
                return NotFound();
            }

            return ticketDetails;
        }

        // PUT: api/TicketDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicketDetails(int id, TicketDetails ticketDetails)
        {
            if (id != ticketDetails.TicketId)
            {
                return BadRequest();
            }

            _context.Entry(ticketDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketDetailsExists(id))
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

        // POST: api/TicketDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TicketDetails>> PostTicketDetails(TicketDetails ticketDetails)
        {
          if (_context.TicketsDetails == null)
          {
              return Problem("Entity set 'VoyagerDbContext.TicketsDetails'  is null.");
          }
            _context.TicketsDetails.Add(ticketDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicketDetails", new { id = ticketDetails.TicketId }, ticketDetails);
        }

        // DELETE: api/TicketDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketDetails(int id)
        {
            if (_context.TicketsDetails == null)
            {
                return NotFound();
            }
            var ticketDetails = await _context.TicketsDetails.FindAsync(id);
            if (ticketDetails == null)
            {
                return NotFound();
            }

            _context.TicketsDetails.Remove(ticketDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketDetailsExists(int id)
        {
            return (_context.TicketsDetails?.Any(e => e.TicketId == id)).GetValueOrDefault();
        }
    }
}
