using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class SaleTShirt
    {
        public int Id { get; set; }
        public int? TSNId { get; set; }
        public int? TSSizeId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? Date { get; set; }
        public int? BId { get; set; }
        public string ResiptNo { get; set; }
        public int? States { get; set; }
        public int? Quantity { get; set; }

        public int? OderId { get; set; }
    }
}
