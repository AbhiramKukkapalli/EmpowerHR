
namespace IMS
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.btn_Login_UC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 425);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMS.Properties.Resources._4565;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(416, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 399);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_change_pass.FlatAppearance.BorderSize = 0;
            this.btn_change_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_pass.Location = new System.Drawing.Point(515, 415);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(142, 23);
            this.btn_change_pass.TabIndex = 23;
            this.btn_change_pass.Text = "Change Password";
            this.btn_change_pass.UseVisualStyleBackColor = false;
            this.btn_change_pass.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Login_UC
            // 
            this.btn_Login_UC.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Login_UC.FlatAppearance.BorderSize = 0;
            this.btn_Login_UC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login_UC.Location = new System.Drawing.Point(515, 415);
            this.btn_Login_UC.Name = "btn_Login_UC";
            this.btn_Login_UC.Size = new System.Drawing.Size(142, 23);
            this.btn_Login_UC.TabIndex = 37;
            this.btn_Login_UC.Text = "Login";
            this.btn_Login_UC.UseVisualStyleBackColor = false;
            this.btn_Login_UC.Click += new System.EventHandler(this.btn_Login_UC_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 439);
            this.Controls.Add(this.btn_Login_UC);
            this.Controls.Add(this.btn_change_pass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_change_pass;
        public System.Windows.Forms.Button btn_Login_UC;
    }
}