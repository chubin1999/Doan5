using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Doan5.BackendServerAPI.Models;

namespace Doan5.BackendServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DondathangsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public DondathangsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Dondathangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dondathang>>> GetDondathang()
        {
            return await _context.Dondathang.ToListAsync();
        }

        // GET: api/Dondathangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dondathang>> GetDondathang(string id)
        {
            var dondathang = await _context.Dondathang.FindAsync(id);

            if (dondathang == null)
            {
                return NotFound();
            }

            return dondathang;
        }

        // PUT: api/Dondathangs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDondathang(string id, Dondathang dondathang)
        {
            if (id != dondathang.Madondathang)
            {
                return BadRequest();
            }

            _context.Entry(dondathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DondathangExists(id))
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

        // POST: api/Dondathangs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Dondathang>> PostDondathang(Dondathang dondathang)
        {
            _context.Dondathang.Add(dondathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DondathangExists(dondathang.Madondathang))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDondathang", new { id = dondathang.Madondathang }, dondathang);
        }

        // DELETE: api/Dondathangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Dondathang>> DeleteDondathang(string id)
        {
            var dondathang = await _context.Dondathang.FindAsync(id);
            if (dondathang == null)
            {
                return NotFound();
            }

            _context.Dondathang.Remove(dondathang);
            await _context.SaveChangesAsync();

            return dondathang;
        }

        private bool DondathangExists(string id)
        {
            return _context.Dondathang.Any(e => e.Madondathang == id);
        }
    }
}
