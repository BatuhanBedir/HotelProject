﻿using HotelProject.BusinessLayer.Interfaces;
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
    public IActionResult TestimonialList()
    {
        var testimonials = _testimonialService.TGetList();
        return Ok(testimonials);
    }
    [HttpPost]
    public IActionResult AddTestimonial(Testimonial testimonial)
    {
        _testimonialService.TInsert(testimonial);
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteTestimonial(int id)
    {
        var testimonial = _testimonialService.TGetById(id);
        _testimonialService.TDelete(testimonial);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateTestimonial(Testimonial testimonial)
    {
        _testimonialService.TUpdate(testimonial);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetTestimonial(int id)
    {
        var values = _testimonialService.TGetById(id);
        return Ok(values);
    }
}
