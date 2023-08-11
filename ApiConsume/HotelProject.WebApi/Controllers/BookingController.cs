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
    public IActionResult BookingList()
    {
        var bookings = _bookingService.TGetList();
        return Ok(bookings);
    }
    [HttpPost]
    public IActionResult AddBooking(Booking booking)
    {
        _bookingService.TInsert(booking);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        var booking = _bookingService.TGetById(id);
        _bookingService.TDelete(booking);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateBooking(Booking booking)
    {
        _bookingService.TUpdate(booking);
        return Ok();
    }
    [HttpPut("[action]")]
    public IActionResult BookingAproved(int id)
    {
        _bookingService.TBookingStatusChangeApproved(id);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetBooking(int id)
    {
        var booking = _bookingService.TGetById(id);
        return Ok(booking);
    }
    [HttpGet("[action]")]
    public IActionResult Last6Bookings()
    {
        return Ok(_bookingService.TLast6Bookings());
    }
}
