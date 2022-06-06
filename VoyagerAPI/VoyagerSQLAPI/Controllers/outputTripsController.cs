using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.TripProcedure;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class outputTripsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public outputTripsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/outputTrips
        [HttpGet]
        public async Task<ActionResult<IEnumerable<outputTrip>>> GetoutputTrip()
        {
          if (_context.outputTrip == null)
          {
              return NotFound();
          }
            return await _context.outputTrip.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<outputTrip>>> Getoutput(inputTrip input)
        {
            var Insertedate = DateTime.Now;
            input.InsertedDate = Insertedate;

            string StoredProc = "exec getTripDataForUser " +
                    "@userid= " + input.Id + "," +
                    "@logsNumber = '" + input.LogsNumber + "'," +
                   "@formaid = '" + input.formaid + "'," +
                   "@moduliid = '" + input.moduliid + "'," +
                    "@InsertedDate= '" + input.InsertedDate + "'";
  
                   
                   
            return await _context.outputTrip.FromSqlRaw(StoredProc).ToListAsync();
        }








    }
}
