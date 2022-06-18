using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.AppLogs;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppLogsDatasController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public AppLogsDatasController(VoyagerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppLogsData>>> GetappLogs()
        {
          if (_context.appLogs == null)
          {
              return NotFound();
          }
            return await _context.appLogs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppLogsData>> GetAppLogsData(int id)
        {
          if (_context.appLogs == null)
          {
              return NotFound();
          }
            var appLogsData = await _context.appLogs.FindAsync(id);

            if (appLogsData == null)
            {
                return NotFound();
            }

            return appLogsData;
        }       
        private bool AppLogsDataExists(int id)
        {
            return (_context.appLogs?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
