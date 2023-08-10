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
    public IActionResult CategoryList()
    {
        var categories = _categoryService.TGetList();
        return Ok(categories);
    }
    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
        _categoryService.TInsert(category);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var category = _categoryService.TGetById(id);
        _categoryService.TDelete(category);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateCategory(Category category)
    {
        _categoryService.TUpdate(category);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        var values = _categoryService.TGetById(id);
        return Ok(values);
    }
}
