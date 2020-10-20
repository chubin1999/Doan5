using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doan5.WiewModels;
using Doan5.WiewModels.System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Doan5.BackendServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangsanxuatsController : ControllerBase
    {
        //dùng roleManager
        private readonly RoleManager<IdentityRole> _roleManager;
        public HangsanxuatsController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        //URL: POST: http://localhost:5001/api/hangsanxuats
        [HttpPost]
        public async Task<IActionResult> PostHangsanxuat(HangsanxuatVm hangsanxuatVm)
        {
            var role = new IdentityRole()
            {
                Id = hangsanxuatVm.Mahang,
                Name = hangsanxuatVm.Tenhang,
                NormalizedName = hangsanxuatVm.Tenhang.ToUpper()
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return CreatedAtAction(nameof(GetById), new { id = role.Id }, hangsanxuatVm);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        //URL: GET: http://localhost:5001/api/hangsanxuats/
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();

            var rolevms = roles.Select(r => new HangsanxuatVm(){Mahang = r.Id,Tenhang = r.Name,});
            return Ok(rolevms);
        }

        //URL: GET: http://localhost:5001/api/hangsanxuats/?filter={filter}&pageIndex=1&pageSize=10
        [HttpGet]
        public async Task<IActionResult> GetRolesPaging(string filter, int pageIndex, int pageSize)
        {
            var query = _roleManager.Roles;
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(x => x.Id.Contains(filter) || x.Name.Contains(filter));
            }
            var totalRecords = await query.CountAsync();
            var items = await query.Skip((pageIndex - 1 * pageSize))
                .Take(pageSize)
                .Select(r => new HangsanxuatVm()
                {
                    Mahang = r.Id,
                    Tenhang = r.Name
                })
                .ToListAsync();

            var pagination = new Pagination<HangsanxuatVm>
            {
                Items = items,
                TotalRecords = totalRecords,
            };
            return Ok(pagination);
        }

        //URL: GET: http://localhost:5001/api/hangsanxuats/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            var hangsanxuatVm = new HangsanxuatVm()
            {
                Mahang = role.Id,
                Tenhang = role.Name,
            };
            return Ok(hangsanxuatVm);
        }

        //URL: PUT: http://localhost:5001/api/hangsanxuats/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(string id, [FromBody] HangsanxuatVm hangsanxuatVm)
        {
            if (id != hangsanxuatVm.Mahang)
                return BadRequest();

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            role.Name = hangsanxuatVm.Tenhang;
            role.NormalizedName = hangsanxuatVm.Tenhang.ToUpper();

            var result = await _roleManager.UpdateAsync(role);

            if (result.Succeeded)
            {
                return NoContent();
            }
            return BadRequest(result.Errors);
        }

        //URL: DELETE: http://localhost:5001/api/hangsanxuats/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                var rolevm = new HangsanxuatVm()
                {
                    Mahang = role.Id,
                    Tenhang = role.Name
                };
                return Ok(rolevm);
            }
            return BadRequest(result.Errors);
        }
    }
}
