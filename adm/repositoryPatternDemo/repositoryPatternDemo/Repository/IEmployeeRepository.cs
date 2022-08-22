using repositoryPatternDemo.Models;
namespace repositoryPatternDemo.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAllEmployees();

        EmployeeModel GetEmployeeById(int empNo);

        string AddEmployee(EmployeeModel newEmp);

        string DeleteEmployee(int empNo);

        string updateEmployee(EmployeeModel empUpdates);
    }
}
