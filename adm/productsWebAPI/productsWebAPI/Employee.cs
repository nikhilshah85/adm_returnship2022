namespace productsWebAPI
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenan { get; set; }
        public string empDesignation { get; set; }

        static List<Employee> eList = new List<Employee>()
        {
          new Employee() { empNo = 101, empName = "Suman", empDesignation = "HR", empIsPermenan = false, empSalary = 5000 },
          new Employee() { empNo = 102, empName = "Archana", empDesignation = "Developer", empIsPermenan = true, empSalary = 5000 },
          new Employee() { empNo = 103, empName = "Megha", empDesignation = "Developer", empIsPermenan = true, empSalary = 5000 },
          new Employee() { empNo = 104, empName = "Meenakshi", empDesignation = "Developer", empIsPermenan = true, empSalary = 5000 },
          new Employee() { empNo = 105, empName = "Shilpi", empDesignation = "Developer", empIsPermenan = true, empSalary = 5000 },
          new Employee() { empNo = 106, empName = "Nikhil", empDesignation = "Trainer", empIsPermenan = true, empSalary = 5000 },
          new Employee() { empNo = 107, empName = "Kavithra", empDesignation = "HR", empIsPermenan = true, empSalary = 5000 },
        };


        public List<Employee> GetALlEmployees()
        {
            return eList;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = eList.Find(e => e.empNo == id);
            return emp;
        }

        public string AddNEmployee(Employee newEmp)
        {
            eList.Add(newEmp);
            return "Employee Added Successfully";
        }

        public string DeleteEmployee(int id)
        {
            var emp = eList.Find(e => e.empNo == id);
            eList.Remove(emp);
            return "Employee Deleted Successfully";
        }

        public string UpdateEmployee(Employee newDetails)
        {
            var emp = eList.Find(e => e.empNo == newDetails.empNo);
            emp.empName = newDetails.empName;
            emp.empDesignation = newDetails.empDesignation;
            emp.empSalary = newDetails.empSalary;
            emp.empIsPermenan = newDetails.empIsPermenan;

            return "Employee Update Successfully";
        }




    }
}
