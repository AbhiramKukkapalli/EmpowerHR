using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class Access_BLL
    {
        public static List<ACCESS> Get_Pass(int v, int menu)
        {
            return Access_DAO.Get_Pass_Acc(v, menu);
        }

        public static void Access_add(ACCESS acc)
        {
            Access_DAO.Add_Access(acc);
        }

        public static void Access_Delete(int v, int v1, int menu_b, int menu_c, int menu_d)
        {
            Access_DAO.Access_Delete(v,v1,menu_b,menu_c,menu_d);
        }

        public static List<PASS> Get_User_Name()
        {
            return Access_DAO.Get_User_Name();
        }

        public static List<ACCESS> Get_Pass_admin(int v, int menu, int menu2)
        {
            return Access_DAO.Get_Pass_Admin(v, menu,menu2);
        }

        public static void Add_Admin(ACCESS acc)
        {
            Access_DAO.Add_Admin(acc);
        }

      
        public static List<ACCESS> Get_Admin_Or_User(int v1, int v2, int v3, int v4, int v5)
        {
            return Access_DAO.Get_Admin_Or_User(v1, v2, v3, v4, v5);
        }

        public static void Update_Admin_Or_User(ACCESS acc_Update)
        {
            Access_DAO.Update_Admin_Or_User(acc_Update);
        }

        public static void Delete_Access(int v1, int v2, int v3, int v4)
        {
            Access_DAO.Delete_Access(v1, v2, v3, v4);
        }
    }
}
