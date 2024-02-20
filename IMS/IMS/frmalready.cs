using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmalready : Form
    {
        public frmalready()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmalready_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int id = 1;
            int log_out_update = 1;
            PASS log_out = new PASS();
            log_out.EMP_ID = Convert.ToInt32(id);
            log_out.LOG_IN_OUT = log_out_update;
            Login_BLL.Update_Login_Out(log_out);
            this.Close();
        }
    }
}
