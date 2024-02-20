using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
   public class Login_DTO
    {
        public List<BRANCH> Branch { get; set; }
        public List<EMP_INFO> Emp_Info { get; set; }

        public static void Update_login_out(PASS log_out)
        {
            
        }
    }
}
