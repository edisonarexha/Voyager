using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToBeDeletedVoyagerController : ControllerBase
    {
        private readonly VoyagerDbContext _context;
        public ToBeDeletedVoyagerController(VoyagerDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<VoyagerToBeDeleted>> Get()
            => await _context.voyagers.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(VoyagerToBeDeleted), StatusCodes.Status200OK)]
        [ProducesResponseType( StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var deleteCont = await _context.voyagers.FindAsync(id);
            return deleteCont == null ? NotFound() : Ok(deleteCont);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(VoyagerToBeDeleted VOY)
        {
            await _context.voyagers.AddAsync(VOY);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id=VOY.Id});//RETURNS THE STATUS CODE AND LOCATION TO HEADER
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<IActionResult> Update(int id, VoyagerToBeDeleted VOY)
        {
            if(id != VOY.Id) return BadRequest();

            _context.Entry(VOY).State=EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var voyagerExists= await _context.voyagers.FindAsync(id);
            if(voyagerExists==null)return NotFound();
            _context.voyagers.Remove(voyagerExists);
            await _context.SaveChangesAsync();

            return NoContent();
        }
      
    }
}
