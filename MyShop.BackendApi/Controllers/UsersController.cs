using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.System.Users;
using MyShop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var resultToken = await _userServices.Authenticate(request);
            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("User name or password is in correct");
            }

            return Ok(resultToken);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await _userServices.Register(request);
            if (!result)
            {
                return BadRequest("Register is unsuccessull");
            }
            return Ok();
        }

        //http://localhost/api/user/paging?pageindex=1&pageSize=10&kewword=
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPading([FromQuery] GetUserPagingRequest request)
        {
            var product = await _userServices.GetUsersPaging(request);
            return Ok(product);
        }
    }
}