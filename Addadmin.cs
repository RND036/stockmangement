using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;





namespace stockmanagementsystem
{
    public partial class Addadmin : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Addadmin()
        {
            InitializeComponent();
        }

        private void Addadmin_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }

        private void circlebtn_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
     
        }

        private void lblintrolog_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Quit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxadminid.Text=="" || txtboxadminname.Text=="" || txtboxusername.Text=="" || txtboxpassword.Text=="" || txtboxconfirm.Text=="")
                {
                    MessageBox.Show("Fields Are Empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtboxpassword.Text == txtboxconfirm.Text)
                {

                    string sql = "INSERT INTO addadmin (admin_id, admin_name, username, password, confirm_password)VALUES('" + txtboxadminid.Text + "', '" + txtboxadminname.Text + "', '" + txtboxusername.Text + "', '" + txtboxpassword.Text + "', '" + txtboxconfirm.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Registration Successful ", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                else
                {
                    MessageBox.Show("password doesn't match,please re-enter", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtboxpassword.Text = "";
                    txtboxconfirm.Text = "";
                    txtboxpassword.Focus();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Stock Management System",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtboxadminid.Text = "";
            txtboxadminname.Text = "";
            txtboxusername.Text = "";
            txtboxpassword.Text = "";
            txtboxconfirm.Text = "";
            
        }
    }
}
