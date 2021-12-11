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
    public partial class fmviewshippingdetails : Form
    {
        public fmviewshippingdetails()
        {
            InitializeComponent();
        }

        private void customerDetailsForShippingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerDetailsForShippingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet3);

        }

        private void fmviewshippingdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet3.CustomerDetailsForShipping' table. You can move, or remove it, as needed.
            this.customerDetailsForShippingTableAdapter.Fill(this.easyBillDatabaseEDataSet3.CustomerDetailsForShipping);

        }
    }
}
