using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.Catalog.Products;
using MyShop.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //PUBLIC

        //http://localhost/port/product
        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var product = await _publicProductService.GetAll(languageId);
            return Ok(product);
        }

        //http://localhost/port/product/public-pading
        [HttpGet("public-pading")]
        public async Task<IActionResult> Get([FromQuery] GetPublicProductPagingRequests request)
        {
            var product = await _publicProductService.GetAllByCategoryId(request);
            return Ok(product);
        }

        //MANAGE
        //http://localhost/port/product/1
        [HttpGet("{Id}/{languageId}")]
        public async Task<IActionResult> GetById(int Id, string languageId)
        {
            var product = await _manageProductService.GetById(Id, languageId);
            if (product == null)
            {
                return BadRequest("Cannot find Product");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }
            var product = await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { Id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var affectedResult = await _manageProductService.Delete(Id);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id, decimal newPrice)
        {
            var isSuccessFull = await _manageProductService.UpdatePrice(id, newPrice);
            if (isSuccessFull)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}