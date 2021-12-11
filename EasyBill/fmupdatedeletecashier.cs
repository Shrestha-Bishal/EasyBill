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
    public partial class fmupdatedeletecashier : Form
    {
        mydbConnection con = new mydbConnection();
        mydbConnection mycon;
        public fmupdatedeletecashier()
        {
            InitializeComponent();
            mycon = new mydbConnection();
           // DisplayData();
        }
        
        private void cashierDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cashierDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet);

        }

        private void fmupdatedeletecashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet.CashierDetails' table. You can move, or remove it, as needed.
            this.cashierDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet.CashierDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmpaneladmin a = new fmpaneladmin();
            a.Show();
            this.Hide();
        }

        private void btndeletecashier_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "delete from CashierDetails where [Cashier First Name]='" + txtcfname.Text + "'"; //(,[Cashier Last Name],Age,Address,[Mobile Number],[Cashier ID],Password,[Counter Number]) values(@cashierfname,@cashierlname,@age,@address,@mobile,@cashierid,@password,@counternumber)";
            /*cmd.Parameters.AddWithValue("@cashierfname", txtcfname.Text);
            cmd.Parameters.AddWithValue("@cashierlname", txtclname.Text);
            cmd.Parameters.AddWithValue("@age", txtcage.Text);
            cmd.Parameters.AddWithValue("@address", txtcaddress.Text);
            cmd.Parameters.AddWithValue("@mobile", txtcmono.Text);
            cmd.Parameters.AddWithValue("@cashierid", txtcid.Text);
            cmd.Parameters.AddWithValue("@password", txtcpwd.Text);
            cmd.Parameters.AddWithValue("@counternumber", txtccno.Text);*/

            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Deleted");
            txtcfname.Text = "";
            txtclname.Text = "";
            txtcage.Text = "";
            txtcmono.Text = "";
            txtcid.Text = "";
            txtcid.Text = "";
            txtcpwd.Text = "";
            txtccno.Text = "";
            txtcfname.Focus();
            this.cashierDetailsBindingSource.RemoveCurrent();
        }

        private void btnupdatecashier_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            if (txtcfname.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                //DataTable dt = new DataTable();

                //    cmd.CommandText = "update CashierDetails set [Cashier First Name]='" + txtcfnamechanged.Text+"' where [Cashier First Name]+'" + txtcfname.Text + "'"; //(,[Cashier Last Name],Age,Address,[Mobile Number],[Cashier ID],Password,[Counter Number]) values(@cashierfname,@cashierlname,@age,@address,@mobile,@cashierid,@password,@counternumber)";
                cmd.CommandText = "update CashierDetails set [Cashier Last Name]=@cashierlname,Age=@age,Address=@address,[Mobile Number]=@mobile,[Cashier ID]=@cashierid,Password=@password,[Counter Number]=@counternumber where [Cashier First Name]=@cashierfname";

                cmd.Parameters.AddWithValue("@cashierlname", txtclname.Text);
                cmd.Parameters.AddWithValue("@age", txtcage.Text);
                cmd.Parameters.AddWithValue("@address", txtcaddress.Text);
                cmd.Parameters.AddWithValue("@mobile", txtcmono.Text);
                cmd.Parameters.AddWithValue("@cashierid", txtcid.Text);
                cmd.Parameters.AddWithValue("@password", txtcpwd.Text);
                cmd.Parameters.AddWithValue("@counternumber", txtccno.Text);
                cmd.Parameters.AddWithValue("@cashierfname", txtcfname.Text);
                con.OpenConection();
                con.ExecuteCommand(cmd);
                con.CloseConnection();
                MessageBox.Show("Updated");
                
                //DisplayData();
                

                // cmd.Parameters.AddWithValue("@cashierfname", txtcfname.Text);
                /* this.Validate();
                 this.cashierDetailsBindingSource.EndEdit();
                 this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet6);*/
            }
            else
            {
                MessageBox.Show("Key value can't be blank");

            }
            
        }
    }
}
