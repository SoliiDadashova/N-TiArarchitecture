using BusinessAccessLayer.DTOs;
using BusinessAccessLayer.Sevices.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public ICategoryService _categoryService { get; }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
           var all= await _categoryService.GetAllCategories();
            return Ok(all);    
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(AddCategoryDTO categoryDTO)
        {
             await _categoryService.AddCategory(categoryDTO);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO categoryDTO)
        {
            await _categoryService.UpdateCategory(categoryDTO);
            if(categoryDTO == null) { return BadRequest(); };
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);
            return Ok();
        }

    }
}
