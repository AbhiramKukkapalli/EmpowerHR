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

namespace IMS
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Message_Load(object sender, EventArgs e)
        {
           // button1.Enabled = false;

        }
        //bool b = true; // user is have
        private void btn_admin_Click(object sender, EventArgs e)
        {
            int Emp_ID = Convert.ToInt32(User_Static.Use_ID);
            int A = Detail_Access_DTO.MENU_A;
            int B = Detail_Access_DTO.MENU_B;
            int C = Detail_Access_DTO.MENU_C;
            int D = Detail_Access_DTO.MENU_D;
            int E = 1;


            List<ACCESS> emp_axxess = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Use_ID), Convert.ToInt32(A), Convert.ToInt32(B), Convert.ToInt32(C), Convert.ToInt32(E));
            if (emp_axxess.Count == 0)
            {

                ACCESS Acc = new ACCESS();
                Acc.EMP_ID = Emp_ID;
                Acc.MENU_A = A;
                Acc.MENU_B = B;
                Acc.MENU_C = C;
                Acc.MENU_D = D;

                Access_BLL.Access_add(Acc);
                //MessageBox.Show("Add Position Success admin");
                this.Close();
            }

            else
            {
                ACCESS Acc_Update = new ACCESS();
                Acc_Update.EMP_ID = Emp_ID;
                Acc_Update.MENU_A = A;
                Acc_Update.MENU_B = B;
                Acc_Update.MENU_C = C;
                Acc_Update.MENU_D = D;
                Access_BLL.Update_Admin_Or_User(Acc_Update);
                this.Close();





            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void btn_user_Click(object sender, EventArgs e)
        {
             int Emp_ID = Convert.ToInt32(User_Static.Use_ID);
            int A = Detail_Access_DTO.MENU_A;
            int B = Detail_Access_DTO.MENU_B;
            int C = Detail_Access_DTO.MENU_C;
            int D = Detail_Access_DTO.MENU_D;
            int E = 2;


            List<ACCESS> emp_axxess = Access_BLL.Get_Admin_Or_User(Convert.ToInt32(User_Static.Use_ID), Convert.ToInt32(A), Convert.ToInt32(B), Convert.ToInt32(C), Convert.ToInt32(E));
            if (emp_axxess.Count == 0)
            {

                ACCESS Acc = new ACCESS();
                Acc.EMP_ID = Emp_ID;
                Acc.MENU_A = A;
                Acc.MENU_B = B;
                Acc.MENU_C = C;
                Acc.MENU_D = D;

                Access_BLL.Access_add(Acc);
                //MessageBox.Show("Add Position Success admin");
                this.Close();
            }

            else
            {
                ACCESS Acc_Update = new ACCESS();
                Acc_Update.EMP_ID = Emp_ID;
                Acc_Update.MENU_A = A;
                Acc_Update.MENU_B = B;
                Acc_Update.MENU_C = C;
                Acc_Update.MENU_D = D;
                Access_BLL.Update_Admin_Or_User(Acc_Update);
                this.Close();





            }

           // ACCESS Acc = new ACCESS();
           // Acc.EMP_ID = Convert.ToInt32(User_Static.Use_ID);
           // Acc.MENU_A = Detail_Access_DTO.MENU_A;
           // Acc.MENU_B = Detail_Access_DTO.MENU_B;
           // Acc.MENU_C = Detail_Access_DTO.MENU_C;
           // Acc.MENU_D = Detail_Access_DTO.MENU_D;

           // Access_BLL.Access_add(Acc);
           //// MessageBox.Show("Add Position Success user");
           // this.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int Emp_ID = Convert.ToInt32(User_Static.Use_ID);
            int A = Detail_Access_DTO.MENU_A;
            int B = Detail_Access_DTO.MENU_B;
            int C = Detail_Access_DTO.MENU_C;
            int D = Detail_Access_DTO.MENU_D;


            Access_BLL.Delete_Access(Convert.ToInt32(Emp_ID), Convert.ToInt32(A), Convert.ToInt32(B), Convert.ToInt32(C));
            
            this.Close();
        }
    }
}
