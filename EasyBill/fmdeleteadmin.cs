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
    public partial class fmdeleteadmin : Form
    {
        mydbConnection con = new mydbConnection();
        public fmdeleteadmin()
        {
            InitializeComponent();
        }

        private void adminDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet6);

        }

        private void fmdeleteadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet6.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet6.AdminDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "delete from AdminDetails where [Admin First Name]='" +txtafname.Text+ "'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Deleted!");
            txtafname.Text="";
                txtalname.Text="";
                txtaage.Text="";
                    txtaaddress.Text="";
                    txtamo.Text="";
                        txtaid.Text="";
                        txtapw.Text = "";
            this.adminDetailsBindingSource.RemoveCurrent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
