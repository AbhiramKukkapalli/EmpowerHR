using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;
using System.Security.Cryptography;

namespace BLL
{
    public class Login_BLL
    {
        public static Login_DTO Get_Data_cmb()
        {
            Login_DTO login_dto = new Login_DTO();
            login_dto.Branch = Login_DAO.Get_Data_cmb();
            login_dto.Emp_Info = Login_DAO.Get_Employee();

            return login_dto;
        }

        public static void add_user_login(PASS pass)
        {
            Login_DAO.Add_user_login(pass);
        }

        public static List<PASS> Get_Pass(int v, string text)
        {
            return Login_DAO.Get_Pass(v, text);
        }

        public static void Change_Passowrd(PASS pass)
        {
            Login_DAO.Change_Pass(pass);
        }

        public static List<EMP_INFO> Get_gender(int v1, int v2)
        {
            return Login_DAO.Get_Gender(v1, v2);
        }

        public static List<PASS> Get_Login_Out(int v1, int v2)
        {
            return Login_DAO.Get_Login_Out(v1, v2);
        }

        public static void Update_Login_Out(PASS log_out)
        {
            Login_DAO.Update_login_out(log_out);
        }
    }
}
