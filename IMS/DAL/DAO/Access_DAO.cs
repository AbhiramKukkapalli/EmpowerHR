using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class Access_DAO:HRMSContext
    {
        public static List<ACCESS> Get_Pass_Acc(int v, int menu)
        {

            List<ACCESS> list = db.ACCESSes.Where(x => x.EMP_ID == v && x.MENU_A == menu  ).ToList();
            return list;
        }

        public static void Add_Access(ACCESS acc)
        {
            try
            {
                db.ACCESSes.InsertOnSubmit(acc);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PASS> Get_User_Name()
        {
            return db.PASSes.ToList();
        }

        public static List<ACCESS> Get_Pass_Admin(int v, int menu, int menu2)
        {
            List<ACCESS> list = db.ACCESSes.Where(x => x.EMP_ID == v && x.MENU_A == menu && x.MENU_B == menu2).ToList();
            return list;
        }

        public static void Delete_Access(int v, int v2, int v3, int v4)
        {
            var acc = (from a in db.ACCESSes where a.EMP_ID == v && a.MENU_A == v2 && a.MENU_B == v3 && a.MENU_C == v4 select a).FirstOrDefault();
            db.ACCESSes.DeleteOnSubmit(acc);
            db.SubmitChanges();
        }

        public static void Update_Admin_Or_User(ACCESS acc_Update_GET)
        {
            try
            {
                ACCESS acc_update = db.ACCESSes.First(x => x.EMP_ID == acc_Update_GET.EMP_ID && x.MENU_A == acc_Update_GET.MENU_A && x.MENU_B == acc_Update_GET.MENU_B && x.MENU_C == acc_Update_GET.MENU_C);
                acc_update.MENU_D = acc_Update_GET.MENU_D;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        

        public static List<ACCESS> Get_Admin_Or_User(int v1, int v2, int v3, int v4, int v5)
        {
            List<ACCESS> list = db.ACCESSes.Where(x => x.EMP_ID == v1 && x.MENU_A == v2 && x.MENU_B == v3 && x.MENU_C == v4 && x.MENU_D == v5).ToList();
            return list;
        }

        public static void Add_Admin(ACCESS acc)
        {
            try
            {
                db.ACCESSes.InsertOnSubmit(acc);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Access_Delete(int v, int v1, int menu_b, int menu_c, int menu_d)
        {
            var acc = (from a in db.ACCESSes where a.EMP_ID == v && a.MENU_A == v1 && a.MENU_B == menu_b && a.MENU_C == menu_c && a.MENU_D == menu_d select a).First();
            db.ACCESSes.DeleteOnSubmit(acc);
            db.SubmitChanges();
        }

        
    }
}
