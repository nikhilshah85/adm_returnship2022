using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC.Models;
namespace shoppingAPPMVC.Controllers
{
    public class ProductsController : Controller
    {

        Products pObj = new Products();

        public IActionResult DisplayProducts()
        {
            ViewBag.products = pObj.GetAllProduts();
            ViewBag.myName = "Nikhil";
            ViewBag.totalProducts = pObj.GetAllProduts().Count;

            return View();
        }

        public IActionResult Greet()
        {
            
            return View();
        }
        

        [HttpPost]
        public IActionResult Greet(string guestName)
        {
            ViewBag.message = "Welcome to ASP.Net Core world : " +  guestName;
            return View();
        }
    }
}
