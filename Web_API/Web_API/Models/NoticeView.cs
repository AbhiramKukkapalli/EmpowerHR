using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class NoticeView
    {
        public int NoId { get; set; }
        public string NTitel { get; set; }
        public string PositionName { get; set; }
        public string NameSurename { get; set; }
        public int? DId { get; set; }
        public int? PId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? From { get; set; }

        public string NBody { get; set; }

        public int Count_Notice { get; set; }
    }
}
