using ArtOrder.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtOrder.Areas.Admin.Controllers
{
    [Authorize(Roles = UserConstants.Roles.Administrator)]
    [Area("Admin")]
    public class BaseController : Controller
    {
    }
}
