using Microsoft.AspNetCore.Mvc;

namespace YallaDigital.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}