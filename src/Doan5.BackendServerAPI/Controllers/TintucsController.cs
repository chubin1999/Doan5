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
    public class TintucsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public TintucsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Tintucs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tintuc>>> GetTintuc()
        {
            return await _context.Tintuc.ToListAsync();
        }

        // GET: api/Tintucs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tintuc>> GetTintuc(string id)
        {
            var tintuc = await _context.Tintuc.FindAsync(id);

            if (tintuc == null)
            {
                return NotFound();
            }

            return tintuc;
        }

        // PUT: api/Tintucs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTintuc(string id, Tintuc tintuc)
        {
            if (id != tintuc.Matintuc)
            {
                return BadRequest();
            }

            _context.Entry(tintuc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TintucExists(id))
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

        // POST: api/Tintucs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tintuc>> PostTintuc(Tintuc tintuc)
        {
            _context.Tintuc.Add(tintuc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TintucExists(tintuc.Matintuc))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTintuc", new { id = tintuc.Matintuc }, tintuc);
        }

        // DELETE: api/Tintucs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tintuc>> DeleteTintuc(string id)
        {
            var tintuc = await _context.Tintuc.FindAsync(id);
            if (tintuc == null)
            {
                return NotFound();
            }

            _context.Tintuc.Remove(tintuc);
            await _context.SaveChangesAsync();

            return tintuc;
        }

        private bool TintucExists(string id)
        {
            return _context.Tintuc.Any(e => e.Matintuc == id);
        }
    }
}
