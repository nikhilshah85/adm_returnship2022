using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IContractEmployees
    {
        string SubmitWorkSheet();
        int markAttendence();
        string SendEmail();
        string uploadProjectTask();
    }
}
