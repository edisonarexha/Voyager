using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.DashboardFunctions;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hotelPriceController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public hotelPriceController(VoyagerDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<HotelPrice>>> hoteldetailsdata()
        {

            var dataSource = "exec priceHotels";
            return await _context.hotelPricees.FromSqlRaw(dataSource).ToListAsync();
        }
    }
}
