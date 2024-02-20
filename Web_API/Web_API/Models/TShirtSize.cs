using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class TShirtSize
    {
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
    }
}
