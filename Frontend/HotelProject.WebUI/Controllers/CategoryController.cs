using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
