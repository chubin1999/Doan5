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
    public class ChitietdondathangsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public ChitietdondathangsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Chitietdondathangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chitietdondathang>>> GetChitietdondathang()
        {
            return await _context.Chitietdondathang.ToListAsync();
        }

        // GET: api/Chitietdondathangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chitietdondathang>> GetChitietdondathang(string id)
        {
            var chitietdondathang = await _context.Chitietdondathang.FindAsync(id);

            if (chitietdondathang == null)
            {
                return NotFound();
            }

            return chitietdondathang;
        }

        // PUT: api/Chitietdondathangs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChitietdondathang(string id, Chitietdondathang chitietdondathang)
        {

            _context.Entry(chitietdondathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChitietdondathangExists(id))
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

        // POST: api/Chitietdondathangs

        [HttpPost]
        public async Task<ActionResult<Chitietdondathang>> PostChitietdondathang(Chitietdondathang chitietdondathang)
        {
            _context.Chitietdondathang.Add(chitietdondathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChitietdondathangExists(chitietdondathang.Machitietdondathang))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChitietdondathang", new { id = chitietdondathang.Machitietdondathang }, chitietdondathang);
        }

        // DELETE: api/Chitietdondathangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Chitietdondathang>> DeleteChitietdondathang(string id)
        {
            var chitietdondathang = await _context.Chitietdondathang.FindAsync(id);
            if (chitietdondathang == null)
            {
                return NotFound();
            }

            _context.Chitietdondathang.Remove(chitietdondathang);
            await _context.SaveChangesAsync();

            return chitietdondathang;
        }

        private bool ChitietdondathangExists(string id)
        {
            return _context.Chitietdondathang.Any(e => e.Machitietdondathang == id);
        }
    }
}
