using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.DAL;
using Web_API.Models;
using Web_API.Models.List;

namespace Web_API.BLL
{
    public class User_BLL
    {
        internal static NoticeListView Get_Notice(int v1, int v2, int v3)
        {
            NoticeListView notice = new NoticeListView();
            notice.Notice = User_DAL.Get_Notice(v1,v2,v3);
            return notice;
        }

        internal static void Update_User_Logout(Pass logout)
        {
            User_DAL.Update_User_Logout(logout);
        }

        internal static User_Info_List User_Detail_Get(int userID)
        {
            User_Info_List dto = new User_Info_List();
            dto.uInfoList = User_DAL.User_Detail_Get(userID);
            return dto;
        }

        internal static User_Info_List Work_Detail_Get(int? empId)
        {
            User_Info_List dto = new User_Info_List();
            dto.work_Info = User_DAL.user_work_detail_get(empId);
            return dto;

        }

        internal static void Change_Password(Pass changePass)
        {
            User_DAL.changePassword(changePass);
        }

        internal static ToDoListView Get_Emp_TodoList(int userID, int wating)
        {
            ToDoListView todolist = new ToDoListView();
            todolist.EmpToDoList = User_DAL.Get_Emp_Todolist(userID,wating);
            return todolist;
        }

        internal static void Add_ToDoList(EmpToDoList add)
        {
            User_DAL.addToDoList(add);
        }
    }
}
