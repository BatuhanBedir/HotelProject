using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> CategoryList()
    {
        var categories = await _categoryService.GetAllAsync();
        return Ok(categories);
    }
    [HttpPost]
    public async Task<IActionResult> AddCategory(Category category)
    {
        await _categoryService.AddAsync(category);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);
        await _categoryService.DeleteAsync(category);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCategory(Category category)
    {
        await _categoryService.UpdateAsync(category);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategory(int id)
    {
        var values =await _categoryService.GetByIdAsync(id);
        return Ok(values);
    }
}
