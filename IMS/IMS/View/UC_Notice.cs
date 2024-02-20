using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;

namespace IMS.View
{
    public partial class UC_Notice : UserControl
    {
        public UC_Notice()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        List<DEPARTMENT> Department_List = new List<DEPARTMENT>();
        List<POSITION> Position_List = new List<POSITION>();
        private void btn_add_Click(object sender, EventArgs e)
        {
            NOTICE notice_Add = new NOTICE();
            notice_Add.D_ID = Convert.ToInt32(cmbDepartment.SelectedValue);
            notice_Add.P_ID = Convert.ToInt32(cmb_position.SelectedValue);
            notice_Add.EMP_ID = Convert.ToInt32(Select_Emp_Detail.Select_Emp_ID);
            notice_Add.FROM = dpfrom.Value;
            notice_Add.TO_DATE = dp_to.Value;
            notice_Add.N_TITEL = txtntitel.Text;
            notice_Add.N_BODY = txt_body.Text;
            notice_Add.N_PUT_ID = Convert.ToInt32(User_Static.Emp_ID);
            notice_Add.PUT_P_ID = Convert.ToInt32(User_Static.emp_position);
            Work_info_BLL.Add_Notice(notice_Add);
            MessageBox.Show("add new notice");
        }

        private void UC_Notice_Load(object sender, EventArgs e)
        {
            Department_List = Department_BLL.Get_Department();
            cmbDepartment.DataSource = Department_List;
            cmbDepartment.DisplayMember = "DEP_NAME";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;

            Position_List = Position_BLL.Get_Position_cmb();
            cmb_position.DataSource = Position_List;
            cmb_position.DisplayMember = "POSITION_NAME";
            cmb_position.ValueMember = "P_ID";
          cmb_position.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelect frm = new frmSelect();
            frm.Show();
        }

        private void txt_emp_name_Click(object sender, EventArgs e)
        {
            txt_emp_name.Text = Select_Emp_Detail.Select_Emp_Name;
        }
    }
}
