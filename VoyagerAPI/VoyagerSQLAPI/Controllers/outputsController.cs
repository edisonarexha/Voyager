using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.DB;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class outputsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public outputsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/outputs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<output>>> Getoutput()
        {
          if (_context.output == null)
          {
              return NotFound();
          }
            return await _context.output.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<output>>> Getoutput(input input)
        {
            string StoredProc = "exec getUsers " +
                    "@userid = " + input.id ;

            //return await _context.output.ToListAsync();
            return await _context.output.FromSqlRaw(StoredProc).ToListAsync();
        }



    }
}
