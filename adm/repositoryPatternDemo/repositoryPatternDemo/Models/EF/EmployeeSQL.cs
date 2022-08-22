using repositoryPatternDemo.Repository;
using repositoryPatternDemo.Models.EF;
namespace repositoryPatternDemo.Models.EF
{
    public class EmployeeSQL : IEmployeeRepository
    {

        repositoryDemoDBContext _db = new repositoryDemoDBContext();


        public string AddEmployee(EmployeeModel newEmp)
        {
            throw new NotImplementedException();
        }

        public string DeleteEmployee(int empNo)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            var allEmpfromDB = (from em in _db.EmpDetils
                                select em).ToList();

            List<EmployeeModel> allEmp = new List<EmployeeModel>();
            foreach (var item in allEmpfromDB)
            {
                allEmp.Add(new EmployeeModel()
                {
                    empNo = Convert.ToInt32(item.EmpployeeNo),
                    empName = item.EmployeeName.ToString(),
                    empDesignation = item.EmployeeDesignation.ToString(),
                    empSalary = Convert.ToDouble(item.EmployeePay),
                    empIsPermenant =Convert.ToBoolean(item.EmployeeIsPermenant)
                });               
            }
            return allEmp;

        }

        public EmployeeModel GetEmployeeById(int empNo)
        {
            throw new NotImplementedException();
        }

        public string updateEmployee(EmployeeModel empUpdates)
        {
            throw new NotImplementedException();
        }
    }
}
