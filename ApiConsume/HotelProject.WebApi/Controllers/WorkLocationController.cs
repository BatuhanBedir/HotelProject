using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkLocationController : ControllerBase
{
    private readonly IWorkLocationService _workLocationService;

    public WorkLocationController(IWorkLocationService workLocationService)
    {
        _workLocationService = workLocationService;
    }

    [HttpGet]
    public async Task<IActionResult> WorkLocationList()
    {
        var workLocation =await _workLocationService.GetAllAsync();
        return Ok(workLocation);
    }
    [HttpPost]
    public async Task<IActionResult> AddWorkLocation(WorkLocation workLocation)
    {
        await _workLocationService.AddAsync(workLocation);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWorkLocation(int id)
    {
        var workLocation = await _workLocationService.GetByIdAsync(id);
        await _workLocationService.DeleteAsync(workLocation);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateWorkLocation(WorkLocation workLocation)
    {
        await _workLocationService.UpdateAsync(workLocation);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetWorkLocation(int id)
    {
        var values = await _workLocationService.GetByIdAsync(id);
        return Ok(values);
    }
}
