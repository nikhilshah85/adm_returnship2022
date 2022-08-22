using System.ComponentModel.DataAnnotations;

namespace CodeFirstMVC.Models
{
    public class EmpInfo
    {
        [Key]
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesigantion { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        
        public virtual DeptInfo empDept { get; set; }
    }
}
