using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.View
{
    public partial class UC_Application_Settin : UserControl
    {
        public UC_Application_Settin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Application_Settin_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            for (int i = 0; i<ports.Length; i++)
            {
                cmbPort.Items.Add(ports[i]);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            User_Static.ComPort = cmbPort.Text;
            MessageBox.Show("Add ComPort: "  +  cmbPort.Text);
        }
    }
}
