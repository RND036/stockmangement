
namespace stockmanagementsystem
{
    partial class formadditem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formadditem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblstockcode = new System.Windows.Forms.Label();
            this.lblstockname = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtboxstockcode = new System.Windows.Forms.TextBox();
            this.txtboxproductname = new System.Windows.Forms.TextBox();
            this.txtboxquantity = new System.Windows.Forms.TextBox();
            this.btnadditem = new Guna.UI2.WinForms.Guna2Button();
            this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstockcode
            // 
            this.lblstockcode.AutoSize = true;
            this.lblstockcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstockcode.Location = new System.Drawing.Point(61, 71);
            this.lblstockcode.Name = "lblstockcode";
            this.lblstockcode.Size = new System.Drawing.Size(97, 21);
            this.lblstockcode.TabIndex = 0;
            this.lblstockcode.Text = "Stock Code";
            // 
            // lblstockname
            // 
            this.lblstockname.AutoSize = true;
            this.lblstockname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstockname.Location = new System.Drawing.Point(49, 141);
            this.lblstockname.Name = "lblstockname";
            this.lblstockname.Size = new System.Drawing.Size(121, 21);
            this.lblstockname.TabIndex = 1;
            this.lblstockname.Text = "Product Name";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblquantity.Location = new System.Drawing.Point(439, 71);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(76, 21);
            this.lblquantity.TabIndex = 2;
            this.lblquantity.Text = "Quantity";
            // 
            // txtboxstockcode
            // 
            this.txtboxstockcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxstockcode.Location = new System.Drawing.Point(183, 67);
            this.txtboxstockcode.Name = "txtboxstockcode";
            this.txtboxstockcode.Size = new System.Drawing.Size(140, 28);
            this.txtboxstockcode.TabIndex = 4;
            this.toolTip2.SetToolTip(this.txtboxstockcode, "enter stock code");
            // 
            // txtboxproductname
            // 
            this.txtboxproductname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxproductname.Location = new System.Drawing.Point(183, 137);
            this.txtboxproductname.Name = "txtboxproductname";
            this.txtboxproductname.Size = new System.Drawing.Size(140, 28);
            this.txtboxproductname.TabIndex = 5;
            this.toolTip3.SetToolTip(this.txtboxproductname, "enter product name");
            // 
            // txtboxquantity
            // 
            this.txtboxquantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxquantity.Location = new System.Drawing.Point(527, 67);
            this.txtboxquantity.Name = "txtboxquantity";
            this.txtboxquantity.Size = new System.Drawing.Size(161, 28);
            this.txtboxquantity.TabIndex = 6;
            this.toolTip4.SetToolTip(this.txtboxquantity, "enter quantity");
            // 
            // btnadditem
            // 
            this.btnadditem.BorderRadius = 12;
            this.btnadditem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadditem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadditem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadditem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadditem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnadditem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.ForeColor = System.Drawing.Color.White;
            this.btnadditem.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnadditem.Image = ((System.Drawing.Image)(resources.GetObject("btnadditem.Image")));
            this.btnadditem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnadditem.Location = new System.Drawing.Point(301, 194);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.PressedColor = System.Drawing.Color.Blue;
            this.btnadditem.Size = new System.Drawing.Size(180, 45);
            this.btnadditem.TabIndex = 7;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.datagrid.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.datagrid.ColumnHeadersHeight = 21;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datagrid.Location = new System.Drawing.Point(9, 256);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(709, 235);
            this.datagrid.TabIndex = 9;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid.ThemeStyle.HeaderStyle.Height = 21;
            this.datagrid.ThemeStyle.ReadOnly = true;
            this.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
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
            this.combocategory.Location = new System.Drawing.Point(527, 133);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(161, 29);
            this.combocategory.TabIndex = 10;
            this.toolTip1.SetToolTip(this.combocategory, "select category");
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcategory.Location = new System.Drawing.Point(450, 137);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(79, 21);
            this.lblcategory.TabIndex = 11;
            this.lblcategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Stock Items";
            // 
            // formadditem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(733, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.txtboxquantity);
            this.Controls.Add(this.txtboxproductname);
            this.Controls.Add(this.txtboxstockcode);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblstockname);
            this.Controls.Add(this.lblstockcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formadditem";
            this.Text = "additem";
            this.Load += new System.EventHandler(this.formadditem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockcode;
        private System.Windows.Forms.Label lblstockname;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtboxstockcode;
        private System.Windows.Forms.TextBox txtboxproductname;
        private System.Windows.Forms.TextBox txtboxquantity;
        private Guna.UI2.WinForms.Guna2Button btnadditem;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}