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
using DAL.DTO.T_SHIRT_DTO;
using BLL.T_SHIRT_BLL;

namespace IMS.View.T_SHIRT_ODER
{
    public partial class UC_NEW_T_SHIRT : UserControl
    {
        public UC_NEW_T_SHIRT()
        {
            InitializeComponent();
        }
        T_Shirt_DTO dto = new T_Shirt_DTO();
        Get_Quantity_DTO quantity = new Get_Quantity_DTO();
        Stock_ID_DTO stock_sale_id = new Stock_ID_DTO();
        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure?", "warning !!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                List<T_SHIRT_STOCK> chech_stock = T_Shirt_BLL.Check_Stock(Convert.ToInt32(cmbtname.SelectedValue), Convert.ToInt32(cmbtsize.SelectedValue));
                if (chech_stock.Count == 0)
                {
                    T_SHIRT_STOCK stock = new T_SHIRT_STOCK();
                    stock.T_S_N_ID = Convert.ToInt32(cmbtname.SelectedValue);
                    stock.T_S_SIZE_ID = Convert.ToInt32(cmbtsize.SelectedValue);
                    stock.T_STOCK_QUANTITY = Convert.ToInt32(txtquantity.Text);
                    T_Shirt_BLL.Add_Stock(stock);
                    lode_table();
                }
                else
                {


                    T_SHIRT_STOCK stock_get_quantity = new T_SHIRT_STOCK();
                    stock_get_quantity = chech_stock.First();

                    Get_Quantity_DTO.Quantity = stock_get_quantity.T_STOCK_QUANTITY;

                    int Existing_Quantity = Convert.ToInt32(Get_Quantity_DTO.Quantity);
                    int New_Quantity = Convert.ToInt32(txtquantity.Text);
                    int Update_Quantity = Existing_Quantity + New_Quantity;

                    T_SHIRT_STOCK update_stock = new T_SHIRT_STOCK();
                    update_stock.T_S_N_ID = Convert.ToInt32(cmbtname.SelectedValue);
                    update_stock.T_S_SIZE_ID = Convert.ToInt32(cmbtsize.SelectedValue);
                    update_stock.T_STOCK_QUANTITY = Convert.ToInt32(Update_Quantity);
                    T_Shirt_BLL.Update_Stock(update_stock);
                    MessageBox.Show("Work");
                    lode_table();
                    Get_Quantity_DTO.Quantity = 0;

                }

            }
            else 
            {
                txtquantity.Text = "";
                cmbtname.SelectedIndex = -1;
                cmbtsize.SelectedValue = -1 ;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtoder_id.Text != "")
            {
                List<T_SHIRT_STOCK> chech_stock_squntity = T_Shirt_BLL.Check_Stock(Convert.ToInt32(stock_sale_id.Sale_ID));
                T_SHIRT_STOCK stock_get_quantity = new T_SHIRT_STOCK();
                stock_get_quantity = chech_stock_squntity.First();

                Get_Quantity_DTO.Quantity = stock_get_quantity.T_STOCK_QUANTITY;
                int Existing_Quantity = Convert.ToInt32(Get_Quantity_DTO.Quantity);
                int New_Quantity = Convert.ToInt32(stock_sale_id.oder_quntity);
                int Update_Quantity = Existing_Quantity - New_Quantity;
                T_SHIRT_STOCK update_stock = new T_SHIRT_STOCK();
                update_stock.ID = Convert.ToInt32(stock_sale_id.Sale_ID);
                update_stock.T_STOCK_QUANTITY = Convert.ToInt32(Update_Quantity);
                T_Shirt_BLL.Update_Stock_quntity(update_stock);

                /////////////////////update to states oder complete//////////////////////////
                int oder_complete = 2;
                SALE_T_SHIRT update_complete = new SALE_T_SHIRT();
                update_complete.ID = Convert.ToInt32(stock_sale_id.sale_up_id);
                update_complete.STATES = Convert.ToInt32(oder_complete);
                T_Shirt_BLL.Update_States(update_complete);
                /////////////////////update to states oder complete//////////////////////////


                lode_table();
            }
            else
            {
                MessageBox.Show("Select Oder !");
            }

           
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void lode_table()
        {
            dto = T_Shirt_BLL.Get_t_name_size();

            dataGridView_stock.DataSource = dto.t_stock;
            dataGridView_stock.Columns[0].HeaderText = "T_NAME";
            dataGridView_stock.Columns[1].HeaderText = "T_SIZE";
            dataGridView_stock.Columns[2].HeaderText = "QUNTITY";
            dataGridView_stock.Columns[3].Visible = false;
            dataGridView_stock.Columns[4].HeaderText = "All PRICE";

            int pending = 1;
            dto = T_Shirt_BLL.Pending_Oders(Convert.ToInt32(pending));

           

            // oder tabel lode
            dataGridView1.DataSource = dto.t_oder;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "T_NAME";
            dataGridView1.Columns[2].HeaderText = "T_SIZE";
            dataGridView1.Columns[3].HeaderText = "EMP NAME";
            dataGridView1.Columns[4].HeaderText = "DATE";
            dataGridView1.Columns[5].HeaderText = "BRANCH";
            dataGridView1.Columns[6].HeaderText = "RECIPT NO";
            dataGridView1.Columns[7].HeaderText = "STATES";
            dataGridView1.Columns[8].HeaderText = "QUNTITY";
            dataGridView1.Columns[9].HeaderText = "PRICE";
            dataGridView1.Columns[10].Visible = false;
           
        }
        private void UC_NEW_T_SHIRT_Load(object sender, EventArgs e)
        {
            lode_table();



            


            cmbtname.DataSource = dto.t_Name;
            cmbtname.DisplayMember = "T_NAME";
            cmbtname.ValueMember = "ID";
            cmbtname.SelectedIndex = -1;

            cmbtsize.DataSource = dto.t_Size;
            cmbtsize.DisplayMember = "SIZE_NAME";
            cmbtsize.ValueMember = "SIZE_ID";
            cmbtsize.SelectedIndex = -1;
           


        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Genaral.isNumber(e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            T_SHIRT_NAME name = new T_SHIRT_NAME();
            name.T_NAME = txtname.Text;
            name.PRICE = Convert.ToInt32(txtprice.Text);
            T_Shirt_BLL.Add_Name_Price(name);
            MessageBox.Show("Success !");
            txtname.Text = "";
            txtprice.Text = "";


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            txtquantity.Text = "";
            cmbtname.SelectedIndex = -1;
            cmbtsize.SelectedValue = -1;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
       
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
              //  txtoder_id.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtoder_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            stock_sale_id.Sale_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            stock_sale_id.oder_quntity =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            stock_sale_id.sale_up_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);



        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
