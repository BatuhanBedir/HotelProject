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
    public IActionResult ServiceList()
    {
        var services = _serviceService.TGetList();
        return Ok(services);
    }
    [HttpPost]
    public IActionResult AddService(Service service)
    {
        _serviceService.TInsert(service);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteService(int id)
    {
        var service = _serviceService.TGetById(id);
        _serviceService.TDelete(service);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateService(Service service)
    {
        _serviceService.TUpdate(service);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetService(int id)
    {
        var service = _serviceService.TGetById(id);
        return Ok(service);
    }
}
