using HotelProject.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DashboardWidgetsController : ControllerBase
{
    private readonly IStaffService _staffService;
    private readonly IBookingService _bookingService;
    private readonly IAppUserService _appUserService;
    private readonly IRoomService _roomService;
    public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
    {
        _staffService = staffService;
        _bookingService = bookingService;
        _appUserService = appUserService;
        _roomService = roomService;
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> StaffCount()
    {
        var value = await _staffService.GetStaffCountAsync();
        return Ok(value);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> BookingCount()
    {
        var value = await _bookingService.GetBookingCountAsync();
        return Ok(value);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> AppUserCount()
    {
        var value = _appUserService.TAppUserCount();
        return Ok(value);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> RoomCount()
    {
        var value = await _roomService.RoomCountAsync();
        return Ok(value);
    }
}
