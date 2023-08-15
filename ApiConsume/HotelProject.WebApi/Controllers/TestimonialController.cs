using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;

    public TestimonialController(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    [HttpGet]
    public async Task<IActionResult> TestimonialList()
    {
        var testimonials = await _testimonialService.GetAllAsync();
        return Ok(testimonials);
    }
    [HttpPost]
    public async Task<IActionResult> AddTestimonial(Testimonial testimonial)
    {
        await _testimonialService.AddAsync(testimonial);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        var testimonial = await _testimonialService.GetByIdAsync(id);
        await _testimonialService.DeleteAsync(testimonial);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial(Testimonial testimonial)
    {
        await _testimonialService.UpdateAsync(testimonial);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTestimonial(int id)
    {
        var value = await _testimonialService.GetByIdAsync(id);
        return Ok(value);
    }
}
