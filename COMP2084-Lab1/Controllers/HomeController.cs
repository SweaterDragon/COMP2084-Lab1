using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP2084_Lab1.Models;

namespace COMP2084_Lab1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
        // Addition method  ~Home/Addition?x=2&y=4 would return 6
        public string Addition(int x, int y)
        {
            string message = "Result = " + (x + y);
            return message;
        }
        // Multiplication method  ~Home/Multiplication?x=2&y=4 would return 8
        public string Multiplication(int x, int y)
        {
            string message = "Result = " + (x * y);
            return message;
        }

    }
}
