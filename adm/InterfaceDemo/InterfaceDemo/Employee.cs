using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class  Employee : IPermenantEmployees, IContractEmployees, IHREmployee
    {
        public string ViewAllEmployees()
        {
            return "Below are the list of all the Employees";
        }

        #region IPermenant


        public int ApplyLeaves(int days)
        {
            return 10;
        }

        public string changeContactDetails(string newAddress)
        {
            return "Contact Details changed";
        }

        public double CheckSalaryDetails(int empNo)
        {
            return 30000;
        }
               

        public string viewManagerDetails(int managerId)
        {
            return "Manager details are here";
        }

        #endregion

        #region Contract Employees
        public string SubmitWorkSheet()
        {
            return "Work Submitted - Thank you";
        }

        public int markAttendence()
        {
            return 1;
        }

        public string SendEmail()
        {
            return "Email Sent Successfully";
        }

        public string uploadProjectTask()
        {
            return "Project Uploaded";
        }
        #endregion

        #region HR Employees
        public string RecruitPeople()
        {
            return "Recruitment Drive Open";
        }

        public string ArrangeTrainings()
        {
            return "Training is going to start soon";
        }

        public int getTotalEmployeeCount()
        {
            return 4;
        }

        public List<string> Holidaylist()
        {
            return new List<string>() { "Republic Day", "Independence Day", "Rakshabandhan", "Diwali", "Chrismas" };
        }

        #endregion
    }
}
