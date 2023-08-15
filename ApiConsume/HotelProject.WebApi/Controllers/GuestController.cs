using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            var values =await _guestService.GetAllAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(Guest guest)
        {
            await _guestService.AddAsync(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuest(int id)
        {
            var values = await _guestService.GetByIdAsync(id);
            await _guestService.DeleteAsync(values);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGuest(Guest guest)
        {
            await _guestService.UpdateAsync(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuest(int id)
        {
            var values = await _guestService.GetByIdAsync(id);
            return Ok(values);
        }
    }
}
