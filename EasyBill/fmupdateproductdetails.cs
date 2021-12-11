using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBill
{
    public partial class fmupdateproductdetails : Form
    {
        public fmupdateproductdetails()
        {
            InitializeComponent();
        }

        private void productEntryDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productEntryDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet2);

        }

        private void fmupdateproductdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet2.ProductEntryDetails' table. You can move, or remove it, as needed.
            this.productEntryDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet2.ProductEntryDetails);

        }
    }
}
