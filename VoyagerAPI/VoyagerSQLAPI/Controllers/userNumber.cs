using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.DashboardFunctions;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userNumber : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public userNumber(VoyagerDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult<IEnumerable<AppUser>>> hoteldetailsdata()
        {

            var dataSource = "exec priceHotels";
            return await _context.AppUseres.FromSqlRaw(dataSource).ToListAsync();
        }
    }
}
