using AutoMapper;
using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Room2Controller : ControllerBase
{
    private readonly IRoomService _roomService;
    private readonly IMapper _mapper;

    public Room2Controller(IRoomService roomService, IMapper mapper)
    {
        _roomService = roomService;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var value =  await _roomService.GetAllAsync();
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> AddRoom(RoomAddDto roomAddDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var value = _mapper.Map<Room>(roomAddDto);
        await _roomService.AddAsync(value);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateRoom(UpdateRoomDto updateRoomDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var values = _mapper.Map<Room>(updateRoomDto);
        await _roomService.UpdateAsync(values);
        return Ok("Başarıyla Güncellendi");
    }
}
