using Microsoft.AspNetCore.Mvc;
using autoFacDemo_DI.Models;
using Autofac;
using Autofac.Extensions.DependencyInjection;
namespace autoFacDemo_DI.Controllers
{
    public class ProductsController : Controller
    {

        Products _pObj;

        public ProductsController(Products _pObjRef)
        {
            _pObj = _pObjRef;
        }
        public IActionResult ProductList()
        {
            return View(_pObj.GetAllProducts());
        }
    }
}
