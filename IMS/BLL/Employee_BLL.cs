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
    public class Employee_BLL
    {
        public static Employee_DTO Get_All_cmb()
        {
            Employee_DTO Emp_DTO = new Employee_DTO();
            Emp_DTO.Blood_Group_Get = Employee_DAO.Get_Blood_Group();
            Emp_DTO.Gender_Get = Employee_DAO.Gender_Get();
            Emp_DTO.Language_Get = Employee_DAO.Language_Get();
            Emp_DTO.Status = Employee_DAO.Status_Get();



            Emp_DTO.Employee_Detail = Employee_DAO.Get_Employee_List();
            return Emp_DTO;
        }

        public static void Add_Emp_Data(EMP_INFO emp_info)
        {
            Employee_DAO.Add_Emp_Data(emp_info);
        }

        //public static object Get_Employee_List()
        //{
        //    return Employee_DAO.Get_Employee_List();
        //}
        //public static List<BLOOD_GROUP> Get_Blood_Group()
        //{
        //    return Employee_DAO.Get_Blood_Group();
        //}
    }
}
