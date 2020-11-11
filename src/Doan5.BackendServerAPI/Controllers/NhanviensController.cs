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
    public class NhanviensController : ControllerBase
    {
        private readonly Doan5Context _context;

        public NhanviensController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Nhanviens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhanvien>>> GetNhanvien()
        {
            return await _context.Nhanvien.ToListAsync();
        }

        // GET: api/Nhanviens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhanvien>> GetNhanvien(string id)
        {
            var nhanvien = await _context.Nhanvien.FindAsync(id);

            if (nhanvien == null)
            {
                return NotFound();
            }

            return nhanvien;
        }

        // PUT: api/Nhanviens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhanvien(string id, Nhanvien nhanvien)
        {
            if (id != nhanvien.Manhanvien)
            {
                return BadRequest();
            }

            _context.Entry(nhanvien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhanvienExists(id))
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

        // POST: api/Nhanviens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Nhanvien>> PostNhanvien(Nhanvien nhanvien)
        {
            _context.Nhanvien.Add(nhanvien);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NhanvienExists(nhanvien.Manhanvien))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNhanvien", new { id = nhanvien.Manhanvien }, nhanvien);
        }

        // DELETE: api/Nhanviens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nhanvien>> DeleteNhanvien(string id)
        {
            var nhanvien = await _context.Nhanvien.FindAsync(id);
            if (nhanvien == null)
            {
                return NotFound();
            }

            _context.Nhanvien.Remove(nhanvien);
            await _context.SaveChangesAsync();

            return nhanvien;
        }

        private bool NhanvienExists(string id)
        {
            return _context.Nhanvien.Any(e => e.Manhanvien == id);
        }
    }
}
