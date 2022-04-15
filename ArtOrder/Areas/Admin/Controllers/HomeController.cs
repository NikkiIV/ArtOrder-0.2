using Microsoft.AspNetCore.Mvc;

namespace ArtOrder.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
