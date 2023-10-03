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
    public partial class formdashboard : Form
    {
        public formdashboard()
        {
            InitializeComponent();
            Fillcharts();
            Fill2charts();
            users();
        }
        void Fillcharts()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT category,quantity FROM items", conn);
            da.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();
            chart1.Series["items"].XValueMember = "category";
            chart1.Series["items"].YValueMembers = "quantity";
            

        }
        void Fill2charts()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
            DataTable dt = new DataTable();
            conn.Open();

            
            SqlDataAdapter da = new SqlDataAdapter("SELECT MONTH(date) AS month, quantity FROM items ORDER BY month", conn);

            da.Fill(dt);
            conn.Close();

            chart2.DataSource = dt;
            chart2.Series["sales"].XValueMember = "month"; 
            chart2.Series["sales"].YValueMembers = "quantity";

            

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_dashboard(object sender, EventArgs e)
        {
            this.ControlBox = false;// hide control box from view
            lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            timer1.Start();
            Fillcharts();
            Fill2charts();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("T");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        void users()
        {
           
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
            SqlCommand cmd;

            //create a command
            string query = "SELECT COUNT(admin_id) FROM addadmin";


            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);

                //read from db
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblusers.Text =  rows_count.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
