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
    public partial class Form2 : Form
    {
        mydbConnection con = new mydbConnection();
        mydbConnection mycon;
        public Form2()
        {
            InitializeComponent();
            mycon = new mydbConnection();
        }

        private void salesEntryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesEntryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet18);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet18.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter.Fill(this.easyBillDatabaseEDataSet18.SalesEntry);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from SalesEntry where [Product Name]='"+product_NameTextBox.Text+"'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();


            product_NameTextBox.Text = "";
                    product_CategoryTextBox.Text="";
                rateTextBox.Text="";
                    quantityTextBox.Text="";
                    product_TotalTextBox.Text="";
                        vatTextBox.Text="";
                        discountTextBox.Text="";
                            total_AmountTextBox.Text="";
                            product_NameTextBox.Focus();
         //   MessageBox.Show("Deleted");
            this.salesEntryBindingSource.RemoveCurrent();
        }
    }
}
