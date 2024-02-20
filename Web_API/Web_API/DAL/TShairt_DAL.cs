using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.DAL
{
    public class TShairt_DAL
    {
        public static List<TStock> GetStock()
        {
            HRMContext db = new HRMContext();
            List<TStock> t_stock_detail = new List<TStock>();
            var list = from stock in db.TShirtStock
                        join t_name in db.TShirtName on stock.TSNId equals t_name.Id
                        join t_size in db.TShirtSize on stock.TSSizeId equals t_size.SizeId
                        select new
                        {
                            t_name = t_name.TName,
                            t_size = t_size.SizeName,
                            t_quntity = stock.TStockQuantity,
                            t_price = t_name.Price
                        };
            foreach (var item in list)
            {
                TStock dto = new TStock();
                dto.Name = item.t_name;
                dto.Size = item.t_size;
                dto.Quantity = item.t_quntity;
                dto.Price = item.t_price;
                t_stock_detail.Add(dto);
            }
            return t_stock_detail;
        }

        internal static bool Set_Data(SaleTShirt set)
        {
            try
            {
                HRMContext db = new HRMContext();
                db.SaleTShirt.Add(set);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static List<TStock> My_Oder(int v1, int v2)
        {
            HRMContext db = new HRMContext();
            List<TStock> My_Oder = new List<TStock>();
            var list = (from oder in db.SaleTShirt where oder.EmpId == v1 && oder.States ==v2 
                        join t_Name in db.TShirtName on oder.TSNId equals t_Name.Id
                        join t_size in db.TShirtSize on oder.TSSizeId equals t_size.SizeId
                        select new
                        {
                            t_name = t_Name.TName,
                            t_size = t_size.SizeName,
                            t_quntity = oder.Quantity,
                            t_price = t_Name.Price
                        });
            foreach (var item in list)
            {
                TStock dto = new TStock();
                dto.Name = item.t_name;
                dto.Size = item.t_size;
                dto.Quantity = item.t_quntity;
                dto.Price = item.t_price;
                My_Oder.Add(dto);
            }
            return My_Oder;
        }

        internal static List<TSize> Get_TSize()
        {
            HRMContext db = new HRMContext();

            List<TSize> T_Size_List = new List<TSize>();

            var list = from TSize in db.TShirtSize
                       select new
                       {
                           t_id = TSize.SizeId,
                           t_Size = TSize.SizeName
                       };
            foreach (var item in list)
            {
                TSize dto = new TSize();
                dto.T_Size_ID = item.t_id;
                dto.T_Size_Name = item.t_Size;
                T_Size_List.Add(dto);

            }
            return T_Size_List;
        }

        public static List<TName> Get_TName()
        {
            HRMContext db = new HRMContext();
            List<TName> T_Name_List = new List<TName>();

            var list = from TName in db.TShirtName
                       select new
                       {
                           t_id = TName.Id,
                           t_name = TName.TName
                       };
            foreach (var item in list)
            {
                TName dto = new TName();
                dto.T_Name_ID = item.t_id;
                dto.T_Name = item.t_name;
                T_Name_List.Add(dto);

            }
            return T_Name_List;
        }
    }
}
