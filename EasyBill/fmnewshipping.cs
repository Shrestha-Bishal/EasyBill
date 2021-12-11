using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace EasyBill
{
    public partial class fmnewshipping : Form
    {
        mydbConnection con = new mydbConnection();
        public fmnewshipping()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet3.CustomerDetailsForShipping' table. You can move, or remove it, as needed.
            this.customerDetailsForShippingTableAdapter.Fill(this.easyBillDatabaseEDataSet3.CustomerDetailsForShipping);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            mydbConnection con = new mydbConnection();
            SqlCommand cmd = new SqlCommand();
            // DataTable dt = new DataTable();
            cmd.CommandText = "insert into CustomerDetailsForShipping ([Customer First Name],[Customer Last Name],Address,City,Country,[Post Code],Phone,Email,Company,[Ship to name],[Shipping Address],[Shipping City],[Shipping State],[Shipping Country],[Date of Shipping],[Date received]) values(@cusfname,@cuslname,@address,@city,@country,@post,@phone,@email,@company,@sname,@saddress,@scity,@sstate,@scountry,@dshipping,@dreceived)";
            cmd.Parameters.AddWithValue("@cusfname", txtcfname.Text);
            cmd.Parameters.AddWithValue("@cuslname", txtclname.Text);
            cmd.Parameters.AddWithValue("@address", txtcaddress.Text);
            cmd.Parameters.AddWithValue("@city", txtccity.Text);
            cmd.Parameters.AddWithValue("@country", txtccountry.Text);
            cmd.Parameters.AddWithValue("@post", txtcpostcode.Text);
            cmd.Parameters.AddWithValue("@phone", txtcphone.Text);
            cmd.Parameters.AddWithValue("@email", txtcemail.Text);
            cmd.Parameters.AddWithValue("@company", txtccompany.Text);
            cmd.Parameters.AddWithValue("@sname", txtcsname.Text);
            cmd.Parameters.AddWithValue("@saddress", txtcsaddress.Text);
            cmd.Parameters.AddWithValue("@scity", txtcscity.Text);
            cmd.Parameters.AddWithValue("@sstate", txtcsstate.Text);
            cmd.Parameters.AddWithValue("@scountry", txtcscountry.Text);
            cmd.Parameters.AddWithValue("@dshipping", txtcdshipping.Text);
            cmd.Parameters.AddWithValue("@dreceived", txtcdreceived.Text);
            con.OpenConection();
            con.ExecuteCommand(cmd);
            con.CloseConnection();
            MessageBox.Show("Saved!");
            txtcfname.Text = "";
            txtclname.Text = "";
            txtcaddress.Text = "";
            txtccity.Text = "";
            txtcpostcode.Text = "";
            txtcphone.Text = "";
            txtcemail.Text = "";
            txtccountry.Text = "";
            txtccompany.Text = "";
            txtcsname.Text = "";
            txtcsaddress.Text = "";
            txtcscity.Text = "";
            txtcsstate.Text = "";
            txtcscountry.Text = "";
            txtcdshipping.Text = "";
            txtcdreceived.Text = "";
        }

        private void customerDetailsForShippingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerDetailsForShippingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet3);

        }

        private void btnnewform_Click(object sender, EventArgs e)
        {
            txtcfname.Text = "";
            txtclname.Text = "";
            txtcaddress.Text = "";
            txtccity.Text = "";
            txtcpostcode.Text = "";
            txtcphone.Text = "";
            txtcemail.Text = "";
            txtccountry.Text = "";
            txtccompany.Text = "";
            txtcsname.Text = "";
            txtcsaddress.Text = "";
            txtcscity.Text = "";
            txtcsstate.Text = "";
            txtcscountry.Text = "";
            txtcdshipping.Text = "";
            txtcdreceived.Text = "";
        }

        private void btnviewshipping_Click(object sender, EventArgs e)
        {
            fmviewshippingdetails a = new fmviewshippingdetails();
            a.Show();
            this.Hide();
        }

        private void btnprinttoexcel_Click(object sender, EventArgs e)
        {
            
           /* Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            ws.Cells[1, 1] = "Reference";
            ws.Cells[1, 1] = "Description";
                ws.Cells[1, 1] = "Quantity";
                    ws.Cells[1, 1] = "Prix";
                    ws.Cells[1, 1] = "Category";
                            
                            for (int j=2;j<=DataGridView.Rows.Count;j++)
                            {
                            for (int i=2; i<=5;i++)
                            {
                            ws.Cells[j,1]= DataGridView.Rows[j-2].Cells[i-1].Value;
                            }
                            }*/


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            // this.textBox1.Text = string.Format("{0:##}:{1:##}:{2:##}");
            this.txtcdshipping.Text = datetime.ToString();
            this.txtcdshipping.Text = datetime.ToString("dd:mm:yyyy");
        }
    }
}
