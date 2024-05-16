namespace Hotel
{
    partial class AdminMenu
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnrevenue = new FontAwesome.Sharp.IconButton();
            this.btnreport = new FontAwesome.Sharp.IconButton();
            this.btnSalary = new FontAwesome.Sharp.IconButton();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnemployee = new FontAwesome.Sharp.IconButton();
            this.btnroom = new FontAwesome.Sharp.IconButton();
            this.buttoninventory = new FontAwesome.Sharp.IconButton();
            this.buttonschedual = new FontAwesome.Sharp.IconButton();
            this.btncustomer = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnrevenue);
            this.panel5.Controls.Add(this.btnreport);
            this.panel5.Controls.Add(this.btnSalary);
            this.panel5.Location = new System.Drawing.Point(-1, 670);
            this.panel5.MaximumSize = new System.Drawing.Size(279, 175);
            this.panel5.MinimumSize = new System.Drawing.Size(279, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 52);
            this.panel5.TabIndex = 7;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(284, 24);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(61, 28);
            this.linkLabel3.TabIndex = 16;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Logout";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(159, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Welcome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(175, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btnroom);
            this.panel1.Controls.Add(this.buttoninventory);
            this.panel1.Controls.Add(this.buttonschedual);
            this.panel1.Controls.Add(this.btncustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(272, 885);
            this.panel1.MinimumSize = new System.Drawing.Size(125, 885);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 885);
            this.panel1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1471, 885);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(217)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(125, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1346, 885);
            this.panel4.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 391);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(286, 54);
            this.iconButton3.TabIndex = 21;
            this.iconButton3.Text = "Book Room";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(-4, 559);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(283, 54);
            this.iconButton2.TabIndex = 19;
            this.iconButton2.Text = "In/Out";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnrevenue
            // 
            this.btnrevenue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnrevenue.FlatAppearance.BorderSize = 0;
            this.btnrevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrevenue.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrevenue.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnrevenue.IconColor = System.Drawing.Color.Black;
            this.btnrevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrevenue.IconSize = 35;
            this.btnrevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrevenue.Location = new System.Drawing.Point(0, 108);
            this.btnrevenue.Name = "btnrevenue";
            this.btnrevenue.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnrevenue.Size = new System.Drawing.Size(280, 54);
            this.btnrevenue.TabIndex = 8;
            this.btnrevenue.Text = "Revenue";
            this.btnrevenue.UseVisualStyleBackColor = false;
            this.btnrevenue.Click += new System.EventHandler(this.btnrevenue_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.White;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnreport.IconColor = System.Drawing.Color.Black;
            this.btnreport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreport.IconSize = 35;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(-1, 1);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(280, 54);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnSalary.IconColor = System.Drawing.Color.Black;
            this.btnSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalary.IconSize = 35;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(-1, 54);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(280, 54);
            this.btnSalary.TabIndex = 7;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnlogout.IconColor = System.Drawing.Color.Black;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.IconSize = 35;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(2, 111);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(266, 54);
            this.btnlogout.TabIndex = 20;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 167);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(272, 54);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Menu";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.White;
            this.btnemployee.FlatAppearance.BorderSize = 0;
            this.btnemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnemployee.IconColor = System.Drawing.Color.Black;
            this.btnemployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnemployee.IconSize = 35;
            this.btnemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemployee.Location = new System.Drawing.Point(0, 223);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnemployee.Size = new System.Drawing.Size(272, 54);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnroom
            // 
            this.btnroom.BackColor = System.Drawing.Color.White;
            this.btnroom.FlatAppearance.BorderSize = 0;
            this.btnroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnroom.IconColor = System.Drawing.Color.Black;
            this.btnroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnroom.IconSize = 35;
            this.btnroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Location = new System.Drawing.Point(0, 335);
            this.btnroom.Name = "btnroom";
            this.btnroom.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnroom.Size = new System.Drawing.Size(286, 54);
            this.btnroom.TabIndex = 2;
            this.btnroom.Text = " Create Room";
            this.btnroom.UseVisualStyleBackColor = false;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // buttoninventory
            // 
            this.buttoninventory.BackColor = System.Drawing.Color.White;
            this.buttoninventory.FlatAppearance.BorderSize = 0;
            this.buttoninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninventory.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninventory.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.buttoninventory.IconColor = System.Drawing.Color.Black;
            this.buttoninventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttoninventory.IconSize = 35;
            this.buttoninventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoninventory.Location = new System.Drawing.Point(-4, 447);
            this.buttoninventory.Name = "buttoninventory";
            this.buttoninventory.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttoninventory.Size = new System.Drawing.Size(280, 54);
            this.buttoninventory.TabIndex = 3;
            this.buttoninventory.Text = "Inventory";
            this.buttoninventory.UseVisualStyleBackColor = false;
            this.buttoninventory.Click += new System.EventHandler(this.buttoninventory_Click);
            // 
            // buttonschedual
            // 
            this.buttonschedual.BackColor = System.Drawing.Color.White;
            this.buttonschedual.FlatAppearance.BorderSize = 0;
            this.buttonschedual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonschedual.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonschedual.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.buttonschedual.IconColor = System.Drawing.Color.Black;
            this.buttonschedual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonschedual.IconSize = 35;
            this.buttonschedual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonschedual.Location = new System.Drawing.Point(-4, 503);
            this.buttonschedual.Name = "buttonschedual";
            this.buttonschedual.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonschedual.Size = new System.Drawing.Size(279, 54);
            this.buttonschedual.TabIndex = 4;
            this.buttonschedual.Text = "Schedule";
            this.buttonschedual.UseVisualStyleBackColor = false;
            this.buttonschedual.Click += new System.EventHandler(this.buttonschedual_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.White;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btncustomer.IconColor = System.Drawing.Color.Black;
            this.btncustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncustomer.IconSize = 35;
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(0, 279);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btncustomer.Size = new System.Drawing.Size(272, 54);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(-4, 615);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(290, 54);
            this.iconButton4.TabIndex = 22;
            this.iconButton4.Text = "Take Items";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 885);
            this.Controls.Add(this.panel2);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnrevenue;
        private FontAwesome.Sharp.IconButton btnreport;
        private FontAwesome.Sharp.IconButton btnSalary;
        private FontAwesome.Sharp.IconButton btnlogout;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnemployee;
        private FontAwesome.Sharp.IconButton btnroom;
        private FontAwesome.Sharp.IconButton buttoninventory;
        private FontAwesome.Sharp.IconButton buttonschedual;
        private FontAwesome.Sharp.IconButton btncustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}