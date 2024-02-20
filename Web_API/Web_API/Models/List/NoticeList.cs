using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class NoticeListView
    {
        public List<NoticeList> Notice { get; set; }
    }
    public partial class NoticeList
    {
        public int? NoId { get; set; }
        public string NTitel { get; set; }
        public string NBody { get; set; }



        
    }
}
