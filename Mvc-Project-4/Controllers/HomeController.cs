using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mvc_Project_4.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {          
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}