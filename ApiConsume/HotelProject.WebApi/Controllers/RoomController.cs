using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomController : ControllerBase
{
    private readonly IRoomService _roomService;

    public RoomController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    public async Task<IActionResult> RoomList()
    {
        var rooms = await _roomService.GetAllAsync();
        return Ok(rooms);
    }
    [HttpPost]
    public async Task<IActionResult> AddRoom(Room room)
    {
        await _roomService.AddAsync(room);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoom(int id)
    {
        var room = await _roomService.GetByIdAsync(id);
        await _roomService.DeleteAsync(room);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateRoom(Room room)
    {
        await _roomService.UpdateAsync(room);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoom(int id)
    {
        var room = await _roomService.GetByIdAsync(id);
        return Ok(room);
    }
}
