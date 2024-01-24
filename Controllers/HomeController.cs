using Flamix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Flamix.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}