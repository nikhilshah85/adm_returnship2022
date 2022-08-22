using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //u cannot create a new object of an Abstract class and an Interface
            //Employee empNew = new IHREmployee();

            IPermenantEmployees emp = new Employee();
            IContractEmployees empContract = new Employee();
            Console.WriteLine(emp.viewManagerDetails(25));

            Employee empObj = new Employee();

            IHREmployee hr = new Employee();
            hr.ArrangeTrainings();
            hr.Holidaylist();
            
        }
    }
}
