using repositoryPatternDemo.Models;

namespace repositoryPatternDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {


        IEmployeeRepository _empRepository;



        public string AddEmployee(EmployeeModel newEmp)
        {
            return _empRepository.AddEmployee(newEmp);
        }

        public string DeleteEmployee(int empNo)
        {
            return _empRepository.DeleteEmployee(empNo);
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return _empRepository.GetAllEmployees();
        }

        public EmployeeModel GetEmployeeById(int empNo)
        {
            return _empRepository.GetEmployeeById(empNo);
        }

        public string updateEmployee(EmployeeModel empUpdates)
        {
            return _empRepository.updateEmployee(empUpdates);
        }
    }
}
