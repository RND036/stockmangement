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
    
    public partial class formadditem : Form
    {
       
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        SqlDataAdapter adpt;
        DataTable dt;
        public formadditem()
        {
            InitializeComponent();
            showdata();
        }

        private void formadditem_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            showdata();
            try
            {
                if (txtboxstockcode.Text == "" || txtboxproductname.Text == "" || txtboxquantity.Text == "" || combocategory.SelectedItem == "")
                {
                    MessageBox.Show("Fields Are Empty", "Item Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string savedate = DateTime.Now.ToString("yyyy-MM-dd");
                    string savetime = DateTime.Now.ToString("HH:mm:ss ");
                    string category = combocategory.SelectedItem.ToString();

                    string sql = "INSERT INTO items (stockcode, stockname, quantity, category, date, time)VALUES(" + txtboxstockcode.Text + ", '" + txtboxproductname.Text + "', '" + txtboxquantity.Text + "','" +category+"','" + savedate + "','" + savetime +"')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Added Successfully! ", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    showdata();

                }
}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
               
        }
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT stockcode,stockname,quantity,category FROM items", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            datagrid.DataSource = dt;
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
