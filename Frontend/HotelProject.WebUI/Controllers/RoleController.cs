using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using HotelProject.WebUI.ViewComponents.Default;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        [HttpGet]
        public async Task<IActionResult> AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleVm appRoleVm)
        {
            AppRole appRole = new AppRole()
            {
                Name = appRoleVm.Name,
            };

            var result = await _roleManager.CreateAsync(appRole);

            if (result.Succeeded)
                return RedirectToAction("Index");

            return View();
        }
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _roleManager.Roles.First(x => x.Id == id);
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRole(int id)
        {
            var role = _roleManager.Roles.First(x => x.Id == id);
            UpdateRoleVm updateRoleVm = new UpdateRoleVm()
            {
                Id = role.Id,
                Name = role.Name
            };
            return View(updateRoleVm);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleVm updateRoleVm)
        {
            var role = _roleManager.Roles.First(x=>x.Id == updateRoleVm.Id);
            role.Name = updateRoleVm.Name;
            await _roleManager.UpdateAsync(role);
            return RedirectToAction("Index");   
        }
    }
}
