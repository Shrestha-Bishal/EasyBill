using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using PagedList;

//using System.Data.OleDb;



namespace EasyBill
{
    public partial class fmpanelcashier : Form
    {
        mydbConnection con = new mydbConnection();
        mydbConnection mycon;
        DataTable datatable;
        SqlDataAdapter sda;
        //
        /*      string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["dsn"];
              OleDbCommand com;
              OleDbDataAdapter olebda;
              DataSet ds;
              string str; */
        public fmpanelcashier()
        {
            InitializeComponent();
            mycon = new mydbConnection();
            Display_Data();
            DisplayData();
            timer1.Start();
        }
        private void Display_Data()
        {
            mycon.OpenConection();
            DataTable dt = new DataTable();
            string sqlq = "select * from SalesEntry";
            dataGridView6.DataSource = mycon.ShowDataInGridView(sqlq);
            dataGridView8.DataSource = mycon.ShowDataInGridView(sqlq);
            mycon.CloseConnection();
        }

        private void DisplayData()
        {
            con.OpenConection();
            datatable = new DataTable();
            sda = new SqlDataAdapter();
            sda = con.DataAdapter("Select * from ProductEntryDetails");
            sda.Fill(datatable);
            dataGridView5.DataSource = datatable;
        }

        private void btncashierlogout_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Close();
        }

        private void BtnBilling_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fmviewproduct a = new fmviewproduct();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnewshipping_Click(object sender, EventArgs e)
        {
            fmnewshipping a = new fmnewshipping();
            a.Show();
        }

        private void btnviewshipping_Click(object sender, EventArgs e)
        {
            fmviewshippingdetails a = new fmviewshippingdetails();
            a.Show();
        }

