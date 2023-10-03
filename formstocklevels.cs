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

    public partial class formstocklevels : Form
    {
        public formstocklevels()
        {
            InitializeComponent();
            Fillcharts();

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
            chart1.Series["stocks"].XValueMember = "category";
            chart1.Series["stocks"].YValueMembers = "quantity";
            

        }

        private void form_stocklevels(object sender, EventArgs e)
        {
            this.ControlBox = false;// hide control box from view
            Fillcharts();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Fillcharts();
        }
    }
}
