using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ServiceController : ControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService ServiceService)
    {
        _serviceService = ServiceService;
    }

    [HttpGet]
    public async Task<IActionResult> ServiceList()
    {
        var services = await _serviceService.GetAllAsync();
        return Ok(services);
    }
    [HttpPost]
    public async Task<IActionResult> AddService(Service service)
    {
        await _serviceService.AddAsync(service);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(int id)
    {
        var service = await _serviceService.GetByIdAsync(id);
        await _serviceService.DeleteAsync(service);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateService(Service service)
    {
        await _serviceService.UpdateAsync(service);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetService(int id)
    {
        var service =await _serviceService.GetByIdAsync(id);
        return Ok(service);
    }
}
