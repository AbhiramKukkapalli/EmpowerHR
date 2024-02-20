using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.DAL;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.BLL
{
    public class TShairt_BLL
    {
        internal static TStockList GetStock()
        {
            TStockList dto = new TStockList();
            dto.TStock_List = TShairt_DAL.GetStock();
            return dto;

            
        }

        internal static Tshart_Name_Size Get_T_Name()
        {
            Tshart_Name_Size dto = new Tshart_Name_Size();
            dto.T_Name_List = TShairt_DAL.Get_TName();
            return dto;
        }

        internal static Tshart_Name_Size Get_T_Size()
        {
            Tshart_Name_Size dto = new Tshart_Name_Size();
            dto.T_Size_List = TShairt_DAL.Get_TSize();
            return dto;
        }

        internal static TStockList My_Oders(int v1, int v2)
        {
            TStockList dto = new TStockList();
            dto.TStock_List = TShairt_DAL.My_Oder(v1, v2);
            return dto;
        }

        internal static void Set_data(SaleTShirt set)
        {
            TShairt_DAL.Set_Data(set);
        }
    }
}
