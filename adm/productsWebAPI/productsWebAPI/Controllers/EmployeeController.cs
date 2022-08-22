using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace productsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employee empObj = new Employee();

        [HttpGet]
        [Route("elist")]
        public IActionResult GetAllEmployee()
        {
            return Ok(empObj.GetALlEmployees());
        }

        [HttpGet]
        [Route("elist/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(empObj.GetEmployeeById(id));
        }

        [HttpPost]
        [Route("elist/add")]
        public IActionResult AddNewEmployee(Employee newEmpObj)
        {
            return Created("",empObj.AddNEmployee(newEmpObj));
        }

        [HttpPut]
        [Route("elist/edit")]
        public IActionResult UpdateEmployee(Employee changes)
        {
            return Accepted(empObj.UpdateEmployee(changes));
        }
        [HttpDelete]
        [Route("elist/delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return Accepted(empObj.DeleteEmployee(id));
        }


    }
}
