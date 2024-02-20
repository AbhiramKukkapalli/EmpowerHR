using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class Notice
    {
        public int NoId { get; set; }
        public int? DId { get; set; }
        public int? PId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? From { get; set; }
        public string NTitel { get; set; }
        public string NBody { get; set; }
        public int? NPutId { get; set; }
        public int? NFromAll { get; set; }
        public int? PutPId { get; set; }
        public DateTime? NLUpdateDate { get; set; }

        public virtual Position PutP { get; set; }
    }
}
