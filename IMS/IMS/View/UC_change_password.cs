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
    public partial class UC_change_password : UserControl
    {
        public UC_change_password()
        {
            InitializeComponent();
        }

        private void UC_change_password_Load(object sender, EventArgs e)
        {
            Caps_lock();
            txtpass.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;
            txtRe_Password.UseSystemPasswordChar = true;
        }
        bool Finished = false;


        private bool TestPassword(string passwordText, int minimumLength = 5, int maximumLength = 12, int minimumNumbers = 1, int minimumLetters = 1)
        {


            int letters = 0;
            int digits = 0;
            int minLetters = 0;


            if (passwordText.Length < minimumLength)
            {
                MessageBox.Show("You must have at least " + minimumLength + " characters in your password.");
                Clear_Text_Box();
                return false;
            }

            if (passwordText.Length > maximumLength)
            {
                MessageBox.Show("You must have no more than " + maximumLength + " characters in your password.");
                Clear_Text_Box();
                return false;
            }

            foreach (var ch in passwordText)
            {
                if (char.IsLetter(ch)) letters++;
                if (char.IsDigit(ch)) digits++;

                if (ch > 96 && ch < 123)
                {
                    minLetters++;
                }
            }


            if (digits < minimumNumbers)
            {
                MessageBox.Show("You must have at least " + minimumNumbers + " numbers in your password.");
                Clear_Text_Box();
                return false;
               
            }
          



            if (!char.IsDigit(passwordText[0]) || !char.IsDigit(passwordText[passwordText.Length - 1]))
            {
                MessageBox.Show("The first and last characters of the password  have to be numbers");
                Clear_Text_Box();
                return false;
                
            }
       

            Finished = true;
            return true;


        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (txtid.Text.Trim() == "" || txtpass.Text.Trim() == "")
                MessageBox.Show("Pleas File the userno and password");
            else
            {
                List<PASS> emp_pass = Login_BLL.Get_Pass(Convert.ToInt32(txtid.Text), Get_Sha_Data(txtpass.Text));
                if (emp_pass.Count == 0)
                    MessageBox.Show("Plz control your informtion");

                if (txtPassword.Text == txtRe_Password.Text)
                {
                    bool temp = TestPassword(txtPassword.Text, 10, 100, 1, 1);


                    if (Finished == true)
                    {
                        PASS pass = new PASS();
                        pass.EMP_ID = Convert.ToInt32(txtid.Text);
                        pass.PASS1 = Get_Sha_Data(txtRe_Password.Text);
                        Login_BLL.Change_Passowrd(pass);

                        int log_out_update = 1;
                        PASS log_out = new PASS();
                        log_out.EMP_ID = Convert.ToInt32(txtid.Text);
                        log_out.LOG_IN_OUT = log_out_update;
                        Login_BLL.Update_Login_Out(log_out);

                        MessageBox.Show("Change Password !");
                        Clear_Text_Box();


                    }
                    else if (Finished == false)
                    {
                        
                    }
                }


                else
                {
                    MessageBox.Show("Please ensure the passwords you have typed match");
                    return;
                }

            }
        }
        public static string Get_Sha_Data(string data)
        {
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

        private void Clear_Text_Box()
        {
            txtid.Clear();
            txtpass.Clear();
            txtPassword.Clear();
            txtRe_Password.Clear();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void Caps_lock()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblCaps_lock.Text = "Caps Lock is ON !";
            }
            else
            {
                lblCaps_lock.Text = "";
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caps_lock();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caps_lock();
        }

        private void txtRe_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            Caps_lock();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
