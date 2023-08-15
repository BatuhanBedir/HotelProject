using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }
    [HttpPost]
    public async Task<IActionResult> AddContact(Contact contact)
    {
        contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
        await _contactService.AddAsync(contact);
        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> InboxListContact()
    {
        var contacts =await _contactService.GetAllAsync();
        return Ok(contacts);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSendMessage(int id)
    {
        var contact =await _contactService.GetByIdAsync(id);
        return Ok(contact);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetContactCount()
    {
        return Ok(await _contactService.GetContactCountAsync());
    }
}
