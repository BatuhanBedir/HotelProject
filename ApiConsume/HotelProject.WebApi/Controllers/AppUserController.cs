using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppUserController : ControllerBase
{
    private readonly IAppUserService _appUserService;

    public AppUserController(IAppUserService appUserService)
    {
        _appUserService = appUserService;
    }

    [HttpGet("[action]")]
    public IActionResult UserListWorkLocation()
    {
        
        var values = _appUserService.TUserListWorkLocation();
        return Ok(values);
    }
    [HttpGet]
    public IActionResult AppUserList()
    {
        var appUsers = _appUserService.TGetList();
        return Ok(appUsers);
    }
}
