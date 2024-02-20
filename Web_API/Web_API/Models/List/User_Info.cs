using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models.List
{
    public class User_Info_List
    {
        public List<User_Info> uInfoList { get; set; }

        public List<Work_Info> work_Info { get; set; }
    }
    public class User_Info
    {
        //user information
        public string fullName { get; set; }
        public string NIC { get; set; }
        public string address { get; set; }
        public int? phoneNumber { get; set; }
        public string Email { get; set; }

        public int? age { get; set; }



    }

    public class Work_Info
    {  // Work Info
        public string Department { get; set; }
        public string Position { get; set; }
        public string WorkType { get; set; }
        public string Branch { get; set; }
        public string Report_To { get; set; }
        public string NFC { get; set; }
        public DateTime? JoinDate { get; set; }
    }
}
