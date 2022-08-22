using System;
using System.Collections.Generic;

namespace employeeManagementWebAPI.Models.EF
{
    public partial class DeptInfo
    {
        public DeptInfo()
        {
            EmployeeInfos = new HashSet<EmployeeInfo>();
        }

        public int DeptNo { get; set; }
        public string? DeptName { get; set; }
        public string? DeptLocaton { get; set; }

        public virtual ICollection<EmployeeInfo> EmployeeInfos { get; set; }
    }
}
