using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class Work_info_DAO : HRMSContext
    {


        public static List<WORK_TYPE> Get_Work_Type()
        {
            return db.WORK_TYPEs.ToList();
        }

        public static List<BRANCH> Get_Branch()
        {
            return db.BRANCHes.ToList();
        }

        public static void Add_Emp_Work_Detail(EMP_WORK_INFO emp_work)
        {
            try
            {
                db.EMP_WORK_INFOs.InsertOnSubmit(emp_work);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Work_Emp_Detail_DTO> Get_Work_Emp()
        {
            List<Work_Emp_Detail_DTO> work_emp_list = new List<Work_Emp_Detail_DTO>();
            var list = (from work_info in db.EMP_WORK_INFOs
                        join Emp_Name in db.EMP_INFOs on work_info.EMP_ID equals Emp_Name.EMP_ID
                        join Branch in db.BRANCHes on work_info.B_ID equals Branch.B_ID
                        join Report_To in db.EMP_INFOs on work_info.RE_EMP_ID equals Report_To.EMP_ID

                        join Work_Type in db.WORK_TYPEs on work_info.W_T_ID equals Work_Type.W_ID
                        join Position in db.POSITIONs on work_info.P_ID equals Position.P_ID
                        join Department in db.DEPARTMENTs on work_info.D_ID equals Department.ID

                        select new
                        {
                            emp_name = Emp_Name.NAME_SURENAME,
                            Branch_Name = Branch.BRANCH_NAME,
                            Report_To = Report_To.NAME_SURENAME,
                            Description = work_info.DESCRIPTION,
                            Work_Type = Work_Type.W_NAME,
                            Position = Position.POSITION_NAME,
                            Department = Department.DEP_NAME,

                            D_OF_Appinmont = work_info.D_OF_A,
                            D_OF_Confirm = work_info.D_OF_C,
                            D_OF_Join = work_info.D_OF_JOIN,
                            NFC = work_info.NFC_NUMBER
                        });
            foreach (var item in list)
            {
                Work_Emp_Detail_DTO dto = new Work_Emp_Detail_DTO();
                dto.Emp_Name = item.emp_name;
                dto.Branch_Name = item.Branch_Name;
                dto.Report = item.Report_To;
                dto.Description = item.Description;
                dto.Work_Type = item.Work_Type;
                dto.Position = item.Position;
                dto.Department = item.Department;
                dto.D_Of_Appinment = item.D_OF_Appinmont;
                dto.D_Of_Confirm = item.D_OF_Confirm;
                dto.D_Of_Join = item.D_OF_Join;
                dto.NFC_Code = item.NFC;
                work_emp_list.Add(dto);

            }
            return work_emp_list;
        }

        public static List<Non_complet_To_Do_List> get_Noncomplite_to_do_lis(int v, int non_Complite)
        {
            List<Non_complet_To_Do_List> todolist = new List<Non_complet_To_Do_List>();
            var list = (from todo in db.EMP_TO_DO_LISTs
                        where todo.EMP_ID == v && todo.STATUS == non_Complite
                        join states in db.TO_DO_LIST_STATEs on todo.STATUS equals states.ID
                        select new
                        {
                            id = todo.ID,
                            note = todo.NOTE,
                            startdate = todo.START_DATE,
                            endDate = todo.END_DATE,
                            states = states.TO_LIST_Proccess
                        });
            foreach (var item in list)
            {
                Non_complet_To_Do_List dto = new Non_complet_To_Do_List();
                dto.id = item.id;
                dto.Note = item.note;
                dto.StartDate = item.startdate;
                dto.EndDate = item.endDate;
                dto.States = item.states;
                todolist.Add(dto);
            }
            return todolist;
        }

        

        public static void Delete_todolist(int v)
        {
            EMP_TO_DO_LIST list = db.EMP_TO_DO_LISTs.First(x => x.ID == v);
            db.EMP_TO_DO_LISTs.DeleteOnSubmit(list);
            db.SubmitChanges();
        }

        public static void Update_Non_Complite(EMP_TO_DO_LIST todoList)
        {
            try
            {
                EMP_TO_DO_LIST list = db.EMP_TO_DO_LISTs.First(x => x.ID == todoList.ID);
                list.STATUS = todoList.STATUS;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<complet_To_Do_List> get_complite_to_do_lis(int v, int complite)
        {
            List<complet_To_Do_List> todolist = new List<complet_To_Do_List>();
            var list = (from todo in db.EMP_TO_DO_LISTs
                        where todo.EMP_ID == v && todo.STATUS == complite
                        join states in db.TO_DO_LIST_STATEs on todo.STATUS equals states.ID
                        select new
                        {
                            id = todo.ID,
                            note = todo.NOTE,
                            startdate = todo.START_DATE,
                            endDate = todo.END_DATE,
                            states = states.TO_LIST_Proccess
                        });
            foreach (var item in list)
            {
                complet_To_Do_List dto = new complet_To_Do_List();
                dto.id = item.id;
                dto.Note = item.note;
                dto.StartDate = item.startdate;
                dto.EndDate = item.endDate;
                dto.States = item.states;
                todolist.Add(dto);
            }
            return todolist;
        }

        public static List<To_Do_List> Get_To_DO_List(int v, int waiting)
        {
            List<To_Do_List> todolist = new List<To_Do_List>();
            var list = (from todo in db.EMP_TO_DO_LISTs where todo.EMP_ID == v && todo.STATUS == waiting
                        join states in db.TO_DO_LIST_STATEs on todo.STATUS equals states.ID
                        select new
                        {
                            id = todo.ID,
                            note = todo.NOTE,
                            startdate = todo.START_DATE,
                            endDate= todo.END_DATE,
                            states = states.TO_LIST_Proccess
                        });
            foreach(var item in list)
            {
                To_Do_List dto = new To_Do_List();
                dto.id = item.id;
                dto.Note = item.note;
                dto.StartDate = item.startdate;
                dto.EndDate = item.endDate;
                dto.States = item.states;
                todolist.Add(dto);
            }
            return todolist;
        }

        public static void Add_To_Do_List(EMP_TO_DO_LIST todoList)
        {
            try
            {
                db.EMP_TO_DO_LISTs.InsertOnSubmit(todoList);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<NOTICE> Check_Department(int v1, int v2)
        {
            List<NOTICE> List = db.NOTICEs.Where(x => x.EMP_ID == v2 && x.D_ID == v2).ToList();
            return List;
        }

        public static List<NOTICE> Get_notice_body(int v)
        {
            List<NOTICE> List = db.NOTICEs.Where(x => x.NO_ID == v).ToList();
            return List;
        }

        public static List<Notice_View_DTO> Get_Notice(int v, int v1, int v2)
        {
            List<Notice_View_DTO> Notice_List = new List<Notice_View_DTO>();

            var list = (from N_D in db.NOTICE_VIEWs where N_D.EMP_ID == v || N_D.D_ID == v1 || N_D.P_ID == v2
                        

                        select new 
                        {
                            notice_emp_id = N_D.EMP_ID,
                            notice_d = N_D.D_ID,
                            notice_id = N_D.NO_ID,
                            notice_titel = N_D.N_TITEL,
                            notice_put_name = N_D.NAME_SURENAME,
                            position = N_D.POSITION_NAME,
                        
                            publish_date = N_D.FROM
                          
                        });

            foreach (var item in list)
            {
                Notice_View_DTO dto = new Notice_View_DTO();
                dto.N_ID = item.notice_id;
                dto.N_TITEL = item.notice_titel;
                dto.P_EMP_NAME = item.notice_put_name;
                dto.Position_name = item.position;
               
                dto.N_DATE = item.publish_date;
                Notice_List.Add(dto);
            }
            return Notice_List;
        }

        public static List<EMP_WORK_INFO> Get_de_branch_po(int v)
        {
            List<EMP_WORK_INFO> List = db.EMP_WORK_INFOs.Where(x => x.EMP_ID == v).ToList();


            return List;
        }

        public static void add_new_notice(NOTICE notice_Add)
        {
            try
            {
                db.NOTICEs.InsertOnSubmit(notice_Add);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<EMP_WORK_INFO> Check_ID_IN(int v)
        {
            List<EMP_WORK_INFO> List = db.EMP_WORK_INFOs.Where(x => x.EMP_ID == v).ToList();
            return List;
        }

        public static List<EMP_WORK_INFO> Chek_NFC(string v)
        {
            List<EMP_WORK_INFO> List = db.EMP_WORK_INFOs.Where(x => x.NFC_NUMBER == v).ToList();
            return List;
        }

        public static List<ATTENDANCE> Atte_IN_OUT_Check(int v, DateTime today)
        {
            List<ATTENDANCE> List = db.ATTENDANCEs.Where(x => x.CODE == v && x.DATE == today).ToList();
            return List;
        }



        public static void OUT_Time_Attendance(ATTENDANCE set_Out_Time)
        {
            ATTENDANCE atte = db.ATTENDANCEs.First(x => x.CODE == set_Out_Time.CODE && x.DATE == set_Out_Time.DATE);
            atte.OUT_TIME = set_Out_Time.OUT_TIME;
            db.SubmitChanges();
        }

        public static void Add_Attendance(ATTENDANCE attendance)
        {
            try
            {
                db.ATTENDANCEs.InsertOnSubmit(attendance);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<NFC_NAME_VIEW> Get_Attend_User_Name(string v)
        {
            List<NFC_NAME_VIEW> list = db.NFC_NAME_VIEWs.Where(x => x.NFC_NUMBER == v).ToList();
            return list;
        }

        public static List<Report_Emp_Detail> Get_Report_Emp()
        {
            List<Report_Emp_Detail> report_emp_detail = new List<Report_Emp_Detail>();
            var list = (from work_info in db.EMP_WORK_INFOs
                        join Emp_Name in db.EMP_INFOs on work_info.EMP_ID equals Emp_Name.EMP_ID
                        join Position in db.POSITIONs on work_info.P_ID equals Position.P_ID
                        join Department in db.DEPARTMENTs on work_info.D_ID equals Department.ID
                        select new
                        {
                            emp_id = work_info.EMP_ID,
                            emp_name = Emp_Name.NAME_SURENAME,
                            Position = Position.POSITION_NAME,
                            Department = Department.DEP_NAME


                        });

            foreach (var item in list)
            {
                Report_Emp_Detail dto = new Report_Emp_Detail();
                dto.Emp_ID = item.emp_id;
                dto.Emp_Name = item.emp_name;
                dto.Position = item.Position;
                dto.Department = item.Department;
                report_emp_detail.Add(dto);

            }
            return report_emp_detail;
        }


    }
}
