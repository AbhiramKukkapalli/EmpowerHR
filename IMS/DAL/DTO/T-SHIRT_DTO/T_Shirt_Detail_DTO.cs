using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.T_SHIRT_DTO
{
   public class T_Shirt_Detail_DTO
    {
        public string t_shirt_name { get; set; }
        public string t_shirt_size { get; set; }
        public double? T_shirt_q { get; set; }

        public decimal? T_Price { get; set; }

        public decimal? All_T_Price { get; set; }
        public int T_S_N_ID { get; set; }
    }
}
