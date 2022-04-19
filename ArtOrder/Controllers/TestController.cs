using Microsoft.AspNetCore.Mvc;

namespace ArtOrder.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
