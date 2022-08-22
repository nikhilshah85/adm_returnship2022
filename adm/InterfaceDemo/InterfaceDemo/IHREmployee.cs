using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IHREmployee
    {
        string RecruitPeople();
        string ArrangeTrainings();
        int getTotalEmployeeCount();

        List<string> Holidaylist();

    }
}
