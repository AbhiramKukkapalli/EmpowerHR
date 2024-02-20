using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class Pass
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string UserName { get; set; }
        public string Pass1 { get; set; }
        public int? LogInOut { get; set; }
        public int? Lock1 { get; set; }
        public int? Lock2 { get; set; }
        public int? CreatEmpId { get; set; }
        public DateTime? CreatDate { get; set; }
        public int? BranchId { get; set; }

        public string Path { get; set; }

        public DateTime? LastLDateTime { get; set; } //LAST_L_DATE_TIME
    }
}
