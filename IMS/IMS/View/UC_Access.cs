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
    public partial class UC_Access : UserControl
    {
        public UC_Access()
        {
            InitializeComponent();
        }
        List<EMP_INFO> Emp_Info = new List<EMP_INFO>();
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {


            int Emp_ID = Convert.ToInt32(cmb_emp.SelectedValue);


            User_Static.Use_ID = Convert.ToInt32(cmb_emp.SelectedValue);

            int Menu_A = 1;
            int Menu_B = 1;
            int Menu_c_1 = 1;
            int Menu_D = 1; //  user


            List<ACCESS> emp = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(cmb_emp.SelectedValue), Convert.ToInt32(Menu_A), Convert.ToInt32(Menu_B), Convert.ToInt32(Menu_c_1), Convert.ToInt32(Menu_D));
            if (emp.Count == 0)
            {

                List<ACCESS> emp_1 = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(cmb_emp.SelectedValue), Convert.ToInt32(Menu_A), Convert.ToInt32(Menu_B), Convert.ToInt32(Menu_c_1), Convert.ToInt32(Menu_D));
                if(emp_1.Count == 0)
                {
                    Detail_Access_DTO.MENU_A = Menu_A;
                    Detail_Access_DTO.MENU_B = Menu_B;
                    Detail_Access_DTO.MENU_C = Menu_c_1;
                    Detail_Access_DTO.MENU_D = Menu_D;
                    frmMessage frm = new frmMessage();
                    frm.btn_admin.Enabled = false;
                    frm.btn_remove.Enabled = false;

                    frm.Show();
                }
                else
                {
                    Detail_Access_DTO.MENU_A = Menu_A;
                    Detail_Access_DTO.MENU_B = Menu_B;
                    Detail_Access_DTO.MENU_C = Menu_c_1;
                    Detail_Access_DTO.MENU_D = Menu_D;
                    frmMessage frm = new frmMessage();
                    frm.btn_admin.Enabled = false;
                 

                    frm.Show();
                }


               



            }

            else
            {



                int Menu_D_Admin = 2;
                Detail_Access_DTO.MENU_A = Menu_A;
                Detail_Access_DTO.MENU_B = Menu_B;
                Detail_Access_DTO.MENU_C = Menu_c_1;
                Detail_Access_DTO.MENU_D = Menu_D_Admin;

                frmMessage frm = new frmMessage();
                frm.btn_user.Enabled = false;
                
                frm.Show();


            }





        }
        List<PASS> Pass_Access = new List<PASS>();
        Login_DTO login_dto = new Login_DTO();
        private void UC_Access_Load(object sender, EventArgs e)
        {
            Pass_Access = Access_BLL.Get_User_Name();


            cmb_emp.DataSource = Pass_Access;
            cmb_emp.DisplayMember = "USER_NAME";
            cmb_emp.ValueMember = "EMP_ID";
            cmb_emp.SelectedIndex = -1;

            User_Static.Use_ID = Convert.ToInt32(cmb_emp.SelectedValue);


        }

        public void insert_emp(int menu_a)
        {

            DialogResult result = MessageBox.Show("Are you sure access give", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (cmb_emp.Text.Trim() == "")
                    MessageBox.Show("Pleas Enter The Position");
                else
                {


                    ACCESS Acc = new ACCESS();
                    Acc.EMP_ID = Convert.ToInt32(cmb_emp.SelectedValue);
                    Acc.MENU_A = menu_a;

                    Access_BLL.Access_add(Acc);
                    MessageBox.Show("Add Position Success");


                }
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int Emp_ID = Convert.ToInt32(cmb_emp.SelectedValue);


            User_Static.Use_ID = Convert.ToInt32(cmb_emp.SelectedValue);

            int Menu_A = 1;
            int Menu_B = 1;
            int Menu_c = 2;
            int Menu_D = 1; //  user


            List<ACCESS> emp_axxess = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(cmb_emp.SelectedValue), Convert.ToInt32(Menu_A), Convert.ToInt32(Menu_B), Convert.ToInt32(Menu_c), Convert.ToInt32(Menu_D));
            if (emp_axxess.Count == 0)
            {




                Detail_Access_DTO.MENU_A = Menu_A;
                Detail_Access_DTO.MENU_B = Menu_B;
                Detail_Access_DTO.MENU_C = Menu_c;
                Detail_Access_DTO.MENU_D = Menu_D;


                frmMessage frm = new frmMessage();
                frm.btn_admin.Enabled = false;
                frm.Show();



            }

            else
            {




                int Menu_D_Admin = 2;
                Detail_Access_DTO.MENU_A = Menu_A;
                Detail_Access_DTO.MENU_B = Menu_B;
                Detail_Access_DTO.MENU_C = Menu_c;
                Detail_Access_DTO.MENU_D = Menu_D_Admin;

                frmMessage frm = new frmMessage();
                frm.btn_user.Enabled = false;
                frm.Show();


            }





        }

        private void cmb_emp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void filleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
