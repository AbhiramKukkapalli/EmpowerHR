using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO.T_SHIRT_DTO
{
  public  class T_Shirt_DTO
    {
        public List<T_SHIRT_NAME> t_Name { get; set; }
        public List<T_SHIRT_SIZE> t_Size { get; set; }

        public List<T_Shirt_Detail_DTO> t_stock { get; set; }

        public List <T_Shirt_Oder_Ditail_DTO> t_oder { get; set; }
        
        public List<Stock_ID_DTO> S_ID { get; set; }


    }
    public class Get_Quantity_DTO
    {
        public static double? Quantity { get; set; }

        
    }
}
