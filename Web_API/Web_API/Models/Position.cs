using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class Position
    {
        public Position()
        {
            Notice = new HashSet<Notice>();
        }

        public int PId { get; set; }
        public string PositionName { get; set; }
        public int? DId { get; set; }

        public virtual ICollection<Notice> Notice { get; set; }
    }
}
