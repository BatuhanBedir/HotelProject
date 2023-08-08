﻿using HotelProject.BusinessLayer.Interfaces;
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
    public IActionResult SendMessageList()
    {
        var SendMessages = _sendMessageService.TGetList();
        return Ok(SendMessages);
    }
    [HttpPost]
    public IActionResult AddSendMessage(SendMessage sendMessage)
    {
        _sendMessageService.TInsert(sendMessage);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteSendMessage(int id)
    {
        var sendMessage = _sendMessageService.TGetById(id);
        _sendMessageService.TDelete(sendMessage);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateSendMessage(SendMessage sendMessage)
    {
        _sendMessageService.TUpdate(sendMessage);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetSendMessage(int id)
    {
        var values = _sendMessageService.TGetById(id);
        return Ok(values);
    }
}
