using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
using System.Diagnostics;

namespace shoppingAPPMVC.Controllers
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

        public IActionResult About()
        {
            //collect data from model here
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
   
    }
}




