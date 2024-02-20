using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class Department_DAO : HRMSContext
    {
        public static void Add_Department(DEPARTMENT department)
        {
            try
            {
                db.DEPARTMENTs.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
                
            }

        }

        public static List<Department_Detail_DTO> Get_ALL_Department()
        {
            List<Department_Detail_DTO> Dep_List = new List<Department_Detail_DTO>();
            var list = (from dep in db.DEPARTMENTs
                        select new
                        {
                            dep_id = dep.ID ,
                            dep_name = dep.DEP_NAME
                        }


                );
            foreach (var item in list)
            {
                Department_Detail_DTO dto = new Department_Detail_DTO();
                dto.dep_id = item.dep_id;
                dto.dep_name = item.dep_name;
                Dep_List.Add(dto);
            }
            return Dep_List;

        }

        public static int Get_Acc()
        {
            throw new NotImplementedException();
        }

        public static void Delete_Department(int v)
        {
            DEPARTMENT department = db.DEPARTMENTs.First(x => x.ID == v);
            db.DEPARTMENTs.DeleteOnSubmit(department);
            db.SubmitChanges();
        }

        public static void Update_Department(DEPARTMENT department)
        {
            DEPARTMENT Dpt = db.DEPARTMENTs.First(x => x.ID == department.ID);
            Dpt.DEP_NAME = department.DEP_NAME;
            db.SubmitChanges();
        }

        public static List<DEPARTMENT> Get_Department()
        {
            return db.DEPARTMENTs.ToList();
        }
    }
}
