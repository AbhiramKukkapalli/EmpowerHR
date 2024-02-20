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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        Employee_DTO emp_dto = new Employee_DTO();
        private void frmSelect_Load(object sender, EventArgs e)
        {
            emp_dto = Employee_BLL.Get_All_cmb();// lode BLL

            dataGridView1.DataSource = emp_dto.Employee_Detail;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Frist Name";
            dataGridView1.Columns[2].HeaderText = "Sure Name";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtid.Text !="" && txtusername.Text != "")
            {
                int ID = int.Parse(txtid.Text);

                Select_Emp_Detail.Select_Emp_ID = ID;
                Select_Emp_Detail.Select_Emp_Name = txtusername.Text;

                UC_EMP_WORK_TYPE uc = new UC_EMP_WORK_TYPE();
                uc.txtname.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Select the Employee");
            }
            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            

                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
