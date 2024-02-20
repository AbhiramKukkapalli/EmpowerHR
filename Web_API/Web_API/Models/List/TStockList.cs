using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models.List
{
    public class TStockList
    {
       public List<TStock> TStock_List { get; set; }

       
    }
    public class Tshart_Name_Size
    {
        
        public List<TName> T_Name_List { get; set; }
        public List<TSize> T_Size_List { get; set; }
    }

    public class TName
    {
        public int T_Name_ID { get; set; }
        public string T_Name { get; set; }
    }
    public class TSize
    {
        public int T_Size_ID { get; set; }
        public string T_Size_Name { get; set; }
    }
    public class TStock
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int?  Quantity { get; set; }
        public decimal? Price { get; set; }
    }


}
