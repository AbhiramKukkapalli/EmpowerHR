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

namespace IMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UC_User_Login uc = new UC_User_Login();
            addUserControl(uc);
           // btn_change_pass.Enabled = false;
         
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
            btn_Login_UC.Hide();
            
        }

      
      

        private void btn_Login_UC_Click_1(object sender, EventArgs e)
        {
            UC_User_Login uc = new UC_User_Login();
            addUserControl(uc);
            btn_change_pass.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UC_change_password uc = new UC_change_password();
            addUserControl(uc);
            btn_Login_UC.Show();
            btn_change_pass.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
