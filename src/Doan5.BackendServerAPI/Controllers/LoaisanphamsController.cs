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
    public class LoaisanphamsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public LoaisanphamsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Loaisanphams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loaisanpham>>> GetLoaisanpham()
        {
            return await _context.Loaisanpham.ToListAsync();
        }

        // GET: api/Loaisanphams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loaisanpham>> GetLoaisanpham(string id)
        {
            var loaisanpham = await _context.Loaisanpham.FindAsync(id);

            if (loaisanpham == null)
            {
                return NotFound();
            }

            return loaisanpham;
        }

        // PUT: api/Loaisanphams/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaisanpham(string id, Loaisanpham loaisanpham)
        {
            

            _context.Entry(loaisanpham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaisanphamExists(id))
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

        // POST: api/Loaisanphams
        
        [HttpPost]
        public async Task<ActionResult<Loaisanpham>> PostLoaisanpham(Loaisanpham loaisanpham)
        {
            _context.Loaisanpham.Add(loaisanpham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LoaisanphamExists(loaisanpham.Maloai))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLoaisanpham", new { id = loaisanpham.Maloai }, loaisanpham);
        }

        // DELETE: api/Loaisanphams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Loaisanpham>> DeleteLoaisanpham(string id)
        {
            var loaisanpham = await _context.Loaisanpham.FindAsync(id);
            if (loaisanpham == null)
            {
                return NotFound();
            }

            _context.Loaisanpham.Remove(loaisanpham);
            await _context.SaveChangesAsync();

            return loaisanpham;
        }

        private bool LoaisanphamExists(string id)
        {
            return _context.Loaisanpham.Any(e => e.Maloai == id);
        }
    }
}
