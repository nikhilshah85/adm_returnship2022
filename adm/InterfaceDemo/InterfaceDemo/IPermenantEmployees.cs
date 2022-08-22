using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IPermenantEmployees
    {
        int ApplyLeaves(int days);
        double CheckSalaryDetails(int empNo);
        string viewManagerDetails(int managerId);
        string changeContactDetails(string newAddress);
    }
}
