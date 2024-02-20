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
    public partial class UC_Notice_View : UserControl
    {
        public UC_Notice_View()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Work_info_DTO Notice = new Work_info_DTO();
        private void UC_Notice_View_Load(object sender, EventArgs e)
        {
            Notice = Work_info_BLL.Get_Notice(Convert.ToInt32(User_Static.Emp_ID), Convert.ToInt32(User_Static.department), Convert.ToInt32(User_Static.emp_position));

            dataGridView1.DataSource = Notice.Notice;

            dataGridView1.Columns[0].HeaderText = "CODE";
            dataGridView1.Columns[1].HeaderText = "TITEL";
            dataGridView1.Columns[2].HeaderText = "PUBLISH BY";
            dataGridView1.Columns[3].HeaderText = "POSITION";
            dataGridView1.Columns[4].HeaderText = "POSITION";
            dataGridView1.Columns[5].HeaderText = "DATE";

            dataGridView1.ClearSelection();//If you want

            int count = Notice.Notice.Count;
           lblNotice.Text = count.ToString();


        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                txt_n_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
        }

        private void btn_n_show_Click(object sender, EventArgs e)
        {

            if(txt_n_id.Text != "")
            {
                List<NOTICE> NOTICE_BODY_GET = Work_info_BLL.notice_body_get(Convert.ToInt32(txt_n_id.Text));
                NOTICE Get_Notice = new NOTICE();
                Get_Notice = NOTICE_BODY_GET.First();
                txtbody.Text = Get_Notice.N_BODY;
            }
            else
            {
                MessageBox.Show("Pleas select the Notice");
            }
                
            


           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
