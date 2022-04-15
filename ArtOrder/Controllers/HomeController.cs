using ArtOrder.Core.Constants;
using ArtOrder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtOrder.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData[MessageConstant.ErrorMessage] = "Грешка!";
            //ViewData[MessageConstants.WarningMessage] = "Внимавай!";
            //ViewData[MessageConstants.SuccessMessage] = "Работи!";

            return View();
        }

        public IActionResult Privacy(ErrorViewModel error)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}