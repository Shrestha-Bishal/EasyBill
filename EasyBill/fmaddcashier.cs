using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EasyBill
{
    public partial class fmaddcashier : Form
    {
        mydbConnection con = new mydbConnection();
        public fmaddcashier()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "insert into CashierDetails ([Cashier First Name],[Cashier Last Name],Age,Address,[Mobile Number],[Cashier ID],Password,[Counter Number]) values(@cashierfname,@cashierlname,@age,@address,@mobile,@cashierid,@password,@counternumber)";
            cmd.Parameters.AddWithValue("@cashierfname", txtcfname.Text);
            cmd.Parameters.AddWithValue("@cashierlname", txtclname.Text);
            cmd.Parameters.AddWithValue("@age", txtcage.Text);
            cmd.Parameters.AddWithValue("@address", txtcaddress.Text);
            cmd.Parameters.AddWithValue("@mobile", txtcmono.Text);
            cmd.Parameters.AddWithValue("@cashierid", txtcid.Text);
            cmd.Parameters.AddWithValue("@password", txtcpwd.Text);
            cmd.Parameters.AddWithValue("@counternumber", txtccno.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Saved!");
            txtcfname.Text = "";
            txtclname.Text = "";
            txtcage.Text = "";
            txtcaddress.Text = "";
            txtcmono.Text = "";
            txtcid.Text = "";
            txtcpwd.Text = "";
            txtccno.Text = "";
            txtcfname.Focus();    
        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            /*fmpaneladmin f1 = new fmpaneladmin();
            f1.Show();
            this.Hide();*/
        }

        private void btnnewform_Click(object sender, EventArgs e)
        {
            txtcfname.Text = "";
            txtclname.Text = "";
            txtcage.Text = "";
            txtcaddress.Text = "";
            txtcmono.Text = "";
            txtcid.Text = "";
            txtcpwd.Text = "";
            txtccno.Text = "";
        }

        private void cashierDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cashierDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet);

        }

        private void fmaddcashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet.CashierDetails' table. You can move, or remove it, as needed.
            this.cashierDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet.CashierDetails);

        }
    }
}
