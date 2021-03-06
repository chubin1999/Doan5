﻿using System;
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
    public class DanhmucsanphamsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public DanhmucsanphamsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Danhmucsanphams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Danhmucsanpham>>> GetDanhmucsanpham()
        {
            return await _context.Danhmucsanpham.ToListAsync();
        }

        // GET: api/Danhmucsanphams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Danhmucsanpham>> GetDanhmucsanpham(string id)
        {
            var danhmucsanpham = await _context.Danhmucsanpham.FindAsync(id);

            if (danhmucsanpham == null)
            {
                return NotFound();
            }

            return danhmucsanpham;
        }
        [HttpGet("getlistchild/{id}")]
        public async Task<ActionResult<IEnumerable<Loaisanpham>>> GetLoaisanpham(string id)
        {
            return await _context.Loaisanpham.Where(x => x.Madanhmuc == id).ToListAsync(); 

            //return await danhmucsanpham.ToListAsync();
        }
        // PUT: api/Danhmucsanphams/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDanhmucsanpham(string id, Danhmucsanpham danhmucsanpham)
        {
            

            _context.Entry(danhmucsanpham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DanhmucsanphamExists(id))
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

        // POST: api/Danhmucsanphams
       
        [HttpPost]
        public async Task<ActionResult<Danhmucsanpham>> PostDanhmucsanpham(Danhmucsanpham danhmucsanpham)
        {
            _context.Danhmucsanpham.Add(danhmucsanpham);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DanhmucsanphamExists(danhmucsanpham.Madanhmuc))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDanhmucsanpham", new { id = danhmucsanpham.Madanhmuc }, danhmucsanpham);
        }

        // DELETE: api/Danhmucsanphams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Danhmucsanpham>> DeleteDanhmucsanpham(string id)
        {
            var danhmucsanpham = await _context.Danhmucsanpham.FindAsync(id);
            if (danhmucsanpham == null)
            {
                return NotFound();
            }

            _context.Danhmucsanpham.Remove(danhmucsanpham);
            await _context.SaveChangesAsync();

            return danhmucsanpham;
        }

        private bool DanhmucsanphamExists(string id)
        {
            return _context.Danhmucsanpham.Any(e => e.Madanhmuc == id);
        }
    }
}
