using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class Login_DAO : HRMSContext
    {
        public static List<BRANCH> Get_Data_cmb()
        {
            return db.BRANCHes.ToList();
        }

        public static List<EMP_INFO> Get_Employee()
        {
            return db.EMP_INFOs.ToList();
        }

        public static void Add_user_login(PASS pass)
        {
            try
            {
                db.PASSes.InsertOnSubmit(pass);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PASS> Get_Pass(int v, string text)
        {
            List<PASS> list = db.PASSes.Where(x => x.EMP_ID == v && x.PASS1 == text).ToList();
            return list;
        }

        public static void Change_Pass(PASS pass)
        {
            PASS pass1 = db.PASSes.First(x => x.EMP_ID == pass.EMP_ID);
            pass1.PASS1 = pass.PASS1;
            db.SubmitChanges();
        }

        public static List<PASS> Get_Login_Out(int v1, int v2)
        {
            List<PASS> list = db.PASSes.Where(x => x.EMP_ID == v1 && x.LOG_IN_OUT == v2).ToList();
            return list;
        }

        public static void Update_login_out(PASS log_out)
        {
            try
            {
                PASS lt = db.PASSes.First(x => x.EMP_ID == log_out.EMP_ID);
                lt.LOG_IN_OUT = log_out.LOG_IN_OUT;
                lt.LAST_L_DATE_TIME = log_out.LAST_L_DATE_TIME;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EMP_INFO> Get_Gender(int v1, int v2)
        {
            List<EMP_INFO> list = db.EMP_INFOs.Where(x => x.EMP_ID == v1 && x.GENDER == v2).ToList();
            return list;
        }
    }
}
