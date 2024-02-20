using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.T_SHIRT_DTO
{
   public class T_Shirt_Oder_Ditail_DTO
    {
        public int? id { get; set; }
        public string t_name { get; set; }
        public string t_size { get; set; }

        public string emp_name { get; set; }

        public DateTime? oder_date { get; set; }
        public string emp_branch { get; set; }
        public string recipt_no { get; set; }
        public string states { get; set; }
        public int?   quntity { get; set; }

        public decimal?  price { get; set; }
        public int? oder { get; set; }
    }
}
