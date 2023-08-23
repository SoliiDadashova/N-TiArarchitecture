using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Sevices.ProductService.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService _productService { get; }
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
           var all= await _productService.GetAllProducts();
            return Ok(all);
        }
        [HttpPost]
        public async Task<IActionResult>AddProduct(AddProductDTO productDTO)
        {
            if(productDTO == null)
            {
                return BadRequest();
            }
            await _productService.AddProduct(productDTO);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO productDTO)
        {
            await _productService.UpdateProduct(productDTO);
            if (productDTO == null) { return BadRequest(); };
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProduct(id);
            return Ok();    
        }
    }
}
