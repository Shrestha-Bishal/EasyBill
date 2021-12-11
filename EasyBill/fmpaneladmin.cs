using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBill
{
    public partial class fmpaneladmin : Form
    {
        public fmpaneladmin()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmaddadmin f1 = new fmaddadmin();
            f1.Show();
            //this.Hide();
        }

        private void btnadmindetails_Click(object sender, EventArgs e)
        {
            fmshowadmindetails f1 = new fmshowadmindetails();
            f1.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fmcashierdetails f1 = new fmcashierdetails();
            f1.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmaddcashier f1 = new fmaddcashier();
            f1.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            fmupdatedeletecashier f1 = new fmupdatedeletecashier();
            f1.Show();
            //this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmproductentry a = new fmproductentry();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmviewproduct a = new fmviewproduct();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fmupdateproduct a = new fmupdateproduct();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EasyBill: One Step Bill Calculations Portal\n Developed By:\n Bishal Shrestha\n Hari Thapa\n Biraj Poudel");
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmaddadmin f1 = new fmaddadmin();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fmdeleteadmin a = new fmdeleteadmin();
            a.Show();
        }

        private void viewAdminDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmshowadmindetails f1 = new fmshowadmindetails();
            f1.Show();
        }

        private void addCahsieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmaddcashier f1 = new fmaddcashier();
            f1.Show();
        }

        private void deleteUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmupdatedeletecashier f1 = new fmupdatedeletecashier();
            f1.Show();
        }

        private void viewProductDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewproduct a = new fmviewproduct();
            a.Show();
        }

        private void viewCashierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcashierdetails f1 = new fmcashierdetails();
            f1.Show();
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmproductentry a = new fmproductentry();
            a.Show();
        }

        private void deleteUpdateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmupdateproduct a = new fmupdateproduct();
            a.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmshowadmindetails f1 = new fmshowadmindetails();
            f1.Show();
        }

        private void cashierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmcashierdetails f1 = new fmcashierdetails();
            f1.Show();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewproduct a = new fmviewproduct();
            a.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us at facebook.com/easybillnepal");
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmaddcontacts a = new fmaddcontacts();
            a.Show();
        }

        private void viewContactsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmviewcontacts a = new fmviewcontacts();
            a.Show();
        }

        private void shippingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewshippingdetails a = new fmviewshippingdetails();
            a.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Close();
        }

        private void adminDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet1);

        }

        private void adminDetailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet1);

        }

        private void fmpaneladmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet1.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter.Fill(this.easyBillDatabaseDataSet1.AdminDetails);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            // this.textBox1.Text = string.Format("{0:##}:{1:##}:{2:##}");
            this.textBox1.Text = datetime.ToString();
            this.textBox1.Text = datetime.ToString("hh:mm:ss");
        }

        private void button10_Click(object sender, EventArgs e)
        {

            fmsaleSS a = new fmsaleSS();
            a.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fmsaleSS a = new fmsaleSS();
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void usOnFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bishal.stha09");
        }

        private void usOnInstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/bishal___/");
        }

        private void usToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/BishalSthaa");
        }

        private void admin_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            admin_IDTextBox.Text = "bishal";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fmviewshippingdetails a = new fmviewshippingdetails();
            a.Show();
        }
    }
}
