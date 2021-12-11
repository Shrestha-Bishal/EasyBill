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
    public partial class fmcashierlogin : Form
    {
        
        mydbConnection con = new mydbConnection();
        public fmcashierlogin()
        {
            InitializeComponent();
        }

        private void btneasybill_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             con.OpenConection();
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\EasyBill.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            String sqlstring = "SELECT * from CashierDetails where [Cashier ID]='"+txtcashierid.Text.Trim()+"'and Password='"+txtcashierpwd.Text.Trim()+"'";
            SqlDataAdapter sda = con.DataAdapter(sqlstring);
            DataTable dt = new DataTable();
            sda.Fill(dt); 
            /*SqlDataAdapter sda = new SqlDataAdapter(sqlstring, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);*/
            if (dt.Select().Length > 0)
            {
                fmpanelcashier f1 = new fmpanelcashier();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Details!");
                txtcashierid.Text = "";
                txtcashierpwd.Text = "";
                txtcashierid.Focus();
                
            }           
            
       /*     fmpanelcashier f1 = new fmpanelcashier(); //optional already entered above
            f1.Show();
            this.Hide();*/
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fmforgotcashierpassword a = new fmforgotcashierpassword();
            a.Show();
            this.Hide();
        }
   }
}
