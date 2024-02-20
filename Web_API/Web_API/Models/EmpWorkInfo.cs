using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class EmpWorkInfo
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? BId { get; set; }
        public int? ReEmpId { get; set; }
        public string Description { get; set; }
        public int? WTId { get; set; }
        public int? PId { get; set; }
        public int? DId { get; set; }
        public DateTime? DOfA { get; set; }
        public DateTime? DOfC { get; set; }
        public DateTime? DOfJoin { get; set; }
        public string NfcNumber { get; set; }
    }
}
