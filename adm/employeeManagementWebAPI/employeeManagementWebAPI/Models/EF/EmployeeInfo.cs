using System;
using System.Collections.Generic;

namespace employeeManagementWebAPI.Models.EF
{
    public partial class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? EmpDesigantion { get; set; }
        public int? EmpSalary { get; set; }
        public int? EmpDept { get; set; }

        public virtual DeptInfo? EmpDeptNavigation { get; set; }
    }
}
