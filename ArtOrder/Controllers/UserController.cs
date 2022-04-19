using ArtOrder.Core.Constants;
using ArtOrder.Core.Contracts;
using ArtOrder.Core.Models;
using ArtOrder.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ArtOrder.Controllers
{
    public class UserController : BaseController
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IUserService service;

        public UserController(
            RoleManager<IdentityRole> _roleManager, 
            IUserService _service)
        {
            roleManager = _roleManager;
            service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Edit(string arg)
        {           
            return View();
        }
    }
}
