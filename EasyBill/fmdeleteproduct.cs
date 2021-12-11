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
    public partial class fmupdateproduct : Form
        
    {
        mydbConnection con = new mydbConnection();
        public fmupdateproduct()
        {
            InitializeComponent();
        }

        private void productEntryDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productEntryDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet2);

        }

        private void fmupdateproduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet2.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet2.ProductEntryDetails);

        }

        private void product_UnitLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "delete from ProductEntryDetails where [Product Id]='" + txtpid.Text+"'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Deleted");
            txtpid.Text = "";
txtpname.Text = "";
txtpcategory.Text = "";
txtpprice.Text = "";
txtpsprice.Text = "";
txtpunit.Text = "";
txtpuquantity.Text = "";
txtpquantity.Text = "";
txtpdescription.Text = "";
txtpdoe.Text = "";
txtpcompany.Text = "";
            
            txtpname.Focus();
            this.productEntryDetailsBindingSource.RemoveCurrent();
                
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            fmupdateproductdetails a = new fmupdateproductdetails();
            a.Show();
            this.Hide();
        }
    }
}
