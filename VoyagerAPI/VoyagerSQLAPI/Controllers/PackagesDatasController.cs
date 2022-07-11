using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.Packages;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesDatasController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public PackagesDatasController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/PackagesDatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PackagesData>>> GetpackagesDatas()
        {
          if (_context.packagesDatas == null)
          {
              return NotFound();
          }
            return await _context.packagesDatas.ToListAsync();
        }

        // GET: api/PackagesDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PackagesData>> GetPackagesData(int id)
        {
          if (_context.packagesDatas == null)
          {
              return NotFound();
          }
            var packagesData = await _context.packagesDatas.FindAsync(id);

            if (packagesData == null)
            {
                return NotFound();
            }

            return packagesData;
        }

        // PUT: api/PackagesDatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPackagesData(int id, PackagesData packagesData)
        {
            if (id != packagesData.id)
            {
                return BadRequest();
            }

            _context.Entry(packagesData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackagesDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PackagesDatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PackagesData>> PostPackagesData(PackagesData packagesData)
        {
          if (_context.packagesDatas == null)
          {
              return Problem("Entity set 'VoyagerDbContext.packagesDatas'  is null.");
          }
            _context.packagesDatas.Add(packagesData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPackagesData", new { id = packagesData.id }, packagesData);
        }

     


        // DELETE: api/PackagesDatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePackagesData(int id)
        {
            if (_context.packagesDatas == null)
            {
                return NotFound();
            }
            var packagesData = await _context.packagesDatas.FindAsync(id);
            if (packagesData == null)
            {
                return NotFound();
            }

            _context.packagesDatas.Remove(packagesData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PackagesDataExists(int id)
        {
            return (_context.packagesDatas?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
