using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
    private readonly IAboutService _aboutService;

    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    [HttpGet]
    public async Task<IActionResult> AboutList()
    {
        var abouts = await _aboutService.GetAllAsync();
        return Ok(abouts);
    }
    [HttpPost]
    public async Task<IActionResult> AddAbout(About about)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _aboutService.AddAsync(about);
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteAbout(int id)
    {
        var about = await _aboutService.GetByIdAsync(id);
        await _aboutService.DeleteAsync(about);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateAbout(About about)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _aboutService.UpdateAsync(about);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAbout(int id)
    {
        var about = await _aboutService.GetByIdAsync(id);
        return Ok(about);
    }
}
