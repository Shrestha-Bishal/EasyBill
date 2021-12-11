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
    public partial class fmadminpanell : Form
    {
        mydbConnection con = new mydbConnection();
        public fmadminpanell()
        {
            InitializeComponent();
        }

        private void fmadminlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\EasyBill.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            String sqlstring = "SELECT * from AdminDetails where [Admin Id]='" + txtadminid.Text.Trim() + "'and Password='" + txtadminpwd.Text.Trim() + "'";
            SqlDataAdapter sda = con.DataAdapter(sqlstring);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            /*SqlDataAdapter sda = new SqlDataAdapter(sqlstring, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);                           */
            if (dt.Select().Length > 0)
            {
                fmpaneladmin f1 = new fmpaneladmin();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login Details!");
                txtadminid.Text = "";
                txtadminpwd.Text = "";
                txtadminid.Focus();

            }
       /*     fmpaneladmin f1 = new fmpaneladmin();
            f1.Show();
            this.Hide();*/

            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Password can only be recovered by our authorization\n Contact our HelpLine or  at www.facebook.com/easybillnepal");
        }
    }
}
