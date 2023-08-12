using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class SettingsController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public SettingsController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditVm userEditVm = new UserEditVm()
        {
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            Username = user.UserName,
        };
        return View(userEditVm);
    }
    [HttpPost]
    public async Task<IActionResult> Index(UserEditVm userEditVm)
    {
        if (userEditVm.Password == userEditVm.ConfirmPassword)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = userEditVm.Name;
            user.Surname = userEditVm.Surname;
            user.Email = userEditVm.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditVm.Password);
            await _userManager.UpdateAsync(user);
        return RedirectToAction("Index", "Login");
        }
        return View();
    }
}
