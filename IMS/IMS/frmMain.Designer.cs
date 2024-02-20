
namespace IMS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.workTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accsessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAccssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workInfoEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticePublishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTShartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gETTSHIRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSTOCKREPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDoListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Timer(this.components);
            this.pnl_UC_Control = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblnotice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmassage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnl_UC_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toDoListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.noticeToolStripMenuItem,
            this.getTShartToolStripMenuItem,
            this.retestToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.workTypeToolStripMenuItem,
            this.branchToolStripMenuItem,
            this.bankNameToolStripMenuItem,
            this.accsessToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem,
            this.loginAccssToolStripMenuItem,
            this.workInfoEmpToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::IMS.Properties.Resources.add_user;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::IMS.Properties.Resources.networking;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem2.Text = " Department";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::IMS.Properties.Resources.career_promotion;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem3.Text = " Position";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // workTypeToolStripMenuItem
            // 
            this.workTypeToolStripMenuItem.Name = "workTypeToolStripMenuItem";
            this.workTypeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.workTypeToolStripMenuItem.Text = "Work Type";
            // 
            // branchToolStripMenuItem
            // 
            this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            this.branchToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.branchToolStripMenuItem.Text = "Branch";
            // 
            // bankNameToolStripMenuItem
            // 
            this.bankNameToolStripMenuItem.Name = "bankNameToolStripMenuItem";
            this.bankNameToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bankNameToolStripMenuItem.Text = "Bank Name";
            // 
            // accsessToolStripMenuItem
            // 
            this.accsessToolStripMenuItem.Image = global::IMS.Properties.Resources.access;
            this.accsessToolStripMenuItem.Name = "accsessToolStripMenuItem";
            this.accsessToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.accsessToolStripMenuItem.Text = "Accsess";
            this.accsessToolStripMenuItem.Click += new System.EventHandler(this.accsessToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Image = global::IMS.Properties.Resources.division;
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // loginAccssToolStripMenuItem
            // 
            this.loginAccssToolStripMenuItem.Image = global::IMS.Properties.Resources.padlock;
            this.loginAccssToolStripMenuItem.Name = "loginAccssToolStripMenuItem";
            this.loginAccssToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loginAccssToolStripMenuItem.Text = "Login Accss";
            this.loginAccssToolStripMenuItem.Click += new System.EventHandler(this.loginAccssToolStripMenuItem_Click);
            // 
            // workInfoEmpToolStripMenuItem
            // 
            this.workInfoEmpToolStripMenuItem.Name = "workInfoEmpToolStripMenuItem";
            this.workInfoEmpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.workInfoEmpToolStripMenuItem.Text = "Work info emp";
            this.workInfoEmpToolStripMenuItem.Click += new System.EventHandler(this.workInfoEmpToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::IMS.Properties.Resources.login__1_;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noticeViewToolStripMenuItem,
            this.noticePublishToolStripMenuItem});
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.noticeToolStripMenuItem.Text = "Notice";
            this.noticeToolStripMenuItem.Click += new System.EventHandler(this.noticeToolStripMenuItem_Click);
            // 
            // noticeViewToolStripMenuItem
            // 
            this.noticeViewToolStripMenuItem.Name = "noticeViewToolStripMenuItem";
            this.noticeViewToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.noticeViewToolStripMenuItem.Text = "Notice View";
            this.noticeViewToolStripMenuItem.Click += new System.EventHandler(this.noticeViewToolStripMenuItem_Click);
            // 
            // noticePublishToolStripMenuItem
            // 
            this.noticePublishToolStripMenuItem.Name = "noticePublishToolStripMenuItem";
            this.noticePublishToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.noticePublishToolStripMenuItem.Text = "Notice Publish";
            this.noticePublishToolStripMenuItem.Click += new System.EventHandler(this.noticePublishToolStripMenuItem_Click);
            // 
            // getTShartToolStripMenuItem
            // 
            this.getTShartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gETTSHIRTToolStripMenuItem,
            this.aDDSTOCKREPORTToolStripMenuItem});
            this.getTShartToolStripMenuItem.Name = "getTShartToolStripMenuItem";
            this.getTShartToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.getTShartToolStripMenuItem.Text = "T-Shart";
            this.getTShartToolStripMenuItem.Click += new System.EventHandler(this.getTShartToolStripMenuItem_Click);
            // 
            // gETTSHIRTToolStripMenuItem
            // 
            this.gETTSHIRTToolStripMenuItem.Name = "gETTSHIRTToolStripMenuItem";
            this.gETTSHIRTToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gETTSHIRTToolStripMenuItem.Text = "GET-T-SHIRT";
            this.gETTSHIRTToolStripMenuItem.Click += new System.EventHandler(this.gETTSHIRTToolStripMenuItem_Click);
            // 
            // aDDSTOCKREPORTToolStripMenuItem
            // 
            this.aDDSTOCKREPORTToolStripMenuItem.Name = "aDDSTOCKREPORTToolStripMenuItem";
            this.aDDSTOCKREPORTToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aDDSTOCKREPORTToolStripMenuItem.Text = "ADD STOCK & REPORT";
            this.aDDSTOCKREPORTToolStripMenuItem.Click += new System.EventHandler(this.aDDSTOCKREPORTToolStripMenuItem_Click);
            // 
            // retestToolStripMenuItem
            // 
            this.retestToolStripMenuItem.Name = "retestToolStripMenuItem";
            this.retestToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.retestToolStripMenuItem.Text = "Re_test";
            this.retestToolStripMenuItem.Click += new System.EventHandler(this.retestToolStripMenuItem_Click);
            // 
            // toDoListToolStripMenuItem
            // 
            this.toDoListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDoListToolStripMenuItem1});
            this.toDoListToolStripMenuItem.Name = "toDoListToolStripMenuItem";
            this.toDoListToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toDoListToolStripMenuItem.Text = "Tools";
            this.toDoListToolStripMenuItem.Click += new System.EventHandler(this.toDoListToolStripMenuItem_Click);
            // 
            // toDoListToolStripMenuItem1
            // 
            this.toDoListToolStripMenuItem1.Name = "toDoListToolStripMenuItem1";
            this.toDoListToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.toDoListToolStripMenuItem1.Text = "To Do List";
            this.toDoListToolStripMenuItem1.Click += new System.EventHandler(this.toDoListToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1045, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "....";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(934, 12);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(40, 17);
            this.lblDateTime.TabIndex = 28;
            this.lblDateTime.Text = "Date";
            // 
            // Date
            // 
            this.Date.Enabled = true;
            this.Date.Interval = 1000;
            this.Date.Tick += new System.EventHandler(this.Date_Tick);
            // 
            // pnl_UC_Control
            // 
            this.pnl_UC_Control.Controls.Add(this.pictureBox1);
            this.pnl_UC_Control.Location = new System.Drawing.Point(12, 38);
            this.pnl_UC_Control.Name = "pnl_UC_Control";
            this.pnl_UC_Control.Size = new System.Drawing.Size(1160, 656);
            this.pnl_UC_Control.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMS.Properties.Resources._6308;
            this.pictureBox1.Location = new System.Drawing.Point(539, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(702, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(655, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "USER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(885, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "DATE:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1101, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 61;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnotice
            // 
            this.lblnotice.AutoSize = true;
            this.lblnotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblnotice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotice.Location = new System.Drawing.Point(517, 12);
            this.lblnotice.Name = "lblnotice";
            this.lblnotice.Size = new System.Drawing.Size(22, 17);
            this.lblnotice.TabIndex = 63;
            this.lblnotice.Text = "00";
            this.lblnotice.Click += new System.EventHandler(this.lblnotice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(454, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "NOTICE:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::IMS.Properties.Resources.notice;
            this.pictureBox5.Location = new System.Drawing.Point(423, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IMS.Properties.Resources.woman;
            this.pictureBox4.Location = new System.Drawing.Point(625, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IMS.Properties.Resources.appointment;
            this.pictureBox3.Location = new System.Drawing.Point(845, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IMS.Properties.Resources.man;
            this.pictureBox2.Location = new System.Drawing.Point(625, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Message:";
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmassage.Location = new System.Drawing.Point(53, 1);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(103, 15);
            this.lblmassage.TabIndex = 1;
            this.lblmassage.Text = "................";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblmassage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(2, 695);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 19);
            this.panel1.TabIndex = 65;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblnotice);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_UC_Control);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_UC_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer Date;
        public System.Windows.Forms.Panel pnl_UC_Control;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem workTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accsessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginAccssToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem workInfoEmpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noticePublishToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblnotice;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem getTShartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gETTSHIRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSTOCKREPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDoListToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblmassage;
        private System.Windows.Forms.Panel panel1;
    }
}

