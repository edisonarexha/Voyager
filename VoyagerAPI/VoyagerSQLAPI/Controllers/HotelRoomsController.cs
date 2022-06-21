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
    public class HotelRoomsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public HotelRoomsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelRooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelRooms>>> Gethotelrooms()
        {
          if (_context.hotelrooms == null)
          {
              return NotFound();
          }
            return await _context.hotelrooms.ToListAsync();
        }

        // GET: api/HotelRooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelRooms>> GetHotelRooms(int id)
        {
          if (_context.hotelrooms == null)
          {
              return NotFound();
          }
            var hotelRooms = await _context.hotelrooms.FindAsync(id);

            if (hotelRooms == null)
            {
                return NotFound();
            }

            return hotelRooms;
        }

        // PUT: api/HotelRooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelRooms(int id, HotelRooms hotelRooms)
        {
            if (id != hotelRooms.RoomsId)
            {
                return BadRequest();
            }

            _context.Entry(hotelRooms).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelRoomsExists(id))
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

        // POST: api/HotelRooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelRooms>> PostHotelRooms(HotelRooms hotelRooms)
        {
          if (_context.hotelrooms == null)
          {
              return Problem("Entity set 'VoyagerDbContext.hotelrooms'  is null.");
          }
            _context.hotelrooms.Add(hotelRooms);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelRooms", new { id = hotelRooms.RoomsId }, hotelRooms);
        }

        // DELETE: api/HotelRooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelRooms(int id)
        {
            if (_context.hotelrooms == null)
            {
                return NotFound();
            }
            var hotelRooms = await _context.hotelrooms.FindAsync(id);
            if (hotelRooms == null)
            {
                return NotFound();
            }

            _context.hotelrooms.Remove(hotelRooms);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelRoomsExists(int id)
        {
            return (_context.hotelrooms?.Any(e => e.RoomsId == id)).GetValueOrDefault();
        }
    }
}
