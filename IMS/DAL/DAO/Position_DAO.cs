using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL.DTO;

namespace DAL.DAO
{
    public class Position_DAO : HRMSContext
    {
        public static void Add_Position(POSITION position)
        {
            try
            {
                db.POSITIONs.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<Position_DTO> Get_Position()
        {
            try
            {
                var list = (from p in db.POSITIONs
                            join d in db.DEPARTMENTs on p.D_ID equals d.ID
                            select new
                            {
                                positionID = p.P_ID,
                                Position_Name = p.POSITION_NAME,
                                Department_Name = d.DEP_NAME,
                                Department_ID = p.D_ID
                            });//.OrderBy(x => x.positionID).ToList();

                List<Position_DTO> Position_List = new List<Position_DTO>();
                foreach (var item in list)
                {
                    Position_DTO dto = new Position_DTO();
                    dto.P_ID = item.positionID;
                    dto.POSITION_NAME = item.Position_Name;
                    dto.Department_Name = item.Department_Name;
                    dto.D_ID = item.Department_ID;

                    Position_List.Add(dto);
                }
                return Position_List;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<POSITION> Get_Position_cmb()
        {
            return db.POSITIONs.ToList();
        }

        public static void Delete_Position(int v)
        {
            POSITION position = db.POSITIONs.First(x => x.P_ID == v);
            db.POSITIONs.DeleteOnSubmit(position);
            db.SubmitChanges();

        }

        public static void Update_Position(POSITION position)
        {
            try
            {
                POSITION pst = db.POSITIONs.First(x => x.P_ID == position.P_ID);
                pst.POSITION_NAME = position.POSITION_NAME;
                pst.D_ID = position.D_ID;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
