using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Hotel.HotelDetailsProc;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hoteldetailsAPI : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public hoteldetailsAPI(VoyagerDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<HotelDetailsProc_Out>>> hoteldetailsdata()
        {

            var dataSource = "exec getHotelForDetails";
            return await _context.hotelproc.FromSqlRaw(dataSource).ToListAsync();
        }
    }
}
