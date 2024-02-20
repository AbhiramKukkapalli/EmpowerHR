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
    public partial class UC_Add_New_Emp : UserControl
    {
        public UC_Add_New_Emp()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }
        //List<BLOOD_GROUP>Blood_Group_Get = new List<BLOOD_GROUP>(); // lode the cmb data 

        Employee_DTO emp_dto = new Employee_DTO();

        private void UC_Add_New_Emp_Load(object sender, EventArgs e)
        {
            

            emp_dto = Employee_BLL.Get_All_cmb();// lode BLL

            dataGridView1.DataSource = emp_dto.Employee_Detail;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Frist Name";
            dataGridView1.Columns[2].HeaderText = "Sure Name";
            dataGridView1.Columns[3].HeaderText = "DOB";
            dataGridView1.Columns[4].HeaderText = "Mobile";

            dataGridView1.Columns[5].HeaderText = "NIC";
            dataGridView1.Columns[6].HeaderText = "Email";
            dataGridView1.Columns[7].HeaderText = "Blood Group";
            dataGridView1.Columns[8].HeaderText = "Address";
            dataGridView1.Columns[9].HeaderText = "Gender";
            dataGridView1.Columns[10].HeaderText = "Language";
            dataGridView1.Columns[11].HeaderText = "Status";



            //Lode the cbm to blood groop data//



            cmb_blood_group.DataSource = emp_dto.Blood_Group_Get;
            cmb_blood_group.DisplayMember = "BLOOD_NAME";
            cmb_blood_group.ValueMember = "B_ID";
            cmb_blood_group.SelectedIndex = -1;

            cmb_Gender.DataSource = emp_dto.Gender_Get;
            cmb_Gender.DisplayMember = "GENDER1";
            cmb_Gender.ValueMember = "G_ID";
            cmb_Gender.SelectedIndex = -1;

            cmb_Language.DataSource = emp_dto.Language_Get;
            cmb_Language.DisplayMember = "LANGUAGE1";
            cmb_Language.ValueMember = "L_ID";
            cmb_Language.SelectedIndex = -1;

            cmbStatus.DataSource = emp_dto.Status;
            cmbStatus.DisplayMember = "STATUS1";
            cmbStatus.ValueMember = "ID";
            cmbStatus.SelectedIndex = -1;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           

            EMP_INFO emp_info = new EMP_INFO();
            emp_info.FRIST_NAME = txt_Frist_Name.Text;
            emp_info.NAME_SURENAME = txt_full_name.Text;
            emp_info.NIC = txt_nic.Text;
            emp_info.DOB = dp_dob.Value;
            emp_info.MOBILE = Convert.ToInt32(txt_Mobile.Text);
            emp_info.BLOOD_ID = Convert.ToInt32(cmb_blood_group.SelectedValue);
            emp_info.GENDER = Convert.ToInt32(cmb_Gender.SelectedValue);
            emp_info.LANGUAGE = Convert.ToInt32(cmb_Language.SelectedValue);
            emp_info.EMAIL = txt_email.Text;
            emp_info.ADDRESS = txt_Address.Text;
            emp_info.EMP_CREATE_DATE = DateTime.Now;
            emp_info.CREATE_EMP_ID = User_Static.Emp_ID;
            emp_info.STATUS = Convert.ToInt32(cmbStatus.SelectedValue);
            Employee_BLL.Add_Emp_Data(emp_info);

            MessageBox.Show("Save data");


        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Frist_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_full_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dp_dob.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_Mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_nic.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmb_blood_group.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmb_Gender.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                cmb_Language.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_Address.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

            }


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Logger.WriteLog("Miwe");
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
