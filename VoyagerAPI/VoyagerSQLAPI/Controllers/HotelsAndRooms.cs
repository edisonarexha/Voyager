using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Hotel.HotelAndRoomsProc;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsAndRooms : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public HotelsAndRooms(VoyagerDbContext context)
        {
            _context = context;
        }


        /*[HttpPost]
        public async Task<ActionResult<IEnumerable<HotelAndRooms_proc>>> TicketData()
        {


            string task = "exec hotelroomsproc ";

            return await _context.hotelandrooms.FromSqlRaw(task).ToListAsync();
        }*/





    }
}
