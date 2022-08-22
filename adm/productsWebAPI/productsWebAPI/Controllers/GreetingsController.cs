using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace productsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Route("greet")]
        public IActionResult Greetings()
        {
            //method will always return HttpStatus Code
            return Ok("Hello and Welcome to WebAPI");
        }
        [HttpGet]

        [Route("greet/{name}")]
        public IActionResult Grettings(string name)
        {
            return Ok("Hello " + name);
        }

        [HttpGet]
        [Route("products")]
        public IActionResult Products()
        {

            List<string> pList = new List<string>()
            {
                "Pepsi","Coke","Maggie","Pasta","Boat","Head Phones"
            };
            return Ok(pList);

        }

        [HttpGet]
        [Route("employee")]
        public IActionResult EmployeeDetails()
        {
            //thisis not good, u should have createa the object in an Model file
            Employee empObj = new Employee() { empNo = 101, empName = "Suman", empDesignation = "HR", empIsPermenan = true, empSalary = 5000 };
            return Ok(empObj);
        }

    }
}
