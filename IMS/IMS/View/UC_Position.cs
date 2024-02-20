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
    public partial class UC_Position : UserControl
    {
        public UC_Position()
        {
            InitializeComponent();
        }

        private void pnl_Department_Paint(object sender, PaintEventArgs e)
        {
        }
        private void ClearAll()
        {
            txt_Position.Clear();
            txt_id.Clear();
        }

        List<DEPARTMENT> Department_List = new List<DEPARTMENT>();
        private void LodeAllData()
        {
            List<Position_DTO> Position_List = new List<Position_DTO>();
            Position_List = Position_BLL.Get_Position();

            dataGridView1.DataSource = Position_List;
            dataGridView1.Columns[0].HeaderText = "Department";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Position";
            dataGridView1.Columns[3].Visible = false;

        }
        private void UC_Position_Load(object sender, EventArgs e)
        {
            LodeAllData();

            Department_List = Department_BLL.Get_Department();
            cmbDepartment.DataSource = Department_List;
            cmbDepartment.DisplayMember = "DEP_NAME";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            txt_id.Enabled = false;

            
           



        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Position.Text.Trim() == "")
                MessageBox.Show("Pleas Enter The Position");
            else
            {
                POSITION position = new POSITION();
                position.POSITION_NAME = txt_Position.Text;
                position.D_ID = Convert.ToInt32(cmbDepartment.SelectedValue);
                Position_BLL.Add_Position(position);
                MessageBox.Show("Add Position Success");
                LodeAllData();

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_id.Enabled = true;
                
            }
            else
            {
                txt_id.Enabled = false;
                
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete position", "Warning", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == result)
            {
                Position_BLL.Delete_Position(Convert.ToInt32(txt_id.Text));
                MessageBox.Show("Delete Position");
                LodeAllData();
                ClearAll();
            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Position.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        public Position_DTO detail = new Position_DTO();
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() == "")
                MessageBox.Show("Select Position Update");
            else
            {
                POSITION position = new POSITION();
                position.P_ID = Convert.ToInt32(txt_id.Text);
                position.POSITION_NAME = txt_Position.Text;
                position.D_ID = Convert.ToInt32(cmbDepartment.SelectedValue);
                Position_BLL.Update_Position(position);
                MessageBox.Show("Position Was Update");
                LodeAllData();
            }

         

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
          
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
