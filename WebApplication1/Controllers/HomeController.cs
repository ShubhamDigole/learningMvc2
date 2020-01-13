using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

using WebApplication1.DAL;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IclassInitializer _repository;
        public HomeController(ILogger<HomeController> logger, IclassInitializer repository)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["anotherTest"] = DateTime.Now.ToString();
            ViewData["Name"] = "shubam";
            return Redirect("Data/AddUser");
        }

        public IActionResult Privacy()
        {
            TempData["anotherTest"] = DateTime.Now.ToString();
            ViewData["Name"] = DateTime.Now.ToString();
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult buttonTest()
        {
            int abcd = 100;
            return View(abcd);
         /*   return View(_repository.addStu());*/

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
