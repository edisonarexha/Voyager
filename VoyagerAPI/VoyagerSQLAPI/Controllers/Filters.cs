using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Filters;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Filters : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public Filters(VoyagerDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutPutFilters>>> getfilters()
        {
            if (_context.filtersout == null)
            {
                return NotFound();
            }
            return await _context.filtersout.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<OutPutFilters>>> TicketData(InputFilters input)
        {
          
            string StoredProc = "exec hotelfilter " +
                   "@city= " + input.city + "," +
                   "@date = '" + input.date + "'," +
                   "@anyrage= '" + input.anyrage + "'";


            //string task = "exec hotelfilter " +
            //"@city = " + input.city + "," +
            //"@date = '" + data + "'," +
            // "@anyrage= '" + input.anyrage + "'";
            return await _context.filtersout.FromSqlRaw(StoredProc).ToListAsync();
        }

    }
}
