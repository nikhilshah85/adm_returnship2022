using Microsoft.AspNetCore.Mvc;
using repositoryPatternDemo.Repository;
namespace repositoryPatternDemo.Controllers
{
    public class EmployeeController : Controller
    {

        IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository _repoRef)
        {
            _repo = _repoRef;
        }


        public IActionResult ShowEmployees()
        {
            return View(_repo.GetAllEmployees());
        }
    }
}
