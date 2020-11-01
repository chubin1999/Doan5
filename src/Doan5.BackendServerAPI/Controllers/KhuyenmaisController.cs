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
    public class KhuyenmaisController : ControllerBase
    {
        private readonly Doan5Context _context;

        public KhuyenmaisController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Khuyenmais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khuyenmai>>> GetKhuyenmai()
        {
            return await _context.Khuyenmai.ToListAsync();
        }

        // GET: api/Khuyenmais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khuyenmai>> GetKhuyenmai(string id)
        {
            var khuyenmai = await _context.Khuyenmai.FindAsync(id);

            if (khuyenmai == null)
            {
                return NotFound();
            }

            return khuyenmai;
        }

        // PUT: api/Khuyenmais/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhuyenmai(string id, Khuyenmai khuyenmai)
        {
            

            _context.Entry(khuyenmai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhuyenmaiExists(id))
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

        // POST: api/Khuyenmais
        
        [HttpPost]
        public async Task<ActionResult<Khuyenmai>> PostKhuyenmai(Khuyenmai khuyenmai)
        {
            _context.Khuyenmai.Add(khuyenmai);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KhuyenmaiExists(khuyenmai.Makhuyenmai))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKhuyenmai", new { id = khuyenmai.Makhuyenmai }, khuyenmai);
        }

        // DELETE: api/Khuyenmais/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Khuyenmai>> DeleteKhuyenmai(string id)
        {
            var khuyenmai = await _context.Khuyenmai.FindAsync(id);
            if (khuyenmai == null)
            {
                return NotFound();
            }

            _context.Khuyenmai.Remove(khuyenmai);
            await _context.SaveChangesAsync();

            return khuyenmai;
        }

        private bool KhuyenmaiExists(string id)
        {
            return _context.Khuyenmai.Any(e => e.Makhuyenmai == id);
        }
    }
}
