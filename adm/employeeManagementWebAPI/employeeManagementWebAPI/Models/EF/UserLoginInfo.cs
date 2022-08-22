using System;
using System.Collections.Generic;

namespace employeeManagementWebAPI.Models.EF
{
    public partial class UserLoginInfo
    {
        public string UserName { get; set; } = null!;
        public string? Password { get; set; }
    }
}
