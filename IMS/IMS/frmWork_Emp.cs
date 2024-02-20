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
    public partial class frmWork_Emp : Form
    {
        public frmWork_Emp()
        {
            InitializeComponent();
        }
        Work_info_DTO emp_work = new Work_info_DTO();
        private void frmWork_Emp_Load(object sender, EventArgs e)
        {
            emp_work = Work_info_BLL.Get_Report_Emp();

            dataGridView1.DataSource = emp_work.Report_Emp_Detail;
            dataGridView1.Columns[0].HeaderText = "EMP ID";
            dataGridView1.Columns[1].HeaderText = "EMP NAME";
            dataGridView1.Columns[2].HeaderText = "POSITION";
            dataGridView1.Columns[3].HeaderText = "DEPARTMENT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtid.Text !="" && txtusername.Text != "")
            {

                int id = int.Parse(txtid.Text);
                User_Static.Report_Emp_ID = id;
                User_Static.Report_Emp_Name = txtusername.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("Selct the Employee");
            }
          
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
