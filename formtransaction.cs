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
    public partial class formtransaction : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        SqlDataAdapter adpt;
        SqlDataAdapter Sgbt;
        DataTable dt;
        DataTable sld;
        
        public formtransaction()
        {
            InitializeComponent();
            showdata();
           
        }

        private void form_transaction(object sender, EventArgs e)
        {
            this.ControlBox = false;// hide control box from view
            showdata();
            
        }

        private void transactiongrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT * FROM items", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            Sgbt = new SqlDataAdapter("SELECT * FROM Deleted_item", conn);
            sld = new DataTable();
            Sgbt.Fill(sld);

            // Use two separate DataTable objects to store the data from each table
            transactiongrid1.DataSource = dt;
            transactiongrid2.DataSource = sld;
        }
        

        private void transactiongrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
