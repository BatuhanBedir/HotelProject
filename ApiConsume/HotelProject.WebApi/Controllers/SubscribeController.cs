using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
    private readonly ISubscribeService _subscribeService;

    public SubscribeController(ISubscribeService subscribeService)
    {
        _subscribeService = subscribeService;
    }

    [HttpGet]
    public async Task<IActionResult> SubscribeList()
    {
        var subscribes = await _subscribeService.GetAllAsync();
        return Ok(subscribes);
    }
    [HttpPost]
    public async Task<IActionResult> AddSubscribe(Subscribe subscribe)
    {
        await _subscribeService.AddAsync(subscribe);
        return Ok();
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteSubscribe(int id)
    {
        var subscribe = await _subscribeService.GetByIdAsync(id);
        await _subscribeService.DeleteAsync(subscribe);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateSubscribe(Subscribe subscribe)
    {
        await _subscribeService.UpdateAsync(subscribe);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSubscribe(int id)
    {
        var values = await _subscribeService.GetByIdAsync(id);
        return Ok(values);
    }
}
