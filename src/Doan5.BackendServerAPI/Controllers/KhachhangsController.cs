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
    public class KhachhangsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public KhachhangsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Khachhangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khachhang>>> GetKhachhang()
        {
            return await _context.Khachhang.ToListAsync();
        }

        // GET: api/Khachhangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khachhang>> GetKhachhang(string id)
        {
            var khachhang = await _context.Khachhang.FindAsync(id);

            if (khachhang == null)
            {
                return NotFound();
            }

            return khachhang;
        }

        // PUT: api/Khachhangs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhachhang(string id, Khachhang khachhang)
        {
            if (id != khachhang.Makhachhang)
            {
                return BadRequest();
            }

            _context.Entry(khachhang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhachhangExists(id))
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

        // POST: api/Khachhangs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Khachhang>> PostKhachhang(Khachhang khachhang)
        {
            _context.Khachhang.Add(khachhang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KhachhangExists(khachhang.Makhachhang))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKhachhang", new { id = khachhang.Makhachhang }, khachhang);
        }

        // DELETE: api/Khachhangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Khachhang>> DeleteKhachhang(string id)
        {
            var khachhang = await _context.Khachhang.FindAsync(id);
            if (khachhang == null)
            {
                return NotFound();
            }

            _context.Khachhang.Remove(khachhang);
            await _context.SaveChangesAsync();

            return khachhang;
        }

        private bool KhachhangExists(string id)
        {
            return _context.Khachhang.Any(e => e.Makhachhang == id);
        }
    }
}
