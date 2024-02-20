using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace IMS.View
{
    public partial class UC_User_Login : UserControl
    {
        public UC_User_Login()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UC_User_Login_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            Caps_lock(); //check caps lock press
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == "" || txtpass.Text.Trim() == "")

                MessageBox.Show("Pleas File the user no and password");
           
            else
            {
                List<PASS> emp_pass = Login_BLL.Get_Pass(Convert.ToInt32(txtid.Text), Get_Sha_Data(txtpass.Text));
                if (emp_pass.Count == 0)
                    MessageBox.Show("Plz control your informtion");
                else
                {


                    PASS user_name = new PASS();
                    user_name = emp_pass.First();

                    User_Static.Emp_Name = user_name.USER_NAME;

                    User_Static.Emp_ID = (int)user_name.EMP_ID;
                    /////////////////////////////////////
                    List<EMP_WORK_INFO> work_detail = Work_info_BLL.Get_de_branch_po(Convert.ToInt32(txtid.Text));
                    EMP_WORK_INFO emp_work_enfo = new EMP_WORK_INFO();

                    emp_work_enfo = work_detail.First();

                    User_Static.department = emp_work_enfo.D_ID;
                    User_Static.emp_position = emp_work_enfo.P_ID;
                    User_Static.emp_branch = emp_work_enfo.B_ID;
                    //////////////////////////////////////////////
                    int logi_in = 1;

                    List<PASS> emp = Login_BLL.Get_Login_Out(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32 (logi_in));
                    if(emp.Count == 0)

                    {
                        // Open the already login error massage form 
                        frmalready frma = new frmalready();
                        frma.label2.Text = User_Static.Emp_Name;
                        frma.ShowDialog();
                    }
                    else
                    {

                        frmMain frm = new frmMain();
                        frm.label2.Text = User_Static.Emp_Name; // set the static poroperty to employee ID

                        int log_out_update =0;
                        PASS log_out = new PASS();

                        log_out.EMP_ID = User_Static.Emp_ID; // set the employee ID to update data
                        log_out.LOG_IN_OUT = log_out_update; // update the logou in system 
                        log_out.LAST_L_DATE_TIME = Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt"));  //Update the last login date pass tabel
                        Login_BLL.Update_Login_Out(log_out);


                        // set the RFID com port --COM3--
                        string com= "COM3";
                        User_Static.ComPort =com;

                        //int x = User_Static.Emp_ID;
                        //frm.label5.Text = x.ToString(); 

                        ((Form)this.TopLevelControl).Hide(); // hide the main from frmlogin

                        frm.ShowDialog();
                    }
                }
            }
        }
        public static string Get_Sha_Data(string data)
        {
            // hash the password
            SHA1 sha = SHA1.Create();
            Byte[] hasData = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnvalue = new StringBuilder();
            int i;
            for (i = 0; i < hasData.Length - 1; i++)
            {
                returnvalue.Append(hasData[i].ToString());

            }
            return returnvalue.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {


        }
        private void clear_txt_box()
        {
            txtid.Clear();
            txtpass.Clear();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {

            Caps_lock();
        }

        private void Caps_lock()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label1.Text = "Caps Lock is ON !";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
                

            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
           
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           
        }
    }
}
