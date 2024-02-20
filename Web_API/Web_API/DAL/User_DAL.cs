using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.DAL
{

    public class User_DAL 
    {


        

        public static List<NoticeList> Get_Notice(int v, int v1, int v2) // get the user notice department position wise 
        {
            HRMContext db = new HRMContext();
            List<NoticeList> N_View = new List<NoticeList>();
          

            /*filtering data to lode notice view*/
            var Notice = from n in db.NoticeView
                         where n.EmpId == v || n.PId == v1 || n.DId == v2
                         select new
                         {
                             NoticeId = n.NoId,
                             Notice_Titel = n.NTitel,
                             Notice_body = n.NBody
                         }
                          ;

            foreach (var item in Notice)
            {
                NoticeList dto = new NoticeList();
                dto.NoId = item.NoticeId;
                dto.NTitel = item.Notice_Titel;
                dto.NBody = item.Notice_body;
                N_View.Add(dto);

            }
            return N_View;

        }

        internal static bool changePassword(Pass changePass)
        {
            try
            {
                HRMContext db = new HRMContext();

                Pass changePassword = db.Pass.First(x => x.EmpId == changePass.EmpId);
                changePassword.Pass1 = changePass.Pass1;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static bool addToDoList(EmpToDoList add)
        {
            try
            {
                HRMContext db = new HRMContext();
                db.EmpToDoList.Add(add);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static List<EmpToDoList> Get_Emp_Todolist(int userID, int wating)
        {
            HRMContext db = new HRMContext();
            List<EmpToDoList> todolist = new List<EmpToDoList>();
            var list = from emptodo in db.EmpToDoList
                           where emptodo.EmpId == userID && emptodo.Status == wating
                           
                           select new
                           {
                               ID = emptodo.Id,
                               Note = emptodo.Note,
                               StartDate = emptodo.StartDate,
                               EndDate = emptodo.EndDate,
                               
                           };
            foreach (var item in list)
            {
                EmpToDoList dto = new EmpToDoList();
                dto.Id = item.ID;
                dto.Note = item.Note;
                dto.StartDate = item.StartDate;
                dto.EndDate = item.EndDate;
               
                todolist.Add(dto);


            }
            return todolist;
        }

        internal static List<Work_Info> user_work_detail_get(int? empId) //get the work info detail in the system
        {
            HRMContext db = new HRMContext();
            List<Work_Info> workinfo = new List<Work_Info>();
            var list = from Info in db.EmpWorkInfo
                       where Info.EmpId == empId
                       join dep in db.Department on Info.DId equals dep.Id
                       join position in db.Position on Info.PId equals position.PId
                       join workType in db.WorkType on Info.WTId equals workType.WId
                       join branch in db.Branch on Info.BId equals branch.BId
                       join emp in db.EmpInfo on Info.ReEmpId equals emp.EmpId
                       select new
                       {
                           dep = dep.DepName,
                           position = position.PositionName,
                           worktype = workType.WName,
                           branch = branch.BranchName,
                           reportTo = emp.NameSurename,
                           NFC = Info.NfcNumber,
                           JoinDate = Info.DOfJoin

                       };
            foreach (var item in list)
            {
              
                Work_Info dto = new Work_Info();
                dto.Department = item.dep;
                dto.Position = item.position;
                dto.WorkType = item.worktype;
                dto.Branch = item.branch;
                dto.Report_To = item.reportTo;
                dto.NFC = item.NFC;
                dto.JoinDate = item.JoinDate;
                workinfo.Add(dto);

            }
            return workinfo;
        }

        internal static List<User_Info> User_Detail_Get(int userID) // Get the user Infomation in userInfo tabel
        {
            HRMContext db = new HRMContext();
            List<User_Info> userInfo = new List<User_Info>();
            var list = from uInfo in db.EmpInfo where uInfo.EmpId == userID
                       select new
                       {
                           FullName = uInfo.NameSurename,
                           NIC = uInfo.Nic,
                           Address = uInfo.Address,
                           PhoneNum = uInfo.Mobile,
                           Email = uInfo.Email,
                           age = uInfo.Dob
                       };

            
            foreach(var item in list)
            {
                int currentAge = DateTime.Today.Year - item.age.Value.Year; // age calculte
                User_Info info = new User_Info();
                info.fullName = item.FullName;
                info.NIC = item.NIC;
                info.address = item.Address;
                info.phoneNumber = item.PhoneNum;
                info.Email = item.Email;
                info.age = currentAge;
                userInfo.Add(info);
            }
            return userInfo;

        }

        internal static bool Update_User_Logout(Pass logout) // uPdate the user login or logout Pass tabel "0 = In system" "1 = Out Of system "
        {
            try
            {
                HRMContext db = new HRMContext();
                Pass user = db.Pass.First(x => x.EmpId == logout.EmpId);
                user.LogInOut = logout.LogInOut;
                user.LastLDateTime = logout.LastLDateTime;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