        private void productEntryDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productEntryDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet4);

        }

        private void fmpanelcashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet18.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter3.Fill(this.easyBillDatabaseEDataSet18.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet10.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter2.Fill(this.easyBillDatabaseEDataSet10.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet.CashierDetails' table. You can move, or remove it, as needed.
            this.cashierDetailsTableAdapter1.Fill(this.easyBillDatabaseEDataSet.CashierDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet14.Sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter1.Fill(this.easyBillDatabaseEDataSet14.Sales);
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet7.CashierDetails' table. You can move, or remove it, as needed.
            this.cashierDetailsTableAdapter.Fill(this.easyBillDatabaseDataSet7.CashierDetails);
            disp_data();
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet13.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter1.Fill(this.easyBillDatabaseEDataSet13.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet11.SalesEntry' table. You can move, or remove it, as needed.
            this.salesEntryTableAdapter.Fill(this.easyBillDatabaseEDataSet11.SalesEntry);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet9.Sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.easyBillDatabaseEDataSet9.Sales);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet8.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter2.Fill(this.easyBillDatabaseEDataSet8.ProductEntryDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet7.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter1.Fill(this.easyBillDatabaseEDataSet7.ProductEntryDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet4.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet4.ProductEntryDetails);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtproductid_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(datatable);

            dv.RowFilter = string.Format("[Product Name] LIKE '%{0}%'", txtproductsearch.Text);
            // productEntryDetailsDataGridView.DataSource = dv;
            
            dataGridView7.DataSource = dv;




            /*DataView Dv = new DataView(con);
            Dv.RowFilter = string.Format("[Product Id] LIKE '%{0}%'", txtproductid.Text);
        tabbilling.*/
            /* DataTable dt = new DataTable();
             SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM ProductEntryDetails where [Product Id]" + int.Parse(txtproductid.Text), con);
             SDA.Fill(dt);
             tabbilling.DataSource = dt;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();

            txtpname.Text = txtprodductname.Text;
            txtpcat.Text = product_CategoryTextBox.Text;
            txtpprate.Text = txtprate.Text;
            txtppqu.Text = txtpquantity.Text;
            txtptot.Text = txtpproducttotal.Text;
            tztpra.Text = txtvat.Text;
            txtpq.Text = txtdiscount.Text;
            txtttl.Text = txttotalamount.Text;

 /*          if (product_IdTextBox.Text != "")
          {
                SqlCommand c = new SqlCommand();
                textBox2.Text = (float.Parse(txtinventory.Text) - float.Parse(txtpquantity.Text)).ToString();
                c.CommandText = "update ProductEntryDetails set ([Product Name]=@pname,[Product Category]=@pc,[Product Price]=@pp,Price=@p,[Product Unit]=@pu,[Unit Quantity]=@uq,[Product Quantity]=@pq,[Product Description]=@pd,[Date of Entry]=@dof,[Product Company]=@pcc where [Product Id]=@pid)";
           //     c.Parameters.AddWithValue("@pname", txtprodductname.Text);
           //     c.Parameters.AddWithValue("@pc", product_CategoryTextBox.Text);
             //   c.Parameters.AddWithValue("@pp", product_CategoryTextBox.Text);
             //  c.Parameters.AddWithValue("@p", txtprodductname.Text);
             //  c.Parameters.AddWithValue("@pu", txtprodductname.Text);
            //   c.Parameters.AddWithValue("@uq", txtprodductname.Text);
               c.Parameters.AddWithValue("@pq", textBox2.Text);
              // c.Parameters.AddWithValue("@pd", txtprodductname.Text);
              //  cmd.Parameters.AddWithValue("@pp", textBox2.Text);
              //  c.Parameters.AddWithValue("@dof", txtprate.Text);
             //   c.Parameters.AddWithValue("@pcc", textBox2.Text);

                c.Parameters.AddWithValue("@pid", product_IdTextBox.Text);
                con.OpenConection();
                con.ExecuteCommand(c);
                con.CloseConnection();
            }
           else
           {
               MessageBox.Show("Key value can't be blank");

           }
            */
            cmd.CommandText = "insert into SalesEntry ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@a,@b,@c,@d,@e,@f,@g,@h)";
            cmd.Parameters.AddWithValue("@a", txtpname.Text);
            cmd.Parameters.AddWithValue("@b", txtpcat.Text);
            cmd.Parameters.AddWithValue("@c", txtpprate.Text);
            cmd.Parameters.AddWithValue("@d", txtppqu.Text);
            cmd.Parameters.AddWithValue("@e", txtptot.Text);
            cmd.Parameters.AddWithValue("@f", tztpra.Text);
            cmd.Parameters.AddWithValue("@g", txtpq.Text);
            cmd.Parameters.AddWithValue("@h", txtttl.Text);
            con.OpenConection();
           con.ExecuteCommand(cmd);
           con.CloseConnection();
           Display_Data();


           cmd.CommandText = "insert into SalesDatabase (Date,Time,Cashier,[Sales No],[Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@q,@r,@s,@z,@i,@j,@k,@l,@m,@n,@o,@p)";
           cmd.Parameters.AddWithValue("@q", dateTimePicker1.Value);
           cmd.Parameters.AddWithValue("@r", this.textBox1.Text);
           cmd.Parameters.AddWithValue("@s", cashier_IdTextBox.Text);
           cmd.Parameters.AddWithValue("@z", txtsaleno.Text);
            cmd.Parameters.AddWithValue("@i", txtpname.Text);
            cmd.Parameters.AddWithValue("@j", txtpcat.Text);//txtpcat.Text);
            cmd.Parameters.AddWithValue("@k", txtpprate.Text);// txtpprate.Text);
            cmd.Parameters.AddWithValue("@l", txtppqu.Text);// txtppqu.Text);
            cmd.Parameters.AddWithValue("@m", txtptot.Text);//txtptot.Text);
            cmd.Parameters.AddWithValue("@n", tztpra.Text);//tztpra.Text);
            cmd.Parameters.AddWithValue("@o", txtpq.Text);//txtpq.Text);
            cmd.Parameters.AddWithValue("@p", txtttl.Text);//txtttl.Text);

            con.OpenConection();
           con.ExecuteCommand(cmd);
            con.CloseConnection();
           
            txtproductsearch.Text = "";
            txtprodductname.Text = "";
            product_IdTextBox.Text = "";
            txtsaleno.Text = "";
            product_CategoryTextBox.Text = "";
            txtprate.Text = "";
            txtpquantity.Text = "";
            txtpproducttotal.Text = "";

            // DataTable dt = new DataTable();
            //    SqlConnection b = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Bishal\Documents\EasyBillDatabaseE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");




            //    SqlCommand a = new SqlCommand("insert into Sales (Date) values ('" + dateTimePicker1.Value.ToString("M/d/yyyy") + "')", b);

            /*      con.OpenConection();
                  con.ExecuteCommand(cmd);
                  con.CloseConnection();      */

            //        fmsales a = new fmsales();
            //     a.Show();



            //    }
            /* SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"C:\Users\Bishal\Documents\EasyBillDatabaseE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
//SqlConnection con = new SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Bishal\Documents\EasyBillDatabaseE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
DataTable dt = new DataTable();
SqlDataAdapter SDA = new SqlDataAdapter("SELECT FROM ProductEntryDetails where Product Id like" + txtproductid.Text, con);
SDA.Fill(dt);
dataGridView3.DataSource=dt;
mydbConnection con = new mydbConnection();
SqlCommand cmd = new SqlCommand();
cmd.CommandText ="SELECT FROM ProductEntryDetails where Product Id like"' + txtproductid.Text+"'";*/
            //con.OpenConection();
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\EasyBill.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
            //String sqlstring = "SELECT * from ProductEntryDetails where [Product Id]='" + txtproductname.Text.Trim() + "'";//and Password='"+txtcashierpwd.Text.Trim()+"'";
            //SqlDataAdapter sda = con.DataAdapter(sqlstring);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            /*SqlDataAdapter sda = new SqlDataAdapter(sqlstring, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);*/
            /*if (dt.Select().Length > 0)
            {
                fmpanelcashier f1 = new fmpanelcashier();
                f1.Show();
                this.Hide();*/
            //  {
            /* DataView dv = new DataView(datatable);
             dv.RowFilter = string.Format("[Product Name] LIKE '%{0}%'", txtproductsearch.Text);
             //productEntryDetailsDataGridView1.DataSource = dv;
             //dataGridView6.DataSource = dv;*/
            /*               
                           //MessageBox.Show("Saved!");
                           //txttotall.Text = (float.Parse(txtpproducttotal.Text)).ToString();


                           //txttotall.Text = (float.Parse(txttotall.Text) + float.Parse(txtpproducttotal.Text)).ToString();
                           // txttotall.Text = (float.Parse(txttotall.Text) - float.Parse(txtpproducttotal.Text)).ToString();
                           /*       if (sender == btnreset)
                                  { }
                                  else
                                  {
                                  txttotall.Text = (float.Parse(txtpproducttotal.Text)+ float.Parse(txtpproducttotal.Text)).ToString();

                                  txtproductname.Text = "";
                                  txtprate.Text = "";
                                  txtpquantity.Text = "";
                                  txtpproducttotal.Text = "";*/
            /*          float a = float.Parse(txtnoitems.Text);


                      for (int i = 1; i < a; i++)
                      {
                          float sum = (float.Parse(txtpproducttotal.Text) + a);
                          txttotall.Text = sum.ToString();
                          a++;
                          txtproductsearch.Text = "";
                          txtprate.Text = "";
                          txtpquantity.Text = "";
                          txtpproducttotal.Text = "";
                      }
                  }                 */

        }
        public void disp_data()
        {

            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            //SqlCommand cmd = con();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SalesEntry";
            con.ExecuteCommand(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            con.CloseConnection();




        }

        private void chkvat_CheckedChanged(object sender, EventArgs e)
        {


            txtdiscount.Enabled = true;
            txtdiscount.Focus();
        }

        private void txtpproducttotal_TextChanged(object sender, EventArgs e)
        {
            //txtpproducttotal.Text = txttotall.Text;
        }

        private void txtpquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtpproducttotal.Text = (float.Parse(txtprate.Text) * float.Parse(txtpquantity.Text)).ToString();
            }
            catch { }
        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {
            float i = float.Parse(txtvat.Text);
            //i = 13;
            float a = float.Parse(txttotall.Text);
            i = i / 100;
            float b = i * a;
            txtvatequals.Text = (float.Parse(txttotall.Text) + b).ToString();
            /* try
             {
                     float i = float.Parse(txtvat.Text);
                     i = 13;
                     float a = float.Parse(txttotall.Text);
                     i = i / 100;
                     float b = i * a;
                     txtvatequals.Text = (float.Parse(txttotall.Text) + b).ToString();
                /* float i = float.Parse(txtvat.Text);
                 i = 13;
                 if (i >= 13 || i<=13)
                 {
                     float a = float.Parse(txttotall.Text);
                     i = i / 100;
                     float b = i * a;
                     txtvatequals.Text = (float.Parse(txttotall.Text) + b).ToString();
                    
                 }

                 else
                 {
                     //float i = float.Parse(txtvat.Text);
                     float a = float.Parse(txttotall.Text);
                     i = 13 / 100;
                     float b = i * a;
                     //i = float.Parse(txtvat.Text);
                     txtvatequals.Text = (float.Parse(txttotall.Text) + b).ToString();
                    
                 }*/


            // catch { }*/


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtvatequals_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttotalamount.Text = (float.Parse(txtvatequals.Text)).ToString();
            }
            catch { }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txttotalamount.Text = (float.Parse(txtvatequals.Text) - float.Parse(txtdiscount.Text)).ToString();
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtreset_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into SalesDatabase (Date,Time,Cashier,[Sales No],[Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@q,@r,@s,@i,@j,@k,@l,@m,@n,@o,@p,@t)";
            cmd.Parameters.AddWithValue("@q", "#");
            cmd.Parameters.AddWithValue("@r", "#");
            cmd.Parameters.AddWithValue("@s", "#");
            cmd.Parameters.AddWithValue("@i", "#");
            cmd.Parameters.AddWithValue("@j", "#");
            cmd.Parameters.AddWithValue("@k", "#");
            cmd.Parameters.AddWithValue("@l", "#");
            cmd.Parameters.AddWithValue("@m", "#");
            cmd.Parameters.AddWithValue("@n", "#");
            cmd.Parameters.AddWithValue("@o", "#");
            cmd.Parameters.AddWithValue("@p", "#");
            cmd.Parameters.AddWithValue("@t", "#");

            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();


            txtproductsearch.Text = "";
            txtprate.Text = "";
            txtpquantity.Text = "";
            txtpproducttotal.Text = "";
            txttotall.Text = "";
            //txtvat.Text="";
            txtvatequals.Text = "";
            // chkdiscount.Text="";
            txtdiscount.Text = "";
            txttotalamount.Text = "";
            txtprodductname.Text = "";
                product_IdTextBox.Text = "";
                product_CategoryTextBox.Text = "";
            txtinventory.Text = "";
            textBox2.Text = "";


            //DataTable dt = new DataTable();
            float a = float.Parse(txtsaleno.Text);
            a++;
            txtsaleno.Text = a.ToString();

            fmdeletesales g = new fmdeletesales();
            g.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* tbreceipt.Text = "";
             tbreceipt.AppendText(" " + Environment.NewLine);
             tbreceipt.Show();*/
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("EasyBill: One Step Bill Calculations Portal\n Developed By:\n Bishal Shrestha\n Hari Thapa\n Biraj Poudel");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us at facebook.com/easybillnepal");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not authorized to edit\n Contact respective ADMIN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //txttotall.Text = (float.Parse(txtpproducttotal.Text)).ToString();


            //txttotall.Text = (float.Parse(txttotall.Text) + float.Parse(txtpproducttotal.Text)).ToString();
            // txttotall.Text = (float.Parse(txttotall.Text) - float.Parse(txtpproducttotal.Text)).ToString();
            /*       if (sender == btnreset)
                   { }
                   else
                   {
                   txttotall.Text = (float.Parse(txtpproducttotal.Text)+ float.Parse(txtpproducttotal.Text)).ToString();

                   txtproductname.Text = "";
                   txtprate.Text = "";
                   txtpquantity.Text = "";
                   txtpproducttotal.Text = "";*/
            float a = float.Parse(txtsaleno.Text);


            for (int i = 1; i < a; i++)
            {
                float sum = (float.Parse(txtpproducttotal.Text) + a);
                txttotall.Text = sum.ToString();
                a++;
                txtproductsearch.Text = "";
                txtprate.Text = "";
                txtpquantity.Text = "";
                txtpproducttotal.Text = "";


            }
        }

        private void txtprate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtppname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprodductname_TextChanged(object sender, EventArgs e)
        {
            // txtprodductname.Text=txtppname.Text;



        }

        private void product_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_CategoryTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_TotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewcontacts a = new fmviewcontacts();
            a.Show();
        }

        private void productDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewproduct a = new fmviewproduct();
            a.Show();
        }

        private void shippingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmviewshippingdetails a = new fmviewshippingdetails();
            a.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmeasybill f1 = new fmeasybill();
            f1.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            // DataTable dt = new DataTable();
            cmd.CommandText = "insert into SalesEntry ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@a,@b,@c,@d,@e,@f,@g,@h)";
            cmd.Parameters.AddWithValue("@a", txtpname.Text);
            cmd.Parameters.AddWithValue("@b", txtpcat.Text);
            cmd.Parameters.AddWithValue("@c", txtpprate.Text);
            cmd.Parameters.AddWithValue("@d", txtppqu.Text);
            cmd.Parameters.AddWithValue("@e", txtptot.Text);
            cmd.Parameters.AddWithValue("@f,", tztpra.Text);
            cmd.Parameters.AddWithValue("@g", txtpq.Text);
            cmd.Parameters.AddWithValue("@h", txtttl.Text);

            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Saved!");
            /*            cmd.CommandText = "insert into SalesEntry ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@a,@b,@c,@d,@e,@f,@g,@h)";
               cmd.Parameters.AddWithValue("@a", product_NameTextBox.Text);
               cmd.Parameters.AddWithValue("@b", product_CategoryTextBox1.Text);
               cmd.Parameters.AddWithValue("@c", rateTextBox.Text);
               cmd.Parameters.AddWithValue("@d", quantityTextBox.Text);
               cmd.Parameters.AddWithValue("@e", product_TotalTextBox.Text);
               cmd.Parameters.AddWithValue("@f,", vatTextBox.Text);
               cmd.Parameters.AddWithValue("@g", discountTextBox.Text);
               cmd.Parameters.AddWithValue("@h", total_AmountTextBox.Text);
               con.OpenConection();
               con.ExecuteCommand(cmd);
               con.CloseConnection();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            //DataTable dt = new DataTable();

            /*      txtproductsearch.Text = "";
                   */
            /*       ;
                   txtnoitems.Text = ""; 
                   txtpproducttotal.Text = "";*/
            txtpproducttotal.Text = txttotall.Text;
            txtproductsearch.Enabled = false;
            txtproductsearch.Text = "EasyBill";
            txtprodductname.Enabled = false;
            //txtprodductname.Text = "Grand Total";

            product_IdTextBox.Text = "";
            product_CategoryTextBox.Text = "";
            txtprate.Text = "";
            txtpquantity.Text = "";
            txtpquantity.Enabled = false;
            txtvat.Enabled = false;
            txtdiscount.Enabled = false;


            txtpname.Text = txtprodductname.Text;
            txtpcat.Text = product_CategoryTextBox.Text;
            txtpprate.Text = txtprate.Text;
            txtppqu.Text = txtpquantity.Text;
            txtptot.Text = txtpproducttotal.Text;
            tztpra.Text = txtvat.Text;
            txtpq.Text = txtdiscount.Text;
            txtttl.Text = txttotalamount.Text;

            cmd.CommandText = "insert into SalesEntry ([Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@a,@b,@c,@d,@e,@f,@g,@h)";
            cmd.Parameters.AddWithValue("@a", "GrandTotal");
            cmd.Parameters.AddWithValue("@b", txtpcat.Text);
            cmd.Parameters.AddWithValue("@c", txtpprate.Text);
            cmd.Parameters.AddWithValue("@d", txtppqu.Text);
            cmd.Parameters.AddWithValue("@e", txtptot.Text);
            cmd.Parameters.AddWithValue("@f", tztpra.Text);
            cmd.Parameters.AddWithValue("@g", txtpq.Text);
            cmd.Parameters.AddWithValue("@h", txtttl.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            Display_Data();



            cmd.CommandText = "insert into SalesDatabase (Date,Time,Cashier,[Sales No],[Product Name],[Product Category],Rate,Quantity,[Product Total],Vat,Discount,[Total Amount]) values(@q,@r,@s,@z,@i,@j,@k,@l,@m,@n,@o,@p)";
            cmd.Parameters.AddWithValue("@q", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@r", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@s", cashier_IdTextBox.Text);
            cmd.Parameters.AddWithValue("@z", txtsaleno.Text);
            cmd.Parameters.AddWithValue("@i", "GrandTotal");
            cmd.Parameters.AddWithValue("@j", "#");//txtpcat.Text);
            cmd.Parameters.AddWithValue("@k", "#");// txtpprate.Text);
            cmd.Parameters.AddWithValue("@l", "#");// txtppqu.Text);
            cmd.Parameters.AddWithValue("@m", txtptot.Text);//);
            cmd.Parameters.AddWithValue("@n", tztpra.Text);//);
            cmd.Parameters.AddWithValue("@o", txtpq.Text);//);
            cmd.Parameters.AddWithValue("@p", txtttl.Text);//txtttl.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView6.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView6.Rows[i].Cells[4].Value);
            }
            txttotall.Text = sum.ToString();
            //MessageBox.Show(sum.ToString());
            txtproductsearch.Enabled = false;
            txtproductsearch.Text = "";
            txtprodductname.Enabled = false;
            txtprodductname.Text = "";
            product_IdTextBox.Text = "";
            product_CategoryTextBox.Text = "";
            txtprate.Text = "";
            txtpquantity.Text = "";
            txtpquantity.Enabled = false;
            txtvat.Enabled = true;
            txtprodductname.Text = "Grand Total";


            txtpname.Text = "";
            txtpcat.Text = "";
            txtpprate.Text = "";
            txtppqu.Text = "";
            txtptot.Text = "";
            tztpra.Text = "";
            txtpq.Text = "";
            txtttl.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void productEntryDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView7 = productEntryDetailsDataGridView;
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           // this.textBox1.Text = string.Format("{0:##}:{1:##}:{2:##}");
            this.textBox1.Text = datetime.ToString();
            this.textBox1.Text = datetime.ToString("hh:mm:ss");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            fmsaleSS a = new fmsaleSS();
            a.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fmsaleSS a = new fmsaleSS();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            con.OpenConection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from SalesEntry where [Product Name]='"+txtpname.Text+"'";
            con.ExecuteCommand(cmd);
            con.CloseConnection();
           // MessageBox.Show("a");
            this.salesEntryBindingSource.RemoveCurrent();



        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Hello");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbreceipt_Click(object sender, EventArgs e)
        {     
        }

        private void dataGridView8_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            fmprintbill a = new fmprintbill();
            a.Show();

        }
        private void PrintReceipt()
        {
           // PrintDialog printDialog = new PrintDialog();
          //  printDocument1 printDocument = new printDo
        }

        private void usOnFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bishal.stha09");
        }

        private void onInstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/bishal___/");
        }

        private void onTwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/BishalSthaa");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Sales Print";
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString(" EasyBill", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(360, 100));
            e.Graphics.DrawString("KATHMANDU,NEPAL", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(337, 120));
            e.Graphics.DrawString("VAT NO:300142084", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(339, 140));
            e.Graphics.DrawString("TAX INVOICE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(360, 160));
            e.Graphics.DrawString("BILL # : SI221298\t\t\t\t\t\t\t DATE : 22/02/2017", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(3, 200));

            e.Graphics.DrawString("Product Name | Product Category | Rate| Quantity | Product Total | Vat | Discount | Total Amount", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 220);
            e.Graphics.DrawString("  5 Star                Chocolate              10       6                       60 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 240);
            e.Graphics.DrawString("  bon bon             biscuit                  14        5                       70  ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 260);
            e.Graphics.DrawString("  Bread                 Dairy                      70     2                      140 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 280);
            e.Graphics.DrawString("  Bubbly               Chocolate              650    9                    5850 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 300);
            e.Graphics.DrawString("  ChocoFun            Chocolate               5     8                        40", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 320);
            e.Graphics.DrawString("  F Icecream           Icecream             150    7                    1050  ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 340);
            e.Graphics.DrawString("  GrandTotal                                                                        7210         13       24         8123.3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 360);
            e.Graphics.DrawString("    ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 220);
            e.Graphics.DrawString("    ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 25, 220);
      
     //       int height = 0;
    //        int x = 10;
   //         for (int i = 0; i < dataGridView8.Rows.Count; i++)
   //         {
   //             e.Graphics.DrawString(dataGridView8.Rows[i].Cells["[Product Name]"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
                /*        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Product Name"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Product Category"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 70, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Rate"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 105, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Quantity"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 135, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Product Total"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 155, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Vat"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 165, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Discount"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 175, 120 + height);
                        e.Graphics.DrawString(dataGridView8.Rows[i].Cells["Total Amount"].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, x + 185, 120 + height);
                        height += 20;
                    }
                    e.Graphics.DrawString("-----------------------------------------", new Font(dataGridView1.Font.FontFamily, 8, FontStyle.Regular), Brushes.Black, 10, dataGridView1.Height);
                    e.Graphics.DrawString("Total:  " + textBox1.Text + " RON", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 40, dataGridView1.Height + 10);  */





      //      }
                e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
                e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
                e.Graphics.DrawString("", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(3, 890));
                e.Graphics.DrawString("WELCOME TO GREAT SHOPPING EXPERIENCE\n EXCHANGE IN 7 DAYS WITH INVOICE", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 920));
                e.Graphics.DrawString("BRANCH: BALAJU(TEL:01-XXXXXXX/01-XXXXXXX", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 960));
                e.Graphics.DrawString("BRANCH-BALAJU", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 980));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(3, 1000));
                e.Graphics.DrawString("COUNTER:TERMINAL A1(XX:XX:XX)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 1020));
                e.Graphics.DrawString("CASHIER:BISHAL", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 1040));


                // object ce = dataGridView8.CurrentCell.RowIndex;

                //  object cel = dataGridView8.CurrentCell.RowIndex;
                //  e.Graphics.DrawString(), Brushes.Black, new Point(25,100));
                // dataGridView8.Show();
                // "Hello Printing:"+Clientname.Text+
            }
        

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            fmprintbill a = new fmprintbill();
            a.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //   private void txtprate_TextChanged(object sender, EventArgs e)
        //    {
        /*     con.OpenConection();
             //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\HP\Documents\EasyBill.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;");
             String sqlstring = "SELECT * from ProductEntryDetails where [Admin Id]='" + txtadminid.Text.Trim() + "'and Password='" + txtadminpwd.Text.Trim() + "'";
             SqlDataAdapter sda = con.DataAdapter(sqlstring);
             DataTable dt = new DataTable();
             sda.Fill(dt);
             SqlDataAdapter sda = new SqlDataAdapter(sqlstring, con);
             DataTable dt = new DataTable();
             sda.Fill(dt);     */
        /*          OleDbConnection con = new OleDbConnection(ConnectionString);
                  con.Open();
                  str = "select * from ProductEntryDetails where Price=" + txtprate.Text.Trim() + "";
                  com = new OleDbCommand(str, con);
                  OleDbDataReader reader = com.ExecuteReader();
                  if (reader.Read())
                  {
                      txtprate.Text = reader["Price"].ToString();
                  }
                  con.Close();
                  reader.Close();   */

    }
}

  //      private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

      //  }
        
    


   // }

