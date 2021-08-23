using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.Utilities.Slides;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Slides : ControllerBase
    {
        private readonly ISlideServices _slideServices;

        public Slides(ISlideServices slideServices)
        {
            _slideServices = slideServices;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _slideServices.GetAll();
            return Ok(roles);
        }
    }
}