using HotelProject.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        var users = _appUserService.TUserListWithWorkLocation();
        return Ok(users);
    }
    [HttpGet]
    public IActionResult AppUserList()
    {
        var appUsers = _appUserService.TGetList();
        return Ok(appUsers);
    }
}
