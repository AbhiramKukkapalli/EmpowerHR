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


namespace IMS.View.To_List
{
    public partial class UC_To_List : UserControl
    {
        public UC_To_List()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNote.Text != "")
            {
                int Waiting = 1;
                EMP_TO_DO_LIST todoList = new EMP_TO_DO_LIST();
                todoList.EMP_ID = User_Static.Emp_ID;
                todoList.NOTE = txtNote.Text;
                todoList.START_DATE = Convert.ToDateTime(DateTime.Now);
                todoList.END_DATE = dateTimePicker1.Value;
                todoList.STATUS = Waiting;
                Work_info_BLL.Add_TO_Do_List(todoList);
                
                User_Static.Message = "Success fully add !";
                To_Do_List_Lode(); 
                txtNote.Text = "";
            }
            else
            {
               
                User_Static.Message = "Notice body is empty !";
            }
        }
        Work_info_DTO To_Do_List = new Work_info_DTO();
        private void To_Do_List_Lode()
        {
            // Datagrid view from the Wating list
            int Waiting = 1;
            To_Do_List = Work_info_BLL.get_to_do_list(Convert.ToInt32(User_Static.Emp_ID) , Waiting);

            dataGridView1.DataSource = To_Do_List.To_Do_Lists;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOTE";
            dataGridView1.Columns[2].HeaderText = "START DATE";
            dataGridView1.Columns[3].HeaderText = "END DATE";
            dataGridView1.Columns[4].HeaderText = "STATES";

            //datagrid view from the complite
            int Complite = 2;
            To_Do_List = Work_info_BLL.get_complite_to_do_list(Convert.ToInt32(User_Static.Emp_ID), Complite);
            dataGridView3.DataSource = To_Do_List.complet_To_Do_List;
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[1].HeaderText = "NOTE";
            dataGridView3.Columns[2].HeaderText = "START DATE";
            dataGridView3.Columns[3].HeaderText = "END DATE";
            dataGridView3.Columns[4].HeaderText = "STATES";

            //datagride view is the noncomplite 
            int Non_Complite = 3;
            To_Do_List = Work_info_BLL.get_Noncomplite_to_do_list(Convert.ToInt32(User_Static.Emp_ID), Non_Complite);
            dataGridView2.DataSource = To_Do_List.Non_complet_To_Do_List;
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "NOTE";
            dataGridView2.Columns[2].HeaderText = "START DATE";
            dataGridView2.Columns[3].HeaderText = "END DATE";
            dataGridView2.Columns[4].HeaderText = "STATES";
        }
        private void UC_To_List_Load(object sender, EventArgs e)
        {
            To_Do_List_Lode();
            User_Static.Message = "To Do List";

        }

       

        public string To_Do_List_ID { get; set; }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                To_Do_List_ID = row.Cells[0].Value.ToString();
                txtNote.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnComplite_Click(object sender, EventArgs e)
        {

            int Complite = 2;
            complete_or_noncomplite(Complite);

        }

        private void btnNotComplite_Click(object sender, EventArgs e)
        {
            int Complite = 3;
            complete_or_noncomplite(Complite);
        }

        private void complete_or_noncomplite(int Complite)
        {
            if (To_Do_List_ID != null)
            {
                
                EMP_TO_DO_LIST todoList = new EMP_TO_DO_LIST();
                todoList.ID = Convert.ToInt32(To_Do_List_ID);
                todoList.STATUS = Convert.ToInt32(Complite);
                Work_info_BLL.Update_Non_Complite(todoList);
                User_Static.Message = "Success !";
                To_Do_List_ID = null;
                To_Do_List_Lode();
                txtNote.Clear();
            }
            else
            {
                User_Static.Message = "Not selected !";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (To_Do_List_ID != null)
            {

                DialogResult result = MessageBox.Show("Are you sure to delete ", "Warning", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result)
                {

                    Work_info_BLL.Delete_todolist(Convert.ToInt32(To_Do_List_ID));
                    To_Do_List_Lode();
                    User_Static.Message = "Delete Note";
                    To_Do_List_ID = null;
                    txtNote.Clear();

                }
            }
            else
            {
                User_Static.Message = "Not selected !";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
