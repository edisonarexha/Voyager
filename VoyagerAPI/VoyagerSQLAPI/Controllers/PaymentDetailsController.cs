using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoyagerSQLAPI.Data;
using VoyagerSQLAPI.Models.PaymentGateWay;

namespace VoyagerSQLAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private readonly VoyagerDbContext _context;

        public PaymentDetailsController(VoyagerDbContext context)
        {
            _context = context;
        }

        // GET: api/PaymentDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetails>>> Getpaymentdata()
        {
          if (_context.paymentdata == null)
          {
              return NotFound();
          }
            return await _context.paymentdata.ToListAsync();
        }

        // GET: api/PaymentDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetails>> GetPaymentDetails(Guid id)
        {
          if (_context.paymentdata == null)
          {
              return NotFound();
          }
            var paymentDetails = await _context.paymentdata.FindAsync(id);

            if (paymentDetails == null)
            {
                return NotFound();
            }

            return paymentDetails;
        }

        // PUT: api/PaymentDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetails(Guid id, PaymentDetails paymentDetails)
        {
            if (id != paymentDetails.paymentId)
            {
                return BadRequest();
            }

            _context.Entry(paymentDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailsExists(id))
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

        // POST: api/PaymentDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PaymentDetails>> PostPaymentDetails(PaymentDetails paymentDetails)
        {
          if (_context.paymentdata == null)
          {
              return Problem("Entity set 'VoyagerDbContext.paymentdata'  is null.");
          }
            _context.paymentdata.Add(paymentDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentDetails", new { id = paymentDetails.paymentId }, paymentDetails);
        }

        // DELETE: api/PaymentDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetails(Guid id)
        {
            if (_context.paymentdata == null)
            {
                return NotFound();
            }
            var paymentDetails = await _context.paymentdata.FindAsync(id);
            if (paymentDetails == null)
            {
                return NotFound();
            }

            _context.paymentdata.Remove(paymentDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaymentDetailsExists(Guid id)
        {
            return (_context.paymentdata?.Any(e => e.paymentId == id)).GetValueOrDefault();
        }
    }
}
