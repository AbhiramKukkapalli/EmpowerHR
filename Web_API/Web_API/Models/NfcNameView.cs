using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class NfcNameView
    {
        public string NameSurename { get; set; }
        public string NfcNumber { get; set; }
        public int? EmpId { get; set; }
        public string FristName { get; set; }
    }
}
