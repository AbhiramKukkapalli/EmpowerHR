using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using BLL;
using DAL;
using System.Speech.Synthesis;

namespace IMS.View
{
    public partial class UC_Attendance : UserControl

    {

        SpeechSynthesizer speech;
        private SerialPort RFID;
        private string DispString;
        public UC_Attendance()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }
        string COMPORT = User_Static.ComPort;
        private void UC_Attendance_Load(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(COMPORT))

                MessageBox.Show("COM PORT Is EMPTY");


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
                RFID.Close();
                // RFID.Close();

            }





            // label4.Text = COMPORT;
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



                /////////////////////////////////////////
                List<EMP_WORK_INFO> Check_IN = Work_info_BLL.Check_NFC(txttag.Text);
                if (Check_IN.Count == 0)
                {
                    MessageBox.Show("Not HAve NFC Registert");

                    txttag.Invoke((MethodInvoker)(() => txttag.Text = ""));
                    textBox1.Invoke((MethodInvoker)(() => textBox1.Text = ""));
                }
                else
                {
                    // show to name textbox///
                    List<NFC_NAME_VIEW> attend_user_name = Work_info_BLL.Get_Attend_User_Name(txttag.Text);

                    NFC_NAME_VIEW user_name = new NFC_NAME_VIEW();
                    user_name = attend_user_name.First();

                    User_Static.testUser_name = user_name.NAME_SURENAME;
                    User_Static.Atte_Emp_ID = user_name.EMP_ID;

                    User_Static.Frist_Name_Atte = user_name.FRIST_NAME;


                    //textBox1.Text = User_Static.testUser_name;
                    string name = User_Static.testUser_name;

                    textBox1.Invoke((MethodInvoker)(() => textBox1.Text = User_Static.testUser_name));



                    string G_M;


                    if (DateTime.Now.Hour < 12)
                    {
                        G_M = "Good Morning";

                    }
                    else if (DateTime.Now.Hour < 17)
                    {
                        G_M = "Good Afternoon";
                    }
                    else
                    {
                        G_M = "Good Evening";
                    }



                    speech.SpeakAsync(G_M + User_Static.Frist_Name_Atte);

                    // show to name textbox///
                    /////////////////////////////////////////
                    var TIME = DateTime.Now.ToString("hh:mm:ss tt");



                    List<ATTENDANCE> Attendance_IN_OUT = Work_info_BLL.Atte_IN_OUT_Check(Convert.ToInt32(User_Static.Atte_Emp_ID), DateTime.Today);
                    if (Attendance_IN_OUT.Count == 0)
                    {

                        ATTENDANCE attendance = new ATTENDANCE();
                        attendance.CODE = Convert.ToInt32(User_Static.Atte_Emp_ID);
                        attendance.DATE = DateTime.Today;
                        attendance.IN_TIME = Convert.ToDateTime(TIME);
                        Work_info_BLL.Add_Attendance(attendance);
                    }
                    else
                    {
                        ATTENDANCE Set_Out_Time = new ATTENDANCE();
                        Set_Out_Time.CODE = Convert.ToInt32(User_Static.Atte_Emp_ID);
                        Set_Out_Time.DATE = DateTime.Today;
                        Set_Out_Time.OUT_TIME = Convert.ToDateTime(TIME);
                        Work_info_BLL.OUT_Time_Attendance(Set_Out_Time);



                    }
                    //////////////////////////
                    Name_30se.Start();
                }

            }

        }
       
        
        private void DisplayText(object sender, EventArgs e)
        {
            txttag.AppendText(DispString);





        }

        private void Date_Time_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttag.Text = "";
            textBox1.Text = "";


        }

        private void txttag_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txttag_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void Atte()
        {


        }

        private void cb_voice_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txttag.Invoke((MethodInvoker)(() => txttag.Text = ""));
            textBox1.Invoke((MethodInvoker)(() => textBox1.Text = ""));
        }
    }
}
