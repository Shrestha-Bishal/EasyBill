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
    public partial class fmdeletesales : Form
    {
        mydbConnection con = new mydbConnection();
   /*     mydbConnection mycon;
        DataTable datatable;
        SqlDataAdapter sda;  */
        public fmdeletesales()
        {
           
            InitializeComponent();
        }
        private void Display_Data()
        {
    /*        mycon.OpenConection();
            DataTable dt = new DataTable();
            string sqlq = "select * from SalesEntry";
            salesEntryDataGridView.DataSource = mycon.ShowDataInGridView(sqlq);
            salesEntryDataGridView.DataSource = mycon.ShowDataInGridView(sqlq);
            mycon.CloseConnection();  */
        }  

        private void salesDatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesDatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet15);

        }

        private void fmdeletesales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet17.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter1.Fill(this.easyBillDatabaseEDataSet17.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet13.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter.Fill(this.easyBillDatabaseEDataSet13.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet15.SalesDatabase' table. You can move, or remove it, as needed.
            this.salesDatabaseTableAdapter.Fill(this.easyBillDatabaseEDataSet15.SalesDatabase);

        }

  /*      private void button1_Click(object sender, EventArgs e)
        {
     /*       mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE from SalesEntry where [Product Name]='" + txtpname.Text + "'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            Display_Data();  */


 /*           mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();
            cmd.CommandText = "delete from SalesEntry where [Product Name]='"+product_NameTextBox.Text+"'";
            con.ExecuteCommand(cmd);
            con.CloseConnection(); 
            this.salesEntryBindingSource.RemoveCurrent();
            Display_Data();
        }  */

        private void button2_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from SalesEntry where [Cashier First Name]='" + product_NameTextBox.Text + "'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Deleted");
            this.salesEntryBindingSource.RemoveCurrent();
        }
    }
}
