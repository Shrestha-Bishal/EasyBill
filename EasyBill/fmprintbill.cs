using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;

namespace EasyBill
{
    public partial class fmprintbill : Form
    {
        public fmprintbill()
        {
            
            InitializeComponent();
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // e.Graphics.DrawString(fmprintbill.gr);
        }



        //  #region Print Button Click Event
        /// <span class="code-SummaryComment"><summary></span>
        /// Handles the print button click event
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name=""sender""></param></span>
        /// <span class="code-SummaryComment"><param name=""e""></param></span>
        /// 
        private void btnPrint_Clickk_Click(object sender, EventArgs e)
        {



            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
            /*
            Note: In case you want to show the Print Preview Dialog instead of 
            Print Dialog then comment the above code and uncomment the following code
            */

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();

            /*
 Note: In case you want to show the Print Preview Dialog instead of 
 Print Dialog then comment the above code and uncomment the following code
 */

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();
        }

        private void adminDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet);

        }

        private void fmprintbill_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'easyBillDatabaseEDataSet16.Forgotcashierid' table. You can move, or remove it, as needed.
this.forgotcashieridTableAdapter.Fill(this.easyBillDatabaseEDataSet16.Forgotcashierid);
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter.Fill(this.easyBillDatabaseDataSet.AdminDetails);

        }





      //  #region Get Customer Details Button Click Event
        /// <span class="code-SummaryComment"><summary></span>
        /// Handles the customer details button click
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name=""sender""></param></span>
        /// <span class="code-SummaryComment"><param name=""e""></param></span>
        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
    SqlConnection sqlConnection = null;
    SqlCommand sqlCommand = null;
    SqlDataReader sqlReader = null;

    try
    {
        
        string strQuery = "SELECT [Cashier First Name],[Cashier Last Name],[Cashier Id] FROM Forgotcashierid";
   //     sqlConnection = new SqlConnection(strconnectionString); //(strconnectionString);
        sqlConnection.Open();
        sqlCommand = new SqlCommand(strQuery, sqlConnection);
        sqlReader = sqlCommand.ExecuteReader();
        while (sqlReader.Read())
        {
            object[] row = { sqlReader[0], sqlReader[1], sqlReader[2], sqlReader[3],
            sqlReader[4] };
            forgotcashieridDataGridView.Rows.Add(row);
        }
    }
    catch (Exception exc)
    {
        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        return;
    }
    finally
    {
        Cursor.Current = Cursors.Default;
        sqlConnection.Close();
        if (sqlReader != null)
        {
            sqlReader.Dispose();
            sqlReader = null;
        }
        if (sqlCommand != null)
        {
            sqlCommand.Dispose();
            sqlCommand = null;
        }
    }
}

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            string sql = "SELECT * FROM Forgotcashierid";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Forgotcashierid");
            connection.Close();
            forgotcashieridDataGridView.DataSource = ds;
            forgotcashieridDataGridView.DataMember = "Forgotcashierid";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printexample2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.forgotcashieridDataGridView.Width, this.forgotcashieridDataGridView.Height);
            forgotcashieridDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.forgotcashieridDataGridView.Width, this.forgotcashieridDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

            xlApp = new Excel.Application();//new Excel.DataTable();// ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= forgotcashieridDataGridView.RowCount - 2; i++)
            {
                for (j = 0; j <= forgotcashieridDataGridView.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = forgotcashieridDataGridView[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs(@"c:\csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
        
        
    



