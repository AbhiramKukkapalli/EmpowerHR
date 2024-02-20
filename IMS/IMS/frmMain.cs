using IMS.View;
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
using IMS.View.T_SHIRT_ODER;
using IMS.C_R_Report;
using IMS.View.To_List;

namespace IMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            lblDateTime.Text = DateTime.Now.ToShortDateString();



        }

       public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnl_UC_Control.Controls.Clear();
            pnl_UC_Control.Controls.Add(userControl);
            userControl.BringToFront();
        }

        Work_info_DTO Notice = new Work_info_DTO();


        private void Form1_Load(object sender, EventArgs e)
        {
            int gender = 2;

            // pictureBox2.Visible = false;
            List<EMP_INFO> emp_pass = Login_BLL.Get_gender(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(gender));
            if (emp_pass.Count == 0)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;

            }

            else
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;



            }

            Notice_Count();
            User_Static.Message = "Loding Complite System !";


        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int Menu_A = 1;
            int Menu_B = 1;
            int Menu_c = 1;
            int Menu_D = 2; // Admin or user

            List<ACCESS> emp_axxess = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(Menu_A), Convert.ToInt32(Menu_B), Convert.ToInt32(Menu_c), Convert.ToInt32(Menu_D)); //check the admin
            if (emp_axxess.Count == 0)
            {

                //  Detail_Access_DTO dto = new Detail_Access_DTO();
                int Menu_A_Admin = 1;
                int Menu_B_Admin = 1;
                int Menu_C_Admin = 1;
                int Menu_D_Admin = 1;

                List<ACCESS> emp_acc_admin = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(Menu_A_Admin), Convert.ToInt32(Menu_B_Admin), Convert.ToInt32(Menu_C_Admin), Convert.ToInt32(Menu_D_Admin));
                if (emp_acc_admin.Count == 0)
                {


                    MessageBox.Show("You do not have permission to access");
                }
                else
                {
                    UC_Department frm_2 = new UC_Department();
                    frm_2.btn_add.Enabled = false;
                    frm_2.btn_Delete.Enabled = false;
                    frm_2.btn_Update.Enabled = false;
                    addUserControl(frm_2);
                    // MessageBox.Show("wede hariii");
                }
            }
            else
            {
                UC_Department frm = new UC_Department();

                addUserControl(frm);
                // MessageBox.Show("wede");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UC_Position uc = new UC_Position();
            addUserControl(uc);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void accsessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Access uc = new UC_Access();
            addUserControl(uc);
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            int Menu_A = 1;
            int Menu_B = 1;
            int Menu_c = 2;
            int Menu_D = 2; // Admin or user

            List<ACCESS> emp_axxess = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(Menu_A), Convert.ToInt32(Menu_B), Convert.ToInt32(Menu_c), Convert.ToInt32(Menu_D)); //check the admin
            if (emp_axxess.Count == 0)
            {

                //  Detail_Access_DTO dto = new Detail_Access_DTO();
                int Menu_A_Admin = 1;
                int Menu_B_Admin = 1;
                int Menu_C_Admin = 2;
                int Menu_D_Admin = 1;

                List<ACCESS> emp_acc_admin = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(Menu_A_Admin), Convert.ToInt32(Menu_B_Admin), Convert.ToInt32(Menu_C_Admin), Convert.ToInt32(Menu_D_Admin));
                if (emp_acc_admin.Count == 0)
                {


                    MessageBox.Show("You do not have permission to access");
                }
                else
                {
                    UC_Add_New_Emp frm_2 = new UC_Add_New_Emp();
                    frm_2.btn_add.Enabled = false;
                    frm_2.btn_Delete.Enabled = false;
                    frm_2.btn_Update.Enabled = false;
                    addUserControl(frm_2);
                    // MessageBox.Show("wede hariii");
                }
            }
            else
            {
                UC_Add_New_Emp frm = new UC_Add_New_Emp();

                addUserControl(frm);
                // MessageBox.Show("wede");
            }


        }

        private void loginAccssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_LOGIN uc = new UC_LOGIN();
            addUserControl(uc);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int log_out_update = 1;
            PASS log_out = new PASS();
            log_out.EMP_ID = User_Static.Emp_ID;
            log_out.LOG_IN_OUT = log_out_update;
            Login_BLL.Update_Login_Out(log_out);

            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void workInfoEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_EMP_WORK_TYPE uc = new UC_EMP_WORK_TYPE();
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int log_out_update = 1;

            PASS log_out = new PASS();
            log_out.EMP_ID = User_Static.Emp_ID;
            log_out.LOG_IN_OUT = log_out_update;
            Login_BLL.Update_Login_Out(log_out);

            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int emp_id = User_Static.Emp_ID;
            UC_change_password change = new UC_change_password();
            change.btn_add.Visible = false;
            change.txtid.Text = emp_id.ToString();
            addUserControl(change);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Attendance uc = new UC_Attendance();
            addUserControl(uc);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Application_Settin uc = new UC_Application_Settin();
            addUserControl(uc);

        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void noticePublishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Notice uc = new UC_Notice();
            addUserControl(uc);
        }

        private void noticeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Notice_View uc = new UC_Notice_View();
            addUserControl(uc);
        }

        public void Notice_Count()
        {
            Notice = Work_info_BLL.Get_Notice(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(User_Static.department), Convert.ToInt32(User_Static.emp_position));

            int count = Notice.Notice.Count;
            lblnotice.Text = count.ToString();
           
            lblmassage.Text = User_Static.Message;
        }

        private void Date_Tick(object sender, EventArgs e)
        {
            Notice_Count();
            
        }

        private void lblnotice_Click(object sender, EventArgs e)
        {
            UC_Notice_View uc = new UC_Notice_View();
            addUserControl(uc);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UC_Notice_View uc = new UC_Notice_View();
            addUserControl(uc);
        }

        private void getTShartToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gETTSHIRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_GET_T_SHIRT uc = new UC_GET_T_SHIRT();
            addUserControl(uc);
        }

        private void aDDSTOCKREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_NEW_T_SHIRT uc = new UC_NEW_T_SHIRT();
            addUserControl(uc);
        }

        private void retestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Report uc = new UC_Report();
            addUserControl(uc);
        }

        private void toDoListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toDoListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UC_To_List uc = new UC_To_List();
            addUserControl(uc);
            
        }
    }
}
