using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
   public class Employee_DTO
    {
        public  List<BLOOD_GROUP> Blood_Group_Get { get; set; }
        public List<GENDER> Gender_Get { get; set; }
        public List<LANGUAGE> Language_Get { get; set; }

        public List<STATUS> Status { get; set; }

        public List<Employee_Detail_DTO> Employee_Detail { get; set; }
    }
}
