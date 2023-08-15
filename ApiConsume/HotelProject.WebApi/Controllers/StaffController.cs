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
    public async Task<IActionResult> StaffList()
    {
        var staffs = await _staffService.GetAllAsync();
        return Ok(staffs);
    }
    [HttpPost]
    public async Task<IActionResult> AddStaff(Staff staff)
    {
        await _staffService.AddAsync(staff);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStaff(int id)
    {
        var staff = await _staffService.GetByIdAsync(id);
        await _staffService.DeleteAsync(staff);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateStaff(Staff staff)
    {
        await _staffService.UpdateAsync(staff);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetStaff(int id)
    {
        var values = await _staffService.GetByIdAsync(id);
        return Ok(values);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> Last4Staff()
    {
        return Ok(await _staffService.Last4StaffAsync());
    }
}
