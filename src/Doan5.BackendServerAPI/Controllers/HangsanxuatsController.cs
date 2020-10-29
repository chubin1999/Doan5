using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doan5.BackendServerAPI.Models;
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
        
        private readonly Doan5Context _context;

        public HangsanxuatsController(Doan5Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _context.Hangsanxuat
                .Select(r => new HangsanxuatVm()
                {
                    Mahang = r.Mahang,
                    Tenhang = r.Tenhang,
                    Mota = r.Mota
                })
                .ToListAsync();

            return Ok(roles);
        }

    }
}
