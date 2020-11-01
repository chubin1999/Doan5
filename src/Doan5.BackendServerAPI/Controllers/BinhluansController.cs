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
    public class BinhluansController : ControllerBase
    {
        private readonly Doan5Context _context;

        public BinhluansController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Binhluans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Binhluan>>> GetBinhluan()
        {
            return await _context.Binhluan.ToListAsync();
        }

        // GET: api/Binhluans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Binhluan>> GetBinhluan(string id)
        {
            var binhluan = await _context.Binhluan.FindAsync(id);

            if (binhluan == null)
            {
                return NotFound();
            }

            return binhluan;
        }

        // PUT: api/Binhluans/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBinhluan(string id, Binhluan binhluan)
        {
            

            _context.Entry(binhluan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BinhluanExists(id))
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

        // POST: api/Binhluans

        [HttpPost]
        public async Task<ActionResult<Binhluan>> PostBinhluan(Binhluan binhluan)
        {
            _context.Binhluan.Add(binhluan);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BinhluanExists(binhluan.Mabinhluan))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBinhluan", new { id = binhluan.Mabinhluan }, binhluan);
        }

        // DELETE: api/Binhluans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Binhluan>> DeleteBinhluan(string id)
        {
            var binhluan = await _context.Binhluan.FindAsync(id);
            if (binhluan == null)
            {
                return NotFound();
            }

            _context.Binhluan.Remove(binhluan);
            await _context.SaveChangesAsync();

            return binhluan;
        }

        private bool BinhluanExists(string id)
        {
            return _context.Binhluan.Any(e => e.Mabinhluan == id);
        }
    }
}
