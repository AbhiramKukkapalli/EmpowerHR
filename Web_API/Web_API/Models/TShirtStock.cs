using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class TShirtStock
    {
        public int Id { get; set; }
        public int? TSNId { get; set; }
        public int? TSSizeId { get; set; }
        public int? TStockQuantity { get; set; }
    }
}
