using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class RoleAssignController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<AppRole> _roleManager;

    public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }
    [HttpGet]
    public async Task<IActionResult> AssignRole(int id)
    {
        var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
        TempData["userId"] = user.Id;

        var roles = _roleManager.Roles.ToList();
        var userRoles = await _userManager.GetRolesAsync(user);

        List<RoleAssignVm> roleAssignVms = new List<RoleAssignVm>();

        foreach (var item in roles)
        {
            RoleAssignVm roleAssignVm = new RoleAssignVm();
            roleAssignVm.Id = item.Id;
            roleAssignVm.Name = item.Name;
            roleAssignVm.Exist = userRoles.Contains(item.Name);
            roleAssignVms.Add(roleAssignVm);
        }
        return View(roleAssignVms);
    }
    [HttpPost]
    public async Task<IActionResult> AssignRole(List<RoleAssignVm> roleAssignVms)
    {
        var userId = (int)TempData["userId"];
        var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
        var userRoles = await _userManager.GetRolesAsync(user);

        var rolesToRemove = userRoles.Except(roleAssignVms.Where(item => item.Exist).Select(item => item.Name)).ToList();

        foreach (var role in rolesToRemove)
        {
            await _userManager.RemoveFromRoleAsync(user, role);
        }

        foreach (var item in roleAssignVms)
        {
            if (item.Exist)
            {
                await _userManager.AddToRoleAsync(user, item.Name);
            }
        }
        userRoles = await _userManager.GetRolesAsync(user);

        return RedirectToAction("Index");
    }
}
