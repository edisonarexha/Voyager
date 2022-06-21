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
    public class HotelDatasController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public HotelDatasController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDatas>>> GethotelDatas()
        {
          if (_context.hotelDatas == null)
          {
              return NotFound();
          }
            return await _context.hotelDatas.ToListAsync();
        }

        // GET: api/HotelDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDatas>> GetHotelDatas(int id)
        {
          if (_context.hotelDatas == null)
          {
              return NotFound();
          }
            var hotelDatas = await _context.hotelDatas.FindAsync(id);

            if (hotelDatas == null)
            {
                return NotFound();
            }

            return hotelDatas;
        }

        // PUT: api/HotelDatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelDatas(int id, HotelDatas hotelDatas)
        {
            if (id != hotelDatas.HotelId)
            {
                return BadRequest();
            }

            _context.Entry(hotelDatas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelDatasExists(id))
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

        // POST: api/HotelDatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelDatas>> PostHotelDatas(HotelDatas hotelDatas)
        {
          if (_context.hotelDatas == null)
          {
              return Problem("Entity set 'VoyagerDbContext.hotelDatas'  is null.");
          }
            _context.hotelDatas.Add(hotelDatas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelDatas", new { id = hotelDatas.HotelId }, hotelDatas);
        }

        // DELETE: api/HotelDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelDatas(int id)
        {
            if (_context.hotelDatas == null)
            {
                return NotFound();
            }
            var hotelDatas = await _context.hotelDatas.FindAsync(id);
            if (hotelDatas == null)
            {
                return NotFound();
            }

            _context.hotelDatas.Remove(hotelDatas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelDatasExists(int id)
        {
            return (_context.hotelDatas?.Any(e => e.HotelId == id)).GetValueOrDefault();
        }
    }
}
