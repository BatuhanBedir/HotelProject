﻿using HotelProject.BusinessLayer.Interfaces;
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
    public IActionResult SubscribeList()
    {
        var subscribes = _subscribeService.TGetList();
        return Ok(subscribes);
    }
    [HttpPost]
    public IActionResult AddSubscribe(Subscribe subscribe)
    {
        _subscribeService.TInsert(subscribe);
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteSubscribe(int id)
    {
        var subscribe = _subscribeService.TGetById(id);
        _subscribeService.TDelete(subscribe);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateSubscribe(Subscribe subscribe)
    {
        _subscribeService.TUpdate(subscribe);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetSubscribe(int id)
    {
        var values = _subscribeService.TGetById(id);
        return Ok(values);
    }
}