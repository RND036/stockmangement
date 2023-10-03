
namespace stockmanagementsystem
{
    partial class formitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formitems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtboxquantityitems = new System.Windows.Forms.TextBox();
            this.txtboxproductnameitems = new System.Windows.Forms.TextBox();
            this.txtboxstockcodeitems = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblstockname = new System.Windows.Forms.Label();
            this.lblstockcode = new System.Windows.Forms.Label();
            this.btnedit = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.itemgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblcategory = new System.Windows.Forms.Label();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxquantityitems
            // 
            this.txtboxquantityitems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxquantityitems.Location = new System.Drawing.Point(490, 128);
            this.txtboxquantityitems.Name = "txtboxquantityitems";
            this.txtboxquantityitems.Size = new System.Drawing.Size(133, 28);
            this.txtboxquantityitems.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtboxquantityitems, "enter quantity");
            // 
            // txtboxproductnameitems
            // 
            this.txtboxproductnameitems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxproductnameitems.Location = new System.Drawing.Point(203, 186);
            this.txtboxproductnameitems.Name = "txtboxproductnameitems";
            this.txtboxproductnameitems.Size = new System.Drawing.Size(130, 28);
            this.txtboxproductnameitems.TabIndex = 11;
            // 
            // txtboxstockcodeitems
            // 
            this.txtboxstockcodeitems.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtboxstockcodeitems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxstockcodeitems.Location = new System.Drawing.Point(199, 128);
            this.txtboxstockcodeitems.Name = "txtboxstockcodeitems";
            this.txtboxstockcodeitems.ReadOnly = true;
            this.txtboxstockcodeitems.Size = new System.Drawing.Size(133, 28);
            this.txtboxstockcodeitems.TabIndex = 10;
            this.toolTip4.SetToolTip(this.txtboxstockcodeitems, "Stock code");
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblquantity.Location = new System.Drawing.Point(394, 132);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(76, 21);
            this.lblquantity.TabIndex = 9;
            this.lblquantity.Text = "Quantity";
            // 
            // lblstockname
            // 
            this.lblstockname.AutoSize = true;
            this.lblstockname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstockname.Location = new System.Drawing.Point(76, 190);
            this.lblstockname.Name = "lblstockname";
            this.lblstockname.Size = new System.Drawing.Size(121, 21);
            this.lblstockname.TabIndex = 8;
            this.lblstockname.Text = "Product Name";
            // 
            // lblstockcode
            // 
            this.lblstockcode.AutoSize = true;
            this.lblstockcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstockcode.Location = new System.Drawing.Point(76, 132);
            this.lblstockcode.Name = "lblstockcode";
            this.lblstockcode.Size = new System.Drawing.Size(97, 21);
            this.lblstockcode.TabIndex = 7;
            this.lblstockcode.Text = "Stock Code";
            this.lblstockcode.Click += new System.EventHandler(this.lblstockcode_Click);
            // 
            // btnedit
            // 
            this.btnedit.BorderRadius = 12;
            this.btnedit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnedit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnedit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnedit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(442, 58);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 36);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BorderRadius = 12;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(567, 57);
            this.btndelete.Name = "btndelete";
            this.btndelete.PressedColor = System.Drawing.Color.Red;
            this.btndelete.Size = new System.Drawing.Size(100, 36);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // itemgrid
            // 
            this.itemgrid.AllowUserToAddRows = false;
            this.itemgrid.AllowUserToDeleteRows = false;
            this.itemgrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.itemgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemgrid.ColumnHeadersHeight = 22;
            this.itemgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemgrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemgrid.Location = new System.Drawing.Point(48, 251);
            this.itemgrid.Name = "itemgrid";
            this.itemgrid.ReadOnly = true;
            this.itemgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.itemgrid.RowHeadersVisible = false;
            this.itemgrid.RowTemplate.Height = 25;
            this.itemgrid.Size = new System.Drawing.Size(639, 274);
            this.itemgrid.TabIndex = 15;
            this.itemgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.itemgrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.itemgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.itemgrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.itemgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.itemgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.itemgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemgrid.ThemeStyle.HeaderStyle.Height = 22;
            this.itemgrid.ThemeStyle.ReadOnly = true;
            this.itemgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.itemgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.itemgrid.ThemeStyle.RowsStyle.Height = 25;
            this.itemgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.toolTip2.SetToolTip(this.itemgrid, "double click to select item");
            this.itemgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemgrid_CellContentClick);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcategory.Location = new System.Drawing.Point(394, 190);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(79, 21);
            this.lblcategory.TabIndex = 17;
            this.lblcategory.Text = "Category";
            // 
            // combocategory
            // 
            this.combocategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "Electronic Items",
            "Food & Beverages",
            "Fashion",
            "Health",
            "Other"});
            this.combocategory.Location = new System.Drawing.Point(490, 186);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(133, 29);
            this.combocategory.TabIndex = 16;
            this.toolTip3.SetToolTip(this.combocategory, "select category");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(205, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Stock Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(55, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "** Choose an item from table **";
            this.toolTip5.SetToolTip(this.label2, "double click to select item");
            // 
            // formitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(733, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.itemgrid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtboxquantityitems);
            this.Controls.Add(this.txtboxproductnameitems);
            this.Controls.Add(this.txtboxstockcodeitems);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblstockname);
            this.Controls.Add(this.lblstockcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formitems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "items";
            this.Load += new System.EventHandler(this.form_items);
            ((System.ComponentModel.ISupportInitialize)(this.itemgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxquantityitems;
        private System.Windows.Forms.TextBox txtboxproductnameitems;
        private System.Windows.Forms.TextBox txtboxstockcodeitems;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblstockname;
        private System.Windows.Forms.Label lblstockcode;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2DataGridView itemgrid;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}