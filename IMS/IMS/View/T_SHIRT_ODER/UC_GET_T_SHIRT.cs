using BLL.T_SHIRT_BLL;
using DAL.DTO.T_SHIRT_DTO;
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



namespace IMS.View.T_SHIRT_ODER
{
    public partial class UC_GET_T_SHIRT : UserControl
    {
        public UC_GET_T_SHIRT()
        {
            InitializeComponent();
        }
        T_Shirt_DTO dto = new T_Shirt_DTO();
        Stock_ID_DTO get_id_dto = new Stock_ID_DTO();
        private void lode_tabel()
        {
            //my oder
            int pending = 1;

            dto = T_Shirt_BLL.My_Oder(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(pending));

            dataGridView2.DataSource = dto.t_oder;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "T_NAME";
            dataGridView2.Columns[2].HeaderText = "T_SIZE";
            dataGridView2.Columns[3].HeaderText = "EMP NAME";
            dataGridView2.Columns[4].HeaderText = "DATE";
            dataGridView2.Columns[5].HeaderText = "BRANCH";
            dataGridView2.Columns[6].HeaderText = "RECIPT NO";
            dataGridView2.Columns[7].HeaderText = "STATES";
            dataGridView2.Columns[8].HeaderText = "QUNTITY";
            dataGridView2.Columns[9].HeaderText = "PRICE";
            dataGridView2.Columns[10].Visible = false;
        }
        private void UC_GET_T_SHIRT_Load(object sender, EventArgs e)
        {

            dto = T_Shirt_BLL.Get_t_name_size();
            dataGridView1.DataSource = dto.t_stock;
            dataGridView1.Columns[0].HeaderText = "T_NAME";
            dataGridView1.Columns[1].HeaderText = "T_SIZE";
            dataGridView1.Columns[2].HeaderText = "QUNTITY";
            dataGridView1.Columns[3].HeaderText = "PRICE";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            cmbname.DataSource = dto.t_Name;
            cmbname.DisplayMember = "T_NAME";
            cmbname.ValueMember = "ID";
            cmbname.SelectedIndex = -1;

            cmbsize.DataSource = dto.t_Size;
            cmbsize.DisplayMember = "SIZE_NAME";
            cmbsize.ValueMember = "SIZE_ID";
            cmbsize.SelectedIndex = -1;



            lode_tabel();


        }

        private void txtReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int Oder_is_Online = 1; // oder is online not accept
            DialogResult result = MessageBox.Show("Are you Sure?", "warning !!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<T_SHIRT_STOCK> Stock_ID = T_Shirt_BLL.Get_Stock_ID(Convert.ToInt32(cmbname.SelectedValue), Convert.ToInt32(cmbsize.SelectedValue));
                T_SHIRT_STOCK stock_id_get = new T_SHIRT_STOCK();

                stock_id_get = Stock_ID.First();
                Stock_ID_DTO.Stock_ID = stock_id_get.ID;


                SALE_T_SHIRT get_t = new SALE_T_SHIRT();
                get_t.T_S_N_ID = Convert.ToInt32(cmbname.SelectedValue);
                get_t.T_S_SIZE_ID = Convert.ToInt32(cmbsize.SelectedValue);
                get_t.EMP_ID = Convert.ToInt32(User_Static.Emp_ID);
                get_t.DATE = DateTime.Today;
                get_t.B_ID = Convert.ToInt32(User_Static.emp_branch);
                get_t.RESIPT_NO = txtrecipt.Text;
                get_t.STATES = Convert.ToInt32(Oder_is_Online);
                get_t.QUANTITY = Convert.ToInt32(txtquntity.Text);
                get_t.ODER_ID = Convert.ToInt32(Stock_ID_DTO.Stock_ID);
                T_Shirt_BLL.Get_t_shirt(get_t);
                lode_tabel();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}
