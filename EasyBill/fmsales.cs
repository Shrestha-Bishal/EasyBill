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
    public partial class fmsales : Form
    {
        mydbConnection con = new mydbConnection();
        public fmsales()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet14);

        }

        private void fmsalesentry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet14.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.easyBillDatabaseEDataSet14.Sales);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
          /*  cmd.CommandText = "insert into Sales ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount],Cashier,Date,Time) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
            cmd.Parameters.AddWithValue("@a", product_NameTextBox.Text);
            cmd.Parameters.AddWithValue("@b", product_CategoryTextBox.Text);
            cmd.Parameters.AddWithValue("@c", rateTextBox.Text);
            cmd.Parameters.AddWithValue("@d", quantityTextBox.Text);
            cmd.Parameters.AddWithValue("@e", product_TotalTextBox.Text);
            cmd.Parameters.AddWithValue("@f", vatTextBox.Text);
            cmd.Parameters.AddWithValue("@g", discountTextBox.Text);
            cmd.Parameters.AddWithValue("@h", total_AmountTextBox.Text);

            cmd.Parameters.AddWithValue("@i", total_AmountTextBox.Text);
            cmd.Parameters.AddWithValue("@j", dateTextBox.Text);
          //  cmd.Parameters.AddWithValue("@j", dateTimePicker1.Value.ToString("M/d/yyyy"));
            cmd.Parameters.AddWithValue("@k", timeTextBox.Text);   */
            cmd.CommandText = "insert into Sales ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount],Cashier,Date,Time) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)";
            cmd.Parameters.AddWithValue("@a", "GrandTotal");
            cmd.Parameters.AddWithValue("@b", "a");//txtpcat.Text);
            cmd.Parameters.AddWithValue("@c", "a");// txtpprate.Text);
            cmd.Parameters.AddWithValue("@d", "a");// txtppqu.Text);
            cmd.Parameters.AddWithValue("@e", "a");//txtptot.Text);
            cmd.Parameters.AddWithValue("@f", "a");//tztpra.Text);
            cmd.Parameters.AddWithValue("@g", "a");//txtpq.Text);
            cmd.Parameters.AddWithValue("@h", "a");//txtttl.Text);
            cmd.Parameters.AddWithValue("@i", "c");
            cmd.Parameters.AddWithValue("@j", "b");
            cmd.Parameters.AddWithValue("@k", "a");
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            
           
        }
    }
}
