using ArtOrder.Core.Constants;
using ArtOrder.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtOrder.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {        
    }
}