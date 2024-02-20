using BLL.T_SHIRT_BLL;
using DAL.DTO.T_SHIRT_DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.C_R_Report
{
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
        }
        T_Shirt_DTO dto = new T_Shirt_DTO();
        private void UC_Report_Load(object sender, EventArgs e)
        {
            //ArrayList authorsArray = new ArrayList();
            //authorsArray.Add("Mahesh Chand");
            //authorsArray.Add("Praveen Kumar");
            //authorsArray.Add("Raj Kumar");
            //authorsArray.Add("Dinesh Beniwal");
            //authorsArray.Add("David McCarter");

            //T_Sale_Report t_r = new T_Sale_Report();
            //dto = T_Shirt_BLL.Get_t_name_size();
            //t_r.SetDataSource(authorsArray);
            //crystalReportViewer1.ReportSource = t_r;
        }
    }
}
