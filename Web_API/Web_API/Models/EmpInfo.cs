using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class EmpInfo
    {
        public int EmpId { get; set; }
        public string FristName { get; set; }
        public string NameSurename { get; set; }
        public DateTime? Dob { get; set; }
        public int? Mobile { get; set; }
        public string Nic { get; set; }
        public string Email { get; set; }
        public int? BloodId { get; set; }
        public string Address { get; set; }
        public int? Gender { get; set; }
        public int? CreateEmpId { get; set; }
        public DateTime? EmpCreateDate { get; set; }
        public int? Language { get; set; }
        public int? Status { get; set; }
    }
}
