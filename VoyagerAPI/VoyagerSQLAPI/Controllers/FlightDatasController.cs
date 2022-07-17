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
    public class FlightDatasController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public FlightDatasController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/FlightDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightData>>> GetFlightsDatas()
        {
          if (_context.FlightsDatas == null)
          {
              return NotFound();
          }
            return await _context.FlightsDatas.ToListAsync();
        }

        // GET: api/FlightDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightData>> GetFlightData(int id)
        {
          if (_context.FlightsDatas == null)
          {
              return NotFound();
          }
            var flightData = await _context.FlightsDatas.FindAsync(id);

            if (flightData == null)
            {
                return NotFound();
            }

            return flightData;
        }

        // PUT: api/FlightDatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightData(int id, FlightData flightData)
        {
            if (id != flightData.FlightNumber)
            {
                return BadRequest();
            }

            _context.Entry(flightData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightDataExists(id))
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

        // POST: api/FlightDatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlightData>> PostFlightData(FlightData flightData)
        {
          if (_context.FlightsDatas == null)
          {
              return Problem("Entity set 'VoyagerDbContext.FlightsDatas'  is null.");
          }
            _context.FlightsDatas.Add(flightData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlightData", new { id = flightData.FlightNumber }, flightData);
        }

        // DELETE: api/FlightDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightData(int id)
        {
            if (_context.FlightsDatas == null)
            {
                return NotFound();
            }
            var flightData = await _context.FlightsDatas.FindAsync(id);
            if (flightData == null)
            {
                return NotFound();
            }

            _context.FlightsDatas.Remove(flightData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightDataExists(int id)
        {
            return (_context.FlightsDatas?.Any(e => e.FlightNumber == id)).GetValueOrDefault();
        }
    }
}
