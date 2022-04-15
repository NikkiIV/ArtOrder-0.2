using Microsoft.AspNetCore.Mvc;

namespace ArtOrder.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
