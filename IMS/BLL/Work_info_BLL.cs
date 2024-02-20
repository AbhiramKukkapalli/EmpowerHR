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
    public class Work_info_BLL
    {
        public static List<WORK_TYPE> Get_Work_Type()
        {
            return Work_info_DAO.Get_Work_Type();
        }

        public static List<BRANCH> Get_Branch()
        {
            return Work_info_DAO.Get_Branch();
        }

        public static void Add_Emp_Work_Detail(EMP_WORK_INFO emp_work)
        {
            Work_info_DAO.Add_Emp_Work_Detail(emp_work);
        }

        public static Work_info_DTO Get_Report_Emp()
        {
            Work_info_DTO work_emp = new Work_info_DTO();
            
            work_emp.Report_Emp_Detail = Work_info_DAO.Get_Report_Emp();
            return work_emp;
        }

        public static Work_info_DTO Get_Notice(int v, int v1, int v2)
        {
            Work_info_DTO Notice = new Work_info_DTO();
            Notice.Notice = Work_info_DAO.Get_Notice(v,v1,v2);
            return Notice;
        }

        public static void Add_TO_Do_List(EMP_TO_DO_LIST todoList)
        {
            Work_info_DAO.Add_To_Do_List(todoList);
        }

        public static Work_info_DTO Get_Work_Emp()
        {
            Work_info_DTO work_emp = new Work_info_DTO();
            work_emp.Work_emp_Detail = Work_info_DAO.Get_Work_Emp();
           // work_emp.Report_Emp_Detail = Work_info_DAO.Get_Report_Emp();
            return work_emp;
        }

        public static Work_info_DTO get_to_do_list(int v, int waiting)
        {
            Work_info_DTO To_Do_List = new Work_info_DTO();
            To_Do_List.To_Do_Lists = Work_info_DAO.Get_To_DO_List(v, waiting);
            // work_emp.Report_Emp_Detail = Work_info_DAO.Get_Report_Emp();
            return To_Do_List;
        }

        public static List<NFC_NAME_VIEW> Get_Attend_User_Name(string v)
        {
            return  Work_info_DAO.Get_Attend_User_Name(v);
        }

        public static Work_info_DTO get_complite_to_do_list(int v, int complite)
        {
            Work_info_DTO To_Do_List = new Work_info_DTO();
            To_Do_List.complet_To_Do_List = Work_info_DAO.get_complite_to_do_lis(v, complite);
            // work_emp.Report_Emp_Detail = Work_info_DAO.Get_Report_Emp();
            return To_Do_List;
        }

        public static void Add_Attendance(ATTENDANCE attendance)
        {
            Work_info_DAO.Add_Attendance(attendance);
        }

        public static Work_info_DTO get_Noncomplite_to_do_list(int v, int non_Complite)
        {
            Work_info_DTO To_Do_List = new Work_info_DTO();
            To_Do_List.Non_complet_To_Do_List = Work_info_DAO.get_Noncomplite_to_do_lis(v, non_Complite);
            // work_emp.Report_Emp_Detail = Work_info_DAO.Get_Report_Emp();
            return To_Do_List;
        }

        public static List<NOTICE> notice_body_get(int v)
        {
            return Work_info_DAO.Get_notice_body(v);
        }

        public static List<NOTICE> Check_departmeny_notice(int v1, int v2)
        {
            return Work_info_DAO.Check_Department(v1, v2);
        }

        public static void OUT_Time_Attendance(ATTENDANCE set_Out_Time)
        {
            Work_info_DAO.OUT_Time_Attendance(set_Out_Time);
        }

        public static void Add_Notice(NOTICE notice_Add)
        {
            Work_info_DAO.add_new_notice(notice_Add);
        }

        public static List<ATTENDANCE> Atte_IN_OUT_Check(int v, DateTime today)
        {
            return Work_info_DAO.Atte_IN_OUT_Check(v, today);
        }

        public static List<EMP_WORK_INFO> Check_NFC(string v)
        {
            return Work_info_DAO.Chek_NFC(v);
        }

        public static List<EMP_WORK_INFO> Check_ID_IN(int v)
        {
            return Work_info_DAO.Check_ID_IN(v);
        }

        public static List<EMP_WORK_INFO> Get_de_branch_po(int v)
        {
            return Work_info_DAO.Get_de_branch_po(v);
        }

       
        public static void Update_Non_Complite(EMP_TO_DO_LIST todoList)
        {
            Work_info_DAO.Update_Non_Complite(todoList);
        }

        public static void Delete_todolist(int v)
        {
            Work_info_DAO.Delete_todolist(v);
        }
    }
}
