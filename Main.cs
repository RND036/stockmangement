using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockmanagementsystem
{
    public partial class Main : Form
    {
        formdashboard dashborad;
        formadditem additem;
        formitems items;
        formstocklevels stocklevels;
        formtransaction transaction;
        bool drag = false;
        Point start_point = new Point(0, 0);
       
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (dashborad == null) // check form created or not
            {
                dashborad = new formdashboard(); // if not create a form
                dashborad.FormClosed += dashborad_FormClosed; // add event handler for form close event
                dashborad.MdiParent = this;// set mdiparent to this form
                dashborad.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                dashborad.Show();
            }
            else
            {
                dashborad.Activate();
            }
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lblpost_Click(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            if(dashborad == null) // check form created or not
            {
                dashborad = new formdashboard(); // if not create a form
                dashborad.FormClosed += dashborad_FormClosed; // add event handler for form close event
                dashborad.MdiParent = this;// set mdiparent to this form
                dashborad.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                dashborad.Show();
            }
            else
            {
                dashborad.Activate();
            }
        }

        private void dashborad_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashborad = null;
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            if (additem == null) // check form created or not
            {
                additem = new formadditem(); // if not create a form
                additem.FormClosed += additem_FormClosed; // add event handler for form close event
                additem.MdiParent = this;// set mdiparent to this form
                additem.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                additem.Show();
            }
            else
            {
                additem.Activate();
            }
        }

        private void additem_FormClosed(object sender, FormClosedEventArgs e)
        {
            additem = null;
        }

        private void btnitems_Click(object sender, EventArgs e)
        {
            if(items==null)
            {
                items = new formitems(); // if not create a form
                items.FormClosed += items_FormClosed; // add event handler for form close event
                items.MdiParent = this;// set mdiparent to this form
                items.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                items.Show();
            }
            else
            {
                items.Activate();
            }
        }

        private void items_FormClosed(object sender, FormClosedEventArgs e)
        {
            items = null;
        }

        private void btnstocklevel_Click(object sender, EventArgs e)
        {
            
            if (stocklevels == null) // check form created or not
            {
                stocklevels = new formstocklevels(); // if not create a form
                stocklevels.FormClosed += stocklevels_FormClosed; // add event handler for form close event
                stocklevels.MdiParent = this;// set mdiparent to this form
                stocklevels.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                stocklevels.Show();
            }
            else
            {
                stocklevels.Activate();
            }

        }

        private void stocklevels_FormClosed(object sender, FormClosedEventArgs e)
        {
            stocklevels = null;
        }

        private void btntransactionlog_Click(object sender, EventArgs e)
        {
            if (transaction == null) // check form created or not
            {
                transaction = new formtransaction(); // if not create a form
                transaction.FormClosed += transaction_FormClosed; // add event handler for form close event
                transaction.MdiParent = this;// set mdiparent to this form
                transaction.Dock = DockStyle.Fill;// to fill the avalible space in parent element
                transaction.Show();
            }
            else
            {
                transaction.Activate();
            }
        }

        private void transaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            transaction = null;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Really Want To Quit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void piclogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure Do You Want To Logout?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login back = new login();
                back.Show();
                this.Close();
            }
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblclock.Text = DateTime.Now.ToString("T");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
