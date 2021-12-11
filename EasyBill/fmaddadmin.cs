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
    public partial class fmaddadmin : Form
    {
        mydbConnection con = new mydbConnection();
        public fmaddadmin()
        {
            InitializeComponent();
        }

        private void adminDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet);

        }

        private void fmaddadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter.Fill(this.easyBillDatabaseDataSet.AdminDetails);

        }

        private void btnSaveadmindetails_Click(object sender, EventArgs e)
        {

            //string Query = "insert into Adminlogindetails(Admin Name,Address,Mobile number,Aid,Apassword) values('"+this.txtadminname.Text+"','"+this.txtadminaddress.Text+"','"+this.txtadminmobile.Text+"','"+this.txtaid.Text+"','"+this.txtapassword.Text+"');";
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
           // DataTable dt = new DataTable();
            cmd.CommandText = "insert into AdminDetails ([Admin First Name],[Admin Last Name],Age,Address,[Mobile Number],[Admin Id],Password) values(@adminfname,@adminlname,@age,@address,@mobile,@aid,@Apassword)";
            cmd.Parameters.AddWithValue("@adminfname", txtafname.Text);
            cmd.Parameters.AddWithValue("@adminlname", txtalname.Text);
            cmd.Parameters.AddWithValue("@age", txtaage.Text);
            cmd.Parameters.AddWithValue("@address", txtaaddress.Text);
            cmd.Parameters.AddWithValue("@mobile", txtamono.Text);
            cmd.Parameters.AddWithValue("@aid", txtaid.Text);
            cmd.Parameters.AddWithValue("@Apassword", txtapwd.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Saved!");
            txtafname.Text= "";
                txtalname.Text= "";
                    txtaage.Text= "";
                        txtaaddress.Text= "";
                            txtamono.Text= "";
                                txtaid.Text= "";
                                txtapwd.Text = "";
        }

        private void btnadminmainmenu_Click(object sender, EventArgs e)
        {
            fmpaneladmin f1 = new fmpaneladmin();
            f1.Show();
            this.Hide();
        }

        private void btnViewadminDetails_Click(object sender, EventArgs e)
        {
            txtafname.Text = "";
            txtalname.Text = "";
            txtaage.Text = "";
            txtaaddress.Text = "";
            txtamono.Text = "";
            txtaid.Text = "";
            txtapwd.Text = "";
        }
    }
}