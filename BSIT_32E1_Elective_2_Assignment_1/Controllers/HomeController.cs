using System.Diagnostics;
using BSIT_32E1_Elective_2_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
