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
    public class ChitiethoadonsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public ChitiethoadonsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Chitiethoadons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chitiethoadon>>> GetChitiethoadon()
        {
            return await _context.Chitiethoadon.ToListAsync();
        }

        // GET: api/Chitiethoadons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chitiethoadon>> GetChitiethoadon(string id)
        {
            var chitiethoadon = await _context.Chitiethoadon.FindAsync(id);

            if (chitiethoadon == null)
            {
                return NotFound();
            }

            return chitiethoadon;
        }

        // PUT: api/Chitiethoadons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChitiethoadon(string id, Chitiethoadon chitiethoadon)
        {

            _context.Entry(chitiethoadon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChitiethoadonExists(id))
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

        // POST: api/Chitiethoadons
        [HttpPost]
        public async Task<ActionResult<Chitiethoadon>> PostChitiethoadon(Chitiethoadon chitiethoadon)
        {
            _context.Chitiethoadon.Add(chitiethoadon);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChitiethoadonExists(chitiethoadon.Machitiethoadon))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChitiethoadon", new { id = chitiethoadon.Machitiethoadon }, chitiethoadon);
        }

        // DELETE: api/Chitiethoadons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Chitiethoadon>> DeleteChitiethoadon(string id)
        {
            var chitiethoadon = await _context.Chitiethoadon.FindAsync(id);
            if (chitiethoadon == null)
            {
                return NotFound();
            }

            _context.Chitiethoadon.Remove(chitiethoadon);
            await _context.SaveChangesAsync();

            return chitiethoadon;
        }

        private bool ChitiethoadonExists(string id)
        {
            return _context.Chitiethoadon.Any(e => e.Machitiethoadon == id);
        }
    }
}
