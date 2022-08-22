using repositoryPatternDemo.Repository;

namespace repositoryPatternDemo.Models
{
    public class EmployeeMongoDB : IEmployeeRepository
    {
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
            List<EmployeeModel> empListFromMongoDB = new List<EmployeeModel>()
            {
                new EmployeeModel(){ empNo=701, empName="Mongo 1", empDesignation="Sales", empIsPermenant=false, empSalary=300},
                new EmployeeModel(){ empNo=702, empName="Mongo 2", empDesignation="Sales", empIsPermenant=false, empSalary=300},
                new EmployeeModel(){ empNo=703, empName="Mongo 3", empDesignation="Sales", empIsPermenant=false, empSalary=300},
                new EmployeeModel(){ empNo=704, empName="Mongo 4", empDesignation="Sales", empIsPermenant=false, empSalary=300},
                new EmployeeModel(){ empNo=705, empName="Mongo 5", empDesignation="Sales", empIsPermenant=false, empSalary=300},
                new EmployeeModel(){ empNo=706, empName="Mongo 6", empDesignation="Sales", empIsPermenant=false, empSalary=300},
            };
            return empListFromMongoDB;
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
