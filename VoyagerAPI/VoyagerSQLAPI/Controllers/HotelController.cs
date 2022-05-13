using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Hotel;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly VoyagerDbContext _context;
        public HotelController(VoyagerDbContext context) => _context = context;


        [HttpGet]
        public async Task<IEnumerable<HotelDetails>> GetHotel() =>
            await _context.hotels.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(HotelDetails), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetHotelDetails(int id)
        {
            var hotelDetails = await _context.hotels.FindAsync(id);
            return hotelDetails == null ? NotFound() : Ok(hotelDetails);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateHotel(HotelDetails hoteldetails)
        {
            await _context.hotels.AddAsync(hoteldetails);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHotelDetails), new { id = hoteldetails.HotelId });

        }
    }
}
