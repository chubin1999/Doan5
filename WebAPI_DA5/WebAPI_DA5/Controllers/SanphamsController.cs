using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_DA5.Models;

namespace WebAPI_DA5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public SanphamsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Sanphams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sanpham>>> GetSanpham()
        {
            return await _context.Sanpham.ToListAsync();
        }

        // GET: api/Sanphams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sanpham>> GetSanpham(string id)
        {
            var sanpham = await _context.Sanpham.FindAsync(id);

            if (sanpham == null)
            {
                return NotFound();
            }

            return sanpham;
        }

        // PUT: api/Sanphams/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanpham(string id, Sanpham sanpham)
        {
            if (id != sanpham.Masanpham)
            {
                return BadRequest();
            }

            _context.Entry(sanpham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanphamExists(id))
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

        // POST: api/Sanphams
        [HttpPost]
        public async Task<ActionResult<Sanpham>> PostSanpham(Sanpham sanpham)
        {
            _context.Sanpham.Add(sanpham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SanphamExists(sanpham.Masanpham))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSanpham", new { id = sanpham.Masanpham }, sanpham);
        }

        // DELETE: api/Sanphams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sanpham>> DeleteSanpham(string id)
        {
            var sanpham = await _context.Sanpham.FindAsync(id);
            if (sanpham == null)
            {
                return NotFound();
            }

            _context.Sanpham.Remove(sanpham);
            await _context.SaveChangesAsync();

            return sanpham;
        }

        private bool SanphamExists(string id)
        {
            return _context.Sanpham.Any(e => e.Masanpham == id);
        }
    }
}
