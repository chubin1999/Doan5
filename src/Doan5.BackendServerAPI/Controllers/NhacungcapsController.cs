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
    public class NhacungcapsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public NhacungcapsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Nhacungcaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhacungcap>>> GetNhacungcap()
        {
            return await _context.Nhacungcap.ToListAsync();
        }

        // GET: api/Nhacungcaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhacungcap>> GetNhacungcap(string id)
        {
            var nhacungcap = await _context.Nhacungcap.FindAsync(id);

            if (nhacungcap == null)
            {
                return NotFound();
            }

            return nhacungcap;
        }

        // PUT: api/Nhacungcaps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhacungcap(string id, Nhacungcap nhacungcap)
        {
            if (id != nhacungcap.Manhacungcap)
            {
                return BadRequest();
            }

            _context.Entry(nhacungcap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhacungcapExists(id))
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

        // POST: api/Nhacungcaps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Nhacungcap>> PostNhacungcap(Nhacungcap nhacungcap)
        {
            _context.Nhacungcap.Add(nhacungcap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NhacungcapExists(nhacungcap.Manhacungcap))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNhacungcap", new { id = nhacungcap.Manhacungcap }, nhacungcap);
        }

        // DELETE: api/Nhacungcaps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nhacungcap>> DeleteNhacungcap(string id)
        {
            var nhacungcap = await _context.Nhacungcap.FindAsync(id);
            if (nhacungcap == null)
            {
                return NotFound();
            }

            _context.Nhacungcap.Remove(nhacungcap);
            await _context.SaveChangesAsync();

            return nhacungcap;
        }

        private bool NhacungcapExists(string id)
        {
            return _context.Nhacungcap.Any(e => e.Manhacungcap == id);
        }
    }
}
