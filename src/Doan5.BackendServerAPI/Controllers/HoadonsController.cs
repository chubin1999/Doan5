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
    public class HoadonsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public HoadonsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Hoadons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hoadon>>> GetHoadon()
        {
            return await _context.Hoadon.ToListAsync();
        }

        // GET: api/Hoadons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hoadon>> GetHoadon(string id)
        {
            var hoadon = await _context.Hoadon.FindAsync(id);

            if (hoadon == null)
            {
                return NotFound();
            }

            return hoadon;
        }

        // PUT: api/Hoadons/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHoadon(string id, Hoadon hoadon)
        {
            if (id != hoadon.Mahoadon)
            {
                return BadRequest();
            }

            _context.Entry(hoadon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoadonExists(id))
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

        // POST: api/Hoadons
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Hoadon>> PostHoadon(Hoadon hoadon)
        {
            _context.Hoadon.Add(hoadon);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HoadonExists(hoadon.Mahoadon))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHoadon", new { id = hoadon.Mahoadon }, hoadon);
        }

        // DELETE: api/Hoadons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hoadon>> DeleteHoadon(string id)
        {
            var hoadon = await _context.Hoadon.FindAsync(id);
            if (hoadon == null)
            {
                return NotFound();
            }

            _context.Hoadon.Remove(hoadon);
            await _context.SaveChangesAsync();

            return hoadon;
        }

        private bool HoadonExists(string id)
        {
            return _context.Hoadon.Any(e => e.Mahoadon == id);
        }
    }
}
