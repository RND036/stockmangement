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
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtboxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Addadmin add = new Addadmin();
            add.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Do You Want To Quit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
              
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtboxusername.Text;
            password = txtboxpassword.Text;

            try
            {
                string query = "SELECT username,password FROM addadmin WHERE username ='" + txtboxusername.Text + "' AND password ='" + txtboxpassword.Text +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtboxusername.Text;
                    password = txtboxpassword.Text;
                    Main next = new Main();
                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxusername.Clear();
                    txtboxpassword.Clear();

                    txtboxusername.Focus(); // to focus on username

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void checkboxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxshowpassword.Checked)
            {
                txtboxpassword.PasswordChar = '\0';
            }
            else
            {
                txtboxpassword.PasswordChar = '*';
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtboxusername.Text;
            password = txtboxpassword.Text;

            try
            {
                string query = "SELECT username,password FROM addadmin WHERE username ='" + txtboxusername.Text + "' AND password ='" + txtboxpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtboxusername.Text;
                    password = txtboxpassword.Text;
                    Main next = new Main();
                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxusername.Clear();
                    txtboxpassword.Clear();

                    txtboxusername.Focus(); // to focus on username

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
