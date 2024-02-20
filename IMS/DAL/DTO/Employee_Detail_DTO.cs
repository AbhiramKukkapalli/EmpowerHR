using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class Employee_Detail_DTO
    {
        public int Emp_ID { get; set; }

        public string Frist_Name { get; set; }

        public string Sure_Name { get; set; }
        public DateTime? DOB { get; set; }

        public int? Mobile { get; set; }
        public string NIC { get; set; }
        public string Email { get; set; }
        public string Blood_Name { get; set; }
        public string Address  { get; set; }
        public string Gender { get; set; }
        public string  Language { get; set; }

        public string Sataus { get; set; }
    }

}
