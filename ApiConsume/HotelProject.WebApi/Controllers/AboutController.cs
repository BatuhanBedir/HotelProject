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
    public IActionResult AboutList()
    {
        var abouts = _aboutService.TGetList();
        return Ok(abouts);
    }
    [HttpPost]
    public IActionResult AddAbout(About about)
    {
        _aboutService.TInsert(about);
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteAbout(int id)
    {
        var about = _aboutService.TGetById(id);
        _aboutService.TDelete(about);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateAbout(About about)
    {
        _aboutService.TUpdate(about);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetAbout(int id)
    {
        var about = _aboutService.TGetById(id);
        return Ok(about);
    }
}
