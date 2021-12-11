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
    public partial class fmproductentry : Form
    {
        mydbConnection con = new mydbConnection();
        public fmproductentry()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void productEntryDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productEntryDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet1);

        }

        private void fmproductentry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet2.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter1.Fill(this.easyBillDatabaseEDataSet2.ProductEntryDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet1.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet1.ProductEntryDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
          
            cmd.CommandText = "insert into ProductEntryDetails ([Product Id],[Product Name],[Product Category],[Product Price],Price,[Product Unit],[Unit Quantity],[Product Quantity],[Product Description],[Date of Entry],[Product Company]) values(@pid,@pname,@pc,@pp,@p,@pu,@uq,@pq,@pd,@dof,@pcc)";
            cmd.Parameters.AddWithValue("@pid", txtpdid.Text);
            cmd.Parameters.AddWithValue("@pname", txtpdname.Text);
            cmd.Parameters.AddWithValue("@pc", txtpdcategory.Text);
            cmd.Parameters.AddWithValue("@pp", txtpdppr.Text);
            cmd.Parameters.AddWithValue("@p", txtpdsp.Text);
            cmd.Parameters.AddWithValue("@pu", txtpdunit.Text);
            cmd.Parameters.AddWithValue("@uq", txtpdqu.Text);
            cmd.Parameters.AddWithValue("@pq", txtpdpqu.Text);
            cmd.Parameters.AddWithValue("@pd", txtpddes.Text);
            cmd.Parameters.AddWithValue("@dof", txtpd.Text);
            cmd.Parameters.AddWithValue("@pcc", txtpdcom.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Product Saved!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpdid.Text = "";
            txtpdname.Text = "";
            txtpdcategory.Text = "";
            txtpdppr.Text = "";
            txtpdsp.Text = "";
            txtpdunit.Text = "";
            txtpdqu.Text = "";
            txtpdpqu.Text = "";
            txtpddes.Text = "";
            txtpd.Text = "";
            txtpdcom.Text = "";
        }

        private void txtpdqu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtpdpqu.Text = (float.Parse(txtpdqu.Text) * float.Parse(txtpdunit.Text)).ToString();
            }
            catch
            { }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           this.txtpd.Text = datetime.ToString();
           this.txtpd.Text = datetime.ToString("dd:m:yyyy");
        }
    }
}
