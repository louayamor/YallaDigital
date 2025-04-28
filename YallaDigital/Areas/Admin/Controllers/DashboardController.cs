using Microsoft.AspNetCore.Mvc;

namespace YallaDigital.Areas.Admin.Controllers;

public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}