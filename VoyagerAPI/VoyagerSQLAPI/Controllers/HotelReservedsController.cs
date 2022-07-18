using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Hotel;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelReservedsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public HotelReservedsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelReserveds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelReserved>>> GetreservationH()
        {
            if (_context.reservationH == null)
            {
                return NotFound();
            }
            return await _context.reservationH.ToListAsync();
        }

        // GET: api/HotelReserveds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelReserved>> GetHotelReserved(int id)
        {
            if (_context.reservationH == null)
            {
                return NotFound();
            }
            var hotelReserved = await _context.reservationH.FindAsync(id);

            if (hotelReserved == null)
            {
                return NotFound();
            }

            return hotelReserved;
        }

        // PUT: api/HotelReserveds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelReserved(int id, HotelReserved hotelReserved)
        {
            if (id != hotelReserved.id)
            {
                return BadRequest();
            }

            _context.Entry(hotelReserved).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelReservedExists(id))
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

        // POST: api/HotelReserveds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelReserved>> PostHotelReserved(HotelReserved hotelReserved)
        {
            if (_context.reservationH == null)
            {
                return Problem("Entity set 'VoyagerDbContext.reservationH'  is null.");
            }
            _context.reservationH.Add(hotelReserved);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelReserved", new { id = hotelReserved.id }, hotelReserved);
        }

        // DELETE: api/HotelReserveds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelReserved(int id)
        {
            if (_context.reservationH == null)
            {
                return NotFound();
            }
            var hotelReserved = await _context.reservationH.FindAsync(id);
            if (hotelReserved == null)
            {
                return NotFound();
            }

            _context.reservationH.Remove(hotelReserved);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelReservedExists(int id)
        {
            return (_context.reservationH?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
