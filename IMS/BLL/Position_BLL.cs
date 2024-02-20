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
    public class Position_BLL
    {
        public static void Add_Position(POSITION position)
        {
            Position_DAO.Add_Position(position);
        }

        public static List<Position_DTO> Get_Position()
        {
            return Position_DAO.Get_Position();
        }

        public static void Update_Position(POSITION position)
        {
             Position_DAO.Update_Position(position);
        }

        public static void Delete_Position(int v)
        {
            Position_DAO.Delete_Position(v);
        }

        public static List<POSITION> Get_Position_cmb()
        {
            return Position_DAO.Get_Position_cmb();
        }
    }
}
