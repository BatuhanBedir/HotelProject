using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpGet]
    public async Task<IActionResult> BookingList()
    {
        var bookings = await _bookingService.GetAllAsync();
        return Ok(bookings);
    }
    [HttpPost]
    public async Task<IActionResult> AddBooking(Booking booking)
    {
        await _bookingService.AddAsync(booking);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var booking = await _bookingService.GetByIdAsync(id);
        await _bookingService.DeleteAsync(booking);
        return Ok();
    }
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateBooking(Booking booking)
    {
        await _bookingService.UpdateAsync(booking);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooking(int id)
    {
        var booking = await _bookingService.GetByIdAsync(id);
        return Ok(booking);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> Last6Bookings()
    {
        return Ok(await _bookingService.Last6BookingsAsync());
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> BookingStatus([FromQuery] int id, [FromQuery] string status)
    {
        await _bookingService.BookingStatusChangeAsync(id, status);
        return Ok();
    }

}
