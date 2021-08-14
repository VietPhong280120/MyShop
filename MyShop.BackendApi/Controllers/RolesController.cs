using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.System.Roles;
using MyShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleServices _roleServices;

        public RolesController(IRoleServices roleServices)
        {
            _roleServices = roleServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleServices.GetAll();
            return Ok(roles);
        }
    }
}