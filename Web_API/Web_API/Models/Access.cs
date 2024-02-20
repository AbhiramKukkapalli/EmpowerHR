using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class Access
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? MenuA { get; set; }
        public int? MenuB { get; set; }
        public int? MenuC { get; set; }
        public int? MenuD { get; set; }
    }
}
