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
    public class HangsanxuatsController : ControllerBase
    {
        private readonly Doan5Context _context;

        public HangsanxuatsController(Doan5Context context)
        {
            _context = context;
        }

        // GET: api/Hangsanxuats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hangsanxuat>>> GetHangsanxuat()
        {
            return await _context.Hangsanxuat.ToListAsync();
        }

        // GET: api/Hangsanxuats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hangsanxuat>> GetHangsanxuat(string id)
        {
            var hangsanxuat = await _context.Hangsanxuat.FindAsync(id);

            if (hangsanxuat == null)
            {
                return NotFound();
            }

            return hangsanxuat;
        }

        // PUT: api/Hangsanxuats/5
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHangsanxuat(string id, Hangsanxuat hangsanxuat)
        {
            

            _context.Entry(hangsanxuat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HangsanxuatExists(id))
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

        // POST: api/Hangsanxuats
        
        [HttpPost]
        public async Task<ActionResult<Hangsanxuat>> PostHangsanxuat(Hangsanxuat hangsanxuat)
        {
            _context.Hangsanxuat.Add(hangsanxuat);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HangsanxuatExists(hangsanxuat.Mahang))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHangsanxuat", new { id = hangsanxuat.Mahang }, hangsanxuat);
        }

        // DELETE: api/Hangsanxuats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hangsanxuat>> DeleteHangsanxuat(string id)
        {
            var hangsanxuat = await _context.Hangsanxuat.FindAsync(id);
            if (hangsanxuat == null)
            {
                return NotFound();
            }

            _context.Hangsanxuat.Remove(hangsanxuat);
            await _context.SaveChangesAsync();

            return hangsanxuat;
        }

        private bool HangsanxuatExists(string id)
        {
            return _context.Hangsanxuat.Any(e => e.Mahang == id);
        }
    }
}
