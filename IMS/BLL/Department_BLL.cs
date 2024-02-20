using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;


namespace BLL
{
    public class Department_BLL
    {
        public static void AddDepartment(DEPARTMENT department)
        {
            Department_DAO.Add_Department(department);
        }

        public static Department_DTO GetAll()
        {
            Department_DTO dto = new Department_DTO();
            dto.Department = Department_DAO.Get_ALL_Department();
            return dto;
        }
        public static List<DEPARTMENT> Get_Department()

        {
            return Department_DAO.Get_Department();
        }

        public static void Update_Department(DEPARTMENT department)
        {
            Department_DAO.Update_Department(department);
        }

        public static void Delete_Department(int v)
        {
            Department_DAO.Delete_Department(v);
        }
    }
}
