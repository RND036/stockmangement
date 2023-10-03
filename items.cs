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
    public partial class formitems : Form
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        SqlDataAdapter adpt;
        DataTable dt;

        public formitems()
        {
            InitializeComponent();
            showdata();



        }

        private void form_items(object sender, EventArgs e)
        {
            this.ControlBox = false;// hide control box from view
            showdata();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            {
                showdata();
                try
                {
                    if (txtboxproductnameitems.Text == "" || txtboxquantityitems.Text == "" || txtboxstockcodeitems.Text == "")
                    {
                        MessageBox.Show("Select Item Want To Update", "Item Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string savedate = DateTime.Now.ToString("yyyy-MM-dd");
                        string savetime = DateTime.Now.ToString("HH:mm:ss ");
                        string changed = "Stock Changed";
                        string category = combocategory.SelectedItem.ToString();

                        string sql = "UPDATE items SET stockname='" + txtboxproductnameitems.Text + "', quantity='" + txtboxquantityitems.Text + "', category='" + category + "', date='" + savedate + "', time='" + savetime + "', status='" + changed + "' WHERE stockcode='" + txtboxstockcodeitems.Text + "'";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item Updated Successfully!", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showdata();
                        }
                        else
                        {
                            MessageBox.Show("Item with stock code '" + txtboxstockcodeitems.Text + "' not found.", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtboxproductnameitems.Text == "" || txtboxquantityitems.Text == "" || txtboxstockcodeitems.Text == "")
                {
                    MessageBox.Show("Select Item Want To Delete", "Item Deleting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DialogResult error = MessageBox.Show("Do you need to delete this Item", "Stock Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (error == DialogResult.Yes)
                    {
                        string savedate = DateTime.Now.ToString("yyyy-MM-dd");
                        string savetime = DateTime.Now.ToString("HH:mm:ss");
                        string deleted = "Stock Deleted";
                        string category = combocategory.SelectedItem.ToString();

                        string sql = "DELETE items WHERE stockcode='" + txtboxstockcodeitems.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Successfully deleted", "Stock Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showdata();
                        string insertSql = "INSERT INTO Deleted_item (StockCode, StockName, Quantity, Category, Date, Time, Status) VALUES ('" + txtboxstockcodeitems.Text + "','" + txtboxproductnameitems.Text + "', '" + txtboxquantityitems.Text + "','"+category+"','" + savedate + "', '" + savetime + "','" + deleted + "')";

                        SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                        insertCmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            itemgrid.DataSource = dt;
        }
        int key = 0;
        private void itemgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtboxstockcodeitems.Text = itemgrid.SelectedRows[0].Cells[0].Value.ToString();
                txtboxproductnameitems.Text = itemgrid.SelectedRows[0].Cells[1].Value.ToString();
                txtboxquantityitems.Text = itemgrid.SelectedRows[0].Cells[2].Value.ToString();
                combocategory.SelectedItem = itemgrid.SelectedRows[0].Cells[3].Value.ToString();
                if (txtboxstockcodeitems.Text == "")
                {
                    key = 0;
                }
                else
                {
                key = Convert.ToInt32(itemgrid.SelectedRows[0].Cells[0].Value.ToString());
                   
                }

            showdata();
        }

        private void lblstockcode_Click(object sender, EventArgs e)
        {

        }
    }
}
