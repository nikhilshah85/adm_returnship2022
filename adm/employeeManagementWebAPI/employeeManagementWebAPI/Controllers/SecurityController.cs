using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using employeeManagementWebAPI.Models.EF;
namespace employeeManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {

        private employeeDBContext _context;
        public SecurityController(employeeDBContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //[Route("login")]

        //public IActionResult Login(string uName, string pwd)
        //{
        //    UserLoginInfo uObj = new UserLoginInfo();

        //    //var result = uObj.CheckLogin(uName, pwd);
        //    return Ok(result);
            
        //}

        


    }
}
