using System;
using System.Collections.Generic;

namespace repositoryPatternDemo.Models.EF
{
    public partial class EmpDetil
    {
        public int? EmpployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeDesignation { get; set; }
        public int? EmployeePay { get; set; }
        public bool? EmployeeIsPermenant { get; set; }
    }
}
