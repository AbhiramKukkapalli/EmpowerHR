using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class Employee_DAO : HRMSContext
    {
        public static List<BLOOD_GROUP> Get_Blood_Group()
        {
            return db.BLOOD_GROUPs.ToList();
        }

        public static List<GENDER> Gender_Get()
        {
            return db.GENDERs.ToList();
        }

        public static List<LANGUAGE> Language_Get()
        {
            return db.LANGUAGEs.ToList();
        }

        public static List<STATUS> Status_Get()
        {
            return db.STATUS.ToList();
        }

        public static void Add_Emp_Data(EMP_INFO emp_info)
        {
            try
            {
                db.EMP_INFOs.InsertOnSubmit(emp_info);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Employee_Detail_DTO> Get_Employee_List()
        {
            List<Employee_Detail_DTO> Emp_List = new List<Employee_Detail_DTO>();

            var list = (from emp in db.EMP_INFOs
                        join bg in db.BLOOD_GROUPs on emp.BLOOD_ID equals bg.B_ID
                        join gen in db.GENDERs on emp.GENDER equals gen.G_ID
                        join Lan in db.LANGUAGEs on emp.LANGUAGE equals Lan.L_ID
                        join sts in db.STATUS on emp.STATUS equals sts.ID
                        select new
                        {
                            Emp_ID = emp.EMP_ID,
                            Frist_Name = emp.FRIST_NAME,
                            Sure_Name = emp.NAME_SURENAME,
                            DOB = emp.DOB,
                            Mobile = emp.MOBILE,
                            NIC = emp.NIC,
                            Email = emp.EMAIL,
                            blood_Name = bg.BLOOD_NAME,
                            Address = emp.ADDRESS,
                            Gender = gen.GENDER1,
                            LAnguage = Lan.LANGUAGE1,
                            status = sts.STATUS1

                        }).OrderBy(x => x.Emp_ID).ToList();
            foreach (var item in list)
            {
                Employee_Detail_DTO dto = new Employee_Detail_DTO();
                dto.Emp_ID = item.Emp_ID;
                dto.Frist_Name = item.Frist_Name;
                dto.Sure_Name = item.Sure_Name;
                dto.DOB = item.DOB;
                dto.Mobile = item.Mobile;
                dto.NIC = item.NIC;
                dto.Email = item.Email;
                dto.Blood_Name = item.blood_Name;
                dto.Address = item.Address;
                dto.Gender = item.Gender;
                dto.Language = item.LAnguage;
                dto.Sataus = item.status;
                Emp_List.Add(dto);

            }
            return Emp_List;

        }
    }
}
