using repositoryPatternDemo.Repository;

namespace repositoryPatternDemo.Models
{
    public class EmployeeCollection : IEmployeeRepository
    {

        static List<EmployeeModel> eList = new List<EmployeeModel>()
        {
            new EmployeeModel(){ empNo=101, empName="Collection 1", empDesignation="HR", empSalary=500, empIsPermenant=true},
            new EmployeeModel(){ empNo=102, empName="Collection 2", empDesignation="HR", empSalary=500, empIsPermenant=true},
            new EmployeeModel(){ empNo=103, empName="Collection 3", empDesignation="HR", empSalary=500, empIsPermenant=true},
            new EmployeeModel(){ empNo=104, empName="Collection 4", empDesignation="HR", empSalary=500, empIsPermenant=true},
            new EmployeeModel(){ empNo=105, empName="Collection 5", empDesignation="HR", empSalary=500, empIsPermenant=true},
        };



        public string AddEmployee(EmployeeModel newEmp)
        {
            eList.Add(newEmp);
            return "Employee Added to Collection";
        }

        public string DeleteEmployee(int empNo)
        {
            var emp = eList.Find(e => e.empNo == empNo);
            eList.Remove(emp);
            return "Employee Deleted Successfully from Collection";

        }

        public List<EmployeeModel> GetAllEmployees()
        {
            return eList;
        }

        public EmployeeModel GetEmployeeById(int empNo)
        {
            var emp = eList.Find(e => e.empNo == empNo);

            return emp;
        }

        public string updateEmployee(EmployeeModel empUpdates)
        {
            var emp = eList.Find(e => e.empNo == empUpdates.empNo);
            emp.empName = empUpdates.empName;
            emp.empDesignation = empUpdates.empDesignation;
            emp.empSalary = empUpdates.empSalary;
            emp.empIsPermenant = empUpdates.empIsPermenant;

            return "Employee Updated in collection";
        }
    }
}









