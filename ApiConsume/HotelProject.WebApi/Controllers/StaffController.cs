using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
    private readonly IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }

    [HttpGet]
    public IActionResult StaffList()
    {
        var staffs = _staffService.TGetList();
        return Ok(staffs);
    }
    [HttpPost]
    public IActionResult AddStaff(Staff staff)
    {
        _staffService.TInsert(staff);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteStaff(int id)
    {
        var staff = _staffService.TGetById(id);
        _staffService.TDelete(staff);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateStaff(Staff staff)
    {
        _staffService.TUpdate(staff);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetStaff(int id)
    { 
        var values = _staffService.TGetById(id);
        return Ok(values);
    }
}
