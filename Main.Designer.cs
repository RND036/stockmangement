
namespace stockmanagementsystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblintrolog = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpost = new System.Windows.Forms.Label();
            this.lblprofname = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnadditem = new Guna.UI2.WinForms.Guna2Button();
            this.btnitems = new Guna.UI2.WinForms.Guna2Button();
            this.btnstocklevel = new Guna.UI2.WinForms.Guna2Button();
            this.btntransactionlog = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblclock = new System.Windows.Forms.Label();
            this.lbllogout = new System.Windows.Forms.Label();
            this.piclogout = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblintrolog
            // 
            this.lblintrolog.AutoSize = true;
            this.lblintrolog.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintrolog.Location = new System.Drawing.Point(70, 6);
            this.lblintrolog.Name = "lblintrolog";
            this.lblintrolog.Size = new System.Drawing.Size(102, 21);
            this.lblintrolog.TabIndex = 2;
            this.lblintrolog.Text = "MAIN FORM";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(15, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 26);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnminimize);
            this.panel1.Controls.Add(this.lblintrolog);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 29);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnminimize.FillColor = System.Drawing.Color.Transparent;
            this.btnminimize.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnminimize.IconColor = System.Drawing.Color.Black;
            this.btnminimize.Location = new System.Drawing.Point(848, 2);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(45, 26);
            this.btnminimize.TabIndex = 17;
            // 
            // btnclose
            // 
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageSize = new System.Drawing.Size(12, 12);
            this.btnclose.Location = new System.Drawing.Point(893, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(52, 28);
            this.btnclose.TabIndex = 18;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.btnadditem);
            this.flowLayoutPanel1.Controls.Add(this.btnitems);
            this.flowLayoutPanel1.Controls.Add(this.btnstocklevel);
            this.flowLayoutPanel1.Controls.Add(this.btntransactionlog);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 602);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblpost);
            this.panel2.Controls.Add(this.lblprofname);
            this.panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 122);
            this.panel2.TabIndex = 0;
            // 
            // lblpost
            // 
            this.lblpost.AutoSize = true;
            this.lblpost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpost.Location = new System.Drawing.Point(81, 79);
            this.lblpost.Name = "lblpost";
            this.lblpost.Size = new System.Drawing.Size(137, 21);
            this.lblpost.TabIndex = 2;
            this.lblpost.Text = "ADMINISTRATOR";
            this.lblpost.Click += new System.EventHandler(this.lblpost_Click);
            // 
            // lblprofname
            // 
            this.lblprofname.AutoSize = true;
            this.lblprofname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprofname.Location = new System.Drawing.Point(99, 45);
            this.lblprofname.Name = "lblprofname";
            this.lblprofname.Size = new System.Drawing.Size(101, 30);
            this.lblprofname.TabIndex = 1;
            this.lblprofname.Text = "kim john";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(9, 35);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(70, 74);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btndashboard);
            this.panel3.Location = new System.Drawing.Point(3, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 53);
            this.panel3.TabIndex = 34;
            // 
            // btndashboard
            // 
            this.btndashboard.BorderRadius = 16;
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndashboard.FillColor = System.Drawing.Color.Indigo;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btndashboard.Image = ((System.Drawing.Image)(resources.GetObject("btndashboard.Image")));
            this.btndashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btndashboard.Location = new System.Drawing.Point(1, -2);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.PressedColor = System.Drawing.Color.DarkRed;
            this.btndashboard.Size = new System.Drawing.Size(225, 50);
            this.btndashboard.TabIndex = 33;
            this.btndashboard.Text = "Dashbord";
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.BorderRadius = 16;
            this.btnadditem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadditem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadditem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadditem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadditem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadditem.FillColor = System.Drawing.Color.Indigo;
            this.btnadditem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.ForeColor = System.Drawing.Color.White;
            this.btnadditem.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnadditem.Image = ((System.Drawing.Image)(resources.GetObject("btnadditem.Image")));
            this.btnadditem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnadditem.Location = new System.Drawing.Point(3, 190);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.PressedColor = System.Drawing.Color.DarkRed;
            this.btnadditem.Size = new System.Drawing.Size(225, 53);
            this.btnadditem.TabIndex = 34;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // btnitems
            // 
            this.btnitems.BorderRadius = 16;
            this.btnitems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnitems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnitems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnitems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnitems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnitems.FillColor = System.Drawing.Color.Indigo;
            this.btnitems.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitems.ForeColor = System.Drawing.Color.White;
            this.btnitems.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnitems.Image = ((System.Drawing.Image)(resources.GetObject("btnitems.Image")));
            this.btnitems.ImageSize = new System.Drawing.Size(30, 30);
            this.btnitems.Location = new System.Drawing.Point(3, 249);
            this.btnitems.Name = "btnitems";
            this.btnitems.PressedColor = System.Drawing.Color.DarkRed;
            this.btnitems.Size = new System.Drawing.Size(225, 53);
            this.btnitems.TabIndex = 35;
            this.btnitems.Text = "Items";
            this.btnitems.Click += new System.EventHandler(this.btnitems_Click);
            // 
            // btnstocklevel
            // 
            this.btnstocklevel.BorderRadius = 16;
            this.btnstocklevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstocklevel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstocklevel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstocklevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstocklevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstocklevel.FillColor = System.Drawing.Color.Indigo;
            this.btnstocklevel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstocklevel.ForeColor = System.Drawing.Color.White;
            this.btnstocklevel.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnstocklevel.Image = ((System.Drawing.Image)(resources.GetObject("btnstocklevel.Image")));
            this.btnstocklevel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnstocklevel.Location = new System.Drawing.Point(3, 308);
            this.btnstocklevel.Name = "btnstocklevel";
            this.btnstocklevel.PressedColor = System.Drawing.Color.DarkRed;
            this.btnstocklevel.Size = new System.Drawing.Size(225, 53);
            this.btnstocklevel.TabIndex = 36;
            this.btnstocklevel.Text = "Stock Levels";
            this.btnstocklevel.Click += new System.EventHandler(this.btnstocklevel_Click);
            // 
            // btntransactionlog
            // 
            this.btntransactionlog.BorderRadius = 16;
            this.btntransactionlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntransactionlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntransactionlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntransactionlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntransactionlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntransactionlog.FillColor = System.Drawing.Color.Indigo;
            this.btntransactionlog.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransactionlog.ForeColor = System.Drawing.Color.White;
            this.btntransactionlog.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btntransactionlog.Image = ((System.Drawing.Image)(resources.GetObject("btntransactionlog.Image")));
            this.btntransactionlog.ImageSize = new System.Drawing.Size(30, 30);
            this.btntransactionlog.Location = new System.Drawing.Point(3, 367);
            this.btntransactionlog.Name = "btntransactionlog";
            this.btntransactionlog.PressedColor = System.Drawing.Color.DarkRed;
            this.btntransactionlog.Size = new System.Drawing.Size(225, 53);
            this.btntransactionlog.TabIndex = 37;
            this.btntransactionlog.Text = "Transaction Log";
            this.btntransactionlog.Click += new System.EventHandler(this.btntransactionlog_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(3, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 176);
            this.panel5.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "© 4GBX Solutions";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(47, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 122);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.lblclock);
            this.panel4.Controls.Add(this.lbllogout);
            this.panel4.Controls.Add(this.piclogout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(228, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 60);
            this.panel4.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(439, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lblclock
            // 
            this.lblclock.AutoSize = true;
            this.lblclock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblclock.Location = new System.Drawing.Point(482, 32);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(104, 25);
            this.lblclock.TabIndex = 36;
            this.lblclock.Text = "00:00:00";
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllogout.Location = new System.Drawing.Point(629, 38);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(45, 13);
            this.lbllogout.TabIndex = 35;
            this.lbllogout.Text = "Log Out";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // piclogout
            // 
            this.piclogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclogout.Image = ((System.Drawing.Image)(resources.GetObject("piclogout.Image")));
            this.piclogout.ImageRotate = 0F;
            this.piclogout.Location = new System.Drawing.Point(682, 29);
            this.piclogout.Name = "piclogout";
            this.piclogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.piclogout.Size = new System.Drawing.Size(32, 31);
            this.piclogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogout.TabIndex = 34;
            this.piclogout.TabStop = false;
            this.piclogout.Click += new System.EventHandler(this.piclogout_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(946, 602);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblintrolog;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblpost;
        private System.Windows.Forms.Label lblprofname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btndashboard;
        private Guna.UI2.WinForms.Guna2Button btnadditem;
        private Guna.UI2.WinForms.Guna2Button btnitems;
        private Guna.UI2.WinForms.Guna2Button btnstocklevel;
        private Guna.UI2.WinForms.Guna2Button btntransactionlog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbllogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox piclogout;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}