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
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace IMS.View
{
    public partial class UC_EMP_WORK_TYPE : UserControl
    {
        private SerialPort RFID;
        private string DispString;
        public UC_EMP_WORK_TYPE()
        {
            InitializeComponent();
        }
        Employee_DTO emp_dto = new Employee_DTO();

        public bool IsValid { get; internal set; }
        List<DEPARTMENT> Department_List = new List<DEPARTMENT>();
        List<POSITION> Position_List = new List<POSITION>();
        List<WORK_TYPE> Work_Type_List = new List<WORK_TYPE>();
        List<BRANCH> Branch_List = new List<BRANCH>();
        private void button1_Click(object sender, EventArgs e)
        {
            frmSelect frm = new frmSelect();
            frm.Show();

        }
        string COMPORT = User_Static.ComPort;
        private void Load_cmb()
        {
            Department_List = Department_BLL.Get_Department();
            cmbDepartment.DataSource = Department_List;
            cmbDepartment.DisplayMember = "DEP_NAME";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;

            Position_List = Position_BLL.Get_Position_cmb();
            cmbPosition.DataSource = Position_List;
            cmbPosition.DisplayMember = "POSITION_NAME";
            cmbPosition.ValueMember = "P_ID";
            cmbPosition.SelectedIndex = -1;

            Work_Type_List = Work_info_BLL.Get_Work_Type();
            cmbWorkType.DataSource = Work_Type_List;
            cmbWorkType.DisplayMember = "W_NAME";
            cmbWorkType.ValueMember = "W_ID";
            cmbWorkType.SelectedIndex = -1;

            Branch_List = Work_info_BLL.Get_Branch();
            cmbBranch.DataSource = Branch_List;
            cmbBranch.DisplayMember = "BRANCH_NAME";
            cmbBranch.ValueMember = "B_ID";
            cmbBranch.SelectedIndex = -1;
        }

        Work_info_DTO emp_work = new Work_info_DTO();

        private void UC_EMP_WORK_TYPE_Load(object sender, EventArgs e)
        {
            txttag.Enabled = false;
            txttag.Text = "";


          

            Load_cmb();
            Load_Data();

            lblRowCount.Text = dataGridView1.RowCount.ToString();


            // dataGridView1.Columns[10].HeaderText = "Language";


        }
        private void Load_Data()
        {
            emp_work = Work_info_BLL.Get_Work_Emp();

            dataGridView1.DataSource = emp_work.Work_emp_Detail;

            dataGridView1.Columns[0].HeaderText = "EMP NAME";
            dataGridView1.Columns[1].HeaderText = "BRANCH";
            dataGridView1.Columns[2].HeaderText = "REPORT TO";
            dataGridView1.Columns[3].HeaderText = "DESCRIPTION";
            dataGridView1.Columns[4].HeaderText = "WORK TYPE";

            dataGridView1.Columns[5].HeaderText = "POSITION";
            dataGridView1.Columns[6].HeaderText = "DEPARTMENT";
            dataGridView1.Columns[7].HeaderText = "D/OF APPINMONT";
            dataGridView1.Columns[8].HeaderText = "D/OF CONFIRM";
            dataGridView1.Columns[9].HeaderText = "D/OF JOIN";
            dataGridView1.Columns[9].HeaderText = "NFC NUMBER";
        }




        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            Select_Emp_Detail.Select_Emp_Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();



        }



        public void txtname_Click(object sender, EventArgs e)
        {
            txtname.Text = Select_Emp_Detail.Select_Emp_Name;
        }



        private void txtname_Enter(object sender, EventArgs e)
        {
            txtname.Text = Select_Emp_Detail.Select_Emp_Name;
        }



        private void comboBox1_Click(object sender, EventArgs e)
        {
            txtname.Text = Select_Emp_Detail.Select_Emp_Name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<EMP_WORK_INFO> Check_IN = Work_info_BLL.Check_ID_IN(Convert.ToInt32(Select_Emp_Detail.Select_Emp_ID));
            if (Check_IN.Count == 0)
            {
                EMP_WORK_INFO emp_work = new EMP_WORK_INFO();
                emp_work.EMP_ID = Convert.ToInt32(Select_Emp_Detail.Select_Emp_ID);
                emp_work.B_ID = Convert.ToInt32(cmbBranch.SelectedValue);
                emp_work.RE_EMP_ID = Convert.ToInt32(Select_Emp_Detail.Report_Emp_ID);
                emp_work.DESCRIPTION = txtDescription.Text;
                emp_work.RE_EMP_ID = Convert.ToInt32(User_Static.Report_Emp_ID);
                emp_work.W_T_ID = Convert.ToInt32(cmbWorkType.SelectedValue);
                emp_work.P_ID = Convert.ToInt32(cmbPosition.SelectedValue);
                emp_work.D_ID = Convert.ToInt32(cmbDepartment.SelectedValue);

                emp_work.D_OF_A = dpapp.Value;
                emp_work.D_OF_C = dpConf.Value;
                emp_work.D_OF_JOIN = dpJoin.Value;
                emp_work.NFC_NUMBER = txttag.Text;
                Work_info_BLL.Add_Emp_Work_Detail(emp_work);
                Load_Data();
                MessageBox.Show("Success Fuly Add");
                lblRowCount.Text = dataGridView1.RowCount.ToString();

            }
            else
            {
               
                MessageBox.Show("already exist in system !","Message", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }


           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWork_Emp frm = new frmWork_Emp();
            frm.Show();
        }

        private void txtReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReport_Click(object sender, EventArgs e)
        {
            txtReport.Text = User_Static.Report_Emp_Name;
        }
        private void RFID_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (txttag.Text.Length >= 12)
            {
                RFID.Close();

            }
            else
            {
                DispString = RFID.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }

        }
        private void DisplayText(object sender, EventArgs e)
        {
            txttag.AppendText(DispString);
        }

        private void txttag_Click(object sender, EventArgs e)
        {

        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
            if (checkBox1.Checked == true)
            {
                    txttag.Enabled = true;
                if (String.IsNullOrEmpty(COMPORT))
                {
                    MessageBox.Show("COM PORT Is EMPTY");
                }
                else
                {
                    try
                    {
                        RFID = new SerialPort();
                        RFID.PortName = COMPORT;
                        RFID.BaudRate = 9600;
                        RFID.DataBits = 8;
                        RFID.Parity = Parity.None;
                        RFID.StopBits = StopBits.One;
                        RFID.Open();
                        RFID.ReadTimeout = 200;
                        if (RFID.IsOpen)
                        {
                            DispString = "";
                            txttag.Text = "";
                        }
                        else
                        {
                            RFID.Close();
                        }
                        RFID.DataReceived += new SerialDataReceivedEventHandler(RFID_DataReceived);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("RFID Is Not Connected" + ex + COMPORT);

                    }

                }


            }
            else if (checkBox1.Checked == false)
            {
                txttag.Enabled = false;
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
