using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categorySevice;

        public CategoriesController(ICategoryService categorySevice)

        {
            _categorySevice = categorySevice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var category = await _categorySevice.GetAll(languageId);
            return Ok(category);
        }

        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(string languageId, int id)
        {
            var category = await _categorySevice.GetById(languageId, id);
            return Ok(category);
        }
    }
}