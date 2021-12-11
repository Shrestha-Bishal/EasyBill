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
    public partial class fmaddcontacts : Form
    {
        mydbConnection con = new mydbConnection();
        public fmaddcontacts()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet5);

        }

        private void fmaddcontacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet5.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.easyBillDatabaseEDataSet5.Contacts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "insert into Contacts ([First Name],[MIddle Name],[Last Name],Products,Company,[Phone Number],[Mobile Number 1],[Mobile Number 2],Address,City,Country,Email) values(@fname,@mname,@lname,@p,@c,@pn,@mn,@mnn,@a,@cc,@ccc,@e)";
            cmd.Parameters.AddWithValue("@fname",  txtfname.Text);
            cmd.Parameters.AddWithValue("@mname",txtmname.Text);
            cmd.Parameters.AddWithValue("@lname",  txtlname.Text);
            cmd.Parameters.AddWithValue("@p", txtproducts.Text);
            cmd.Parameters.AddWithValue("@c", txtcompany.Text);
            cmd.Parameters.AddWithValue("@pn", txtphno.Text);
            cmd.Parameters.AddWithValue("@mn", txtmo.Text );
            cmd.Parameters.AddWithValue("@mnn", txtmono.Text );
            cmd.Parameters.AddWithValue("@a", txtaddress.Text);
            cmd.Parameters.AddWithValue("@cc", txtcity.Text);
            cmd.Parameters.AddWithValue("@ccc", txtcountry.Text);
            cmd.Parameters.AddWithValue("@e", txtemail.Text );
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Saved!");

            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtproducts.Text = "";
            txtcompany.Text = "";
            txtphno.Text = "";
            txtmo.Text = "";
            txtmono.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";
            txtemail.Text = "";
            txtfname.Focus();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Text="";
                txtmname.Text="";
                txtlname.Text="";
                    txtproducts.Text="";
                    txtcompany.Text="";
                        txtphno.Text="";
                        txtmo.Text="";
                            txtmono.Text="";
                            txtaddress.Text="";
                                txtcity.Text="";
                                txtcountry.Text="";
                                txtemail.Text = "";
        }
    }
}
