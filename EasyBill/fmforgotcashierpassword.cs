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
    public partial class fmforgotcashierpassword : Form
    {
        mydbConnection con = new mydbConnection();
        public fmforgotcashierpassword()
        {
            InitializeComponent();
        }

        private void forgotcashieridBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.forgotcashieridBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet16);

        }

        private void fmforgotcashierpassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet16.Forgotcashierid' table. You can move, or remove it, as needed.
            this.forgotcashieridTableAdapter.Fill(this.easyBillDatabaseEDataSet16.Forgotcashierid);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insert into Forgotcashierid ([Cashier First Name],[Cashier Last Name],[Cashier Id]) values(@a,@b,@c)";
                cmd.Parameters.AddWithValue("@a", cashier_First_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@b", cashier_Last_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@c", cashier_IdTextBox.Text);
                con.OpenConection();
                con.ExecuteCommand(cmd);
                con.CloseConnection();
                MessageBox.Show("Requested to Admin");
            
            cashier_First_NameTextBox.Text="";
                cashier_Last_NameTextBox.Text="";
                    cashier_IdTextBox.Text="";
                    cashier_First_NameTextBox.Focus();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashier_First_NameTextBox.Text = "";
            cashier_Last_NameTextBox.Text = "";
            cashier_IdTextBox.Text = "";
            cashier_First_NameTextBox.Focus();
        }
    }
}
