/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Tickets.TicketDetail_Proc;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketData_OUTController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public TicketData_OUTController(VoyagerDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketData_OUT>>> GetTicketData_OUT()
        {
            if (_context.TicketData_OUT == null)
            {*//**//*
                return NotFound();
            }
            return await _context.TicketData_OUT.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<TicketData_OUT>>> TicketData(TicketProcData_INP input)
        {


            string task = "exec Trips " +
                    "@hotelid = " + input.HotelId;

            return await _context.TicketData_OUT.FromSqlRaw(task).ToListAsync();
        }








    }
}
*/