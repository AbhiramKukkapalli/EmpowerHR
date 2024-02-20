using BLL;
using DAL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IMS.View
{
    public partial class UC_Department : UserControl
    {

        public UC_Department()
        {
            InitializeComponent();
        }
        private void ClearTextBox()
        {
            txtid.Clear();
            txtdep.Clear();
        }
        DEPARTMENT Department = new DEPARTMENT();
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdep.Text.Trim() == "")
                    MessageBox.Show("Please Fill The Department");
                else
                {

                    Department.DEP_NAME = txtdep.Text;
                    Department_BLL.AddDepartment(Department);
                    MessageBox.Show("Department Add  !");
                    FillAllData();
                    ClearTextBox();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void pnl_Department_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FillAllData()
        {
            List<DEPARTMENT> list = new List<DEPARTMENT>();
            list = Department_BLL.Get_Department();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Department Name";
            txtid.Enabled = false;
        }
        private void UC_Department_Load(object sender, EventArgs e)
        {

            FillAllData();
            dto = Department_BLL.GetAll();


        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdep.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        Department_DTO dto = new Department_DTO();

        public object pnl_UC_Control { get; private set; }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txtdep.Text.Trim() == "")
                MessageBox.Show("Please Enter Department Name !");
            else
            {
                List<Department_Detail_DTO> list = dto.Department;
                if (txtid.Text.Trim() != "")
                    list = list.Where(x => x.dep_id == Convert.ToInt32(txtid.Text)).ToList();
                if (txtdep.Text.Trim() != "")
                    list = list.Where(x => x.dep_name.Contains(txtdep.Text)).ToList();
                dataGridView1.DataSource = list;
                //ClearTextBox();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.pnl_UC_Control.Visible = false;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure update", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Department.ID = Convert.ToInt32(txtid.Text);
                    Department.DEP_NAME = txtdep.Text;
                    Department_BLL.Update_Department(Department);
                    MessageBox.Show("Department Was Update !");
                    FillAllData();
                    ClearTextBox();
                }

            }

            else
            {
                MessageBox.Show("Pleas Select Update Department");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure Delete", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Department_BLL.Delete_Department(Convert.ToInt32(txtid.Text));
                    MessageBox.Show("Department Was Delete !");
                    FillAllData();
                    ClearTextBox();
                }

            }

            else
            {
                MessageBox.Show("Pleas Select Delete Department");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtid.Enabled= true;
                //foodQtyTxtBox.Visible = true;
            }
            else
            {
                txtid.Enabled = false;
                //foodQtyTxtBox.Visible = false;
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }
    }
}
