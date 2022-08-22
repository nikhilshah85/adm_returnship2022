using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class PermenantEmployee : Employee,IPermenantEmployees
    {
        public int ApplyLeaves(int days)
        {
            return base.ApplyLeaves(days);
        }

        public string changeContactDetails(string newAddress)
        {
            return base.changeContactDetails(newAddress);
        }

        public double CheckSalaryDetails(int empNo)
        {
            return base.CheckSalaryDetails(empNo);
        }

        public string viewManagerDetails(int managerId)
        {
            return base.viewManagerDetails(managerId);
        }
    }
}
