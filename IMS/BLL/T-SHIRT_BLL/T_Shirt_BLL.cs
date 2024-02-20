using DAL.DTO.T_SHIRT_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;
using DAL.DAO.T_SHIRT_DAO;

namespace BLL.T_SHIRT_BLL
{
    public class T_Shirt_BLL
    {
        public static T_Shirt_DTO Get_t_name_size()
        {
            T_Shirt_DTO dto = new T_Shirt_DTO();
            dto.t_Name = T_Shirt_DAO.Get_t_name();
            dto.t_Size = T_Shirt_DAO.Get_t_Size();
            dto.t_stock = T_Shirt_DAO.Get_Stock();
            dto.t_oder = T_Shirt_DAO.T_Oder();

            return dto;
        }

        public static List<T_SHIRT_STOCK> Check_Stock(int v1, int v2)
        {
            return T_Shirt_DAO.Check_Stock(v1, v2);
        }

        public static T_Shirt_DTO My_Oder(int v1, int v2)
        {
            T_Shirt_DTO My_Oder = new T_Shirt_DTO();
            My_Oder.t_oder = T_Shirt_DAO.My_Oder(v1, v2);
            return My_Oder;
        }

        public static void Add_Stock(T_SHIRT_STOCK stock)
        {
            T_Shirt_DAO.Add_Stock(stock);
        }

        public static void Update_Stock(T_SHIRT_STOCK update_stock)
        {
            T_Shirt_DAO.update_Stock(update_stock);
        }

       

        public static void Add_Name_Price(T_SHIRT_NAME name)
        {
            T_Shirt_DAO.Add_Name_Price(name);
        }

        public static void Get_t_shirt(SALE_T_SHIRT get_t)
        {
            T_Shirt_DAO.Get_T_Shirt(get_t);
        }

        public static List<T_SHIRT_STOCK> Get_Stock_ID(int v1, int v2)
        {
            return T_Shirt_DAO.Get_Stock_ID(v1, v2);
        }

        public static List<T_SHIRT_STOCK> Check_Stock(int v)
        {
            return T_Shirt_DAO.Check_Stock_quntity(v);
        }

        public static void Update_Stock_quntity(T_SHIRT_STOCK update_stock)
        {
            T_Shirt_DAO.Update_Stock_quntity(update_stock);
        }

        public static void Update_States(SALE_T_SHIRT update_complete)
        {
            T_Shirt_DAO.Update_State(update_complete);
        }

        public static T_Shirt_DTO Pending_Oders(int v)
        {
            T_Shirt_DTO Pending_Oders = new T_Shirt_DTO();
            Pending_Oders.t_oder = T_Shirt_DAO.Pending_Oders(v);
            return Pending_Oders;
        }
    }
}
