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
using DAL.DAO;
using System.Security.Cryptography;

namespace IMS.View
{
    public partial class UC_LOGIN : UserControl
    {
        public UC_LOGIN()
        {
            InitializeComponent();

            panel2.BackColor = Color.FromArgb(50, Color.Aqua);
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
                return false;
            }

            if (passwordText.Length > maximumLength)
            {
                MessageBox.Show("You must have no more than " + maximumLength + " characters in your password.");
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
                return false;
            }

            //if (minLetters < minimumLetters)
            //{
            //    MessageBox.Show("You must have at least " + minimumLetters + " letter in your password");
            //    return false;
            //}
            //Finished = true;
            //return true;

            if (!char.IsDigit(passwordText[0]) || !char.IsDigit(passwordText[passwordText.Length - 1]))
            {
                MessageBox.Show("The first and last characters of the password  have to be numbers");
                return false;
            }

            Finished = true;
            return true;


        }
        // private bool combofull = false;

        Login_DTO login_dto = new Login_DTO();

        private void UC_LOGIN_Load(object sender, EventArgs e)
        {

            login_dto = Login_BLL.Get_Data_cmb();
            cmb_Branch.DataSource = login_dto.Branch;
            cmb_Branch.DisplayMember = "BRANCH_NAME";
            cmb_Branch.ValueMember = "B_ID";
            cmb_Branch.SelectedIndex = -1;

            cmb_Employee.DataSource = login_dto.Emp_Info;
            cmb_Employee.DisplayMember = "NAME_SURENAME";
            cmb_Employee.ValueMember = "EMP_ID";
            cmb_Employee.SelectedIndex = -1;

      




        }

        private void cmb_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtRe_Password.Text)
            {
                bool temp = TestPassword(txtPassword.Text, 10, 100, 1, 1);


                if (Finished == true)
                {
                    PASS pass = new PASS();
                    pass.EMP_ID = Convert.ToInt32(cmb_Employee.SelectedValue);
                    pass.USER_NAME = cmb_Employee.Text;
                    pass.PASS1 = Get_Sha_Data(txtRe_Password.Text);
                    pass.BRANCH_ID = Convert.ToInt32(cmb_Branch.SelectedValue);
                    pass.CREAT_EMP_ID = User_Static.Emp_ID;
                    pass.CREAT_DATE = DateTime.Today;
                    Login_BLL.add_user_login(pass);



                    MessageBox.Show("Password Accepted");
                    //Application.Exit();
                    //this.Hide();
                    //Form2 f2 = new Form2();
                    //f2.ShowDialog();

                }
                else if (Finished == false)
                {
                    //MessageBox.Show("fuck");
                }
            }


            else
            {
                MessageBox.Show("Please ensure the passwords you have typed match");
                return;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == txtRe_Password.Text)
            {
                bool temp = TestPassword(txtPassword.Text, 10, 100, 1, 1);


                if (Finished == true)
                {
                    PASS pass = new PASS();
                    pass.EMP_ID = Convert.ToInt32(cmb_Employee.SelectedValue);
                    pass.PASS1 = Get_Sha_Data(txtRe_Password.Text);
                    Login_BLL.Change_Passowrd(pass);



                    MessageBox.Show("Change Password !");

                }
                else if (Finished == false)
                {
                    //MessageBox.Show("fuck");
                }
            }


            else
            {
                MessageBox.Show("Please ensure the passwords you have typed match");
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
