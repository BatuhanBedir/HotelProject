using HotelProject.BusinessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SendMessageController : ControllerBase
{
    private readonly ISendMessageService _sendMessageService;

    public SendMessageController(ISendMessageService sendMessageService)
    {
        _sendMessageService = sendMessageService;
    }

    [HttpGet]
    public async Task<IActionResult> SendMessageList()
    {
        var SendMessages = await _sendMessageService.GetAllAsync();
        return Ok(SendMessages);
    }
    [HttpPost]
    public async Task<IActionResult> AddSendMessage(SendMessage sendMessage)
    {
        await _sendMessageService.AddAsync(sendMessage);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSendMessage(int id)
    {
        var sendMessage = await _sendMessageService.GetByIdAsync(id);
        await _sendMessageService.DeleteAsync(sendMessage);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateSendMessage(SendMessage sendMessage)
    {
        await _sendMessageService.UpdateAsync(sendMessage);
        return Ok();
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetSendMessage(int id)
    {
        var values = await _sendMessageService.GetByIdAsync(id);
        return Ok(values);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetSendMessageCount()
    {
        return Ok(await _sendMessageService.GetSendMessageCountAsync());
    }
}
