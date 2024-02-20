using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
   public class Work_Emp_Detail_DTO
    {
        public string Emp_Name { get; set; }
        public string Branch_Name { get; set; }
        public string Report { get; set; }
        public string Description { get; set; }
        public string Work_Type  { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public DateTime? D_Of_Appinment { get; set; }
        public DateTime? D_Of_Confirm { get; set; }
        public DateTime? D_Of_Join { get; set; }

        public string NFC_Code { get; set; }


    }
    public class Report_Emp_Detail
    {
        public int? Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Position { get; set; }

        public string Department { get; set; }
    }
}
