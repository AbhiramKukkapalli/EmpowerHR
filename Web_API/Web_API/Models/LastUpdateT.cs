using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class LastUpdateT
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Date { get; set; }
        public int? EmpId { get; set; }
    }
}
