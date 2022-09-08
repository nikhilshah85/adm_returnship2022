using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsMS.Models;
namespace productsMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products(); //instead use DI - dipendency injection;


        [HttpGet]
        [Route("plist")]
        public IActionResult GetALlProducts()
        {
            return Ok(pObj.GetAllProducts());
        }

        [HttpGet]
        [Route("plist/{productId}")]
        public IActionResult GetProductById(int productId)
        {
            try
            {
                return Ok(pObj.GetProductById(productId));
            }
            catch (Exception es)
            {
                return NotFound(es.Message);                
            }
        }


        [HttpPost]
        [Route("plist")]
        public IActionResult AddProduct([FromBody] Products newproducts)
        {
            return Created("",pObj.AddnewProduct(newproducts));
            
        }

    }
}
