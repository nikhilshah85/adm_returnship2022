namespace CodeFirstMVC.Models
{
    public class DeptInfo
    {
        public int Id { get; set; } //this will be the primary key 
        public int deptNo { get; set; }
        public string deptName { get; set; }
        public string deptEmail { get; set; }
        public double deptContact { get; set; }
        public string deptManager { get; set; }

        public virtual List<EmpInfo> empList { get; set; }
    }
}
