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
    public partial class fmsaleSS : Form
    {
        public fmsaleSS()
        {
            InitializeComponent();
        }

        private void salesDatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesDatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet15);

        }

        private void fmsaleSS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet15.SalesDatabase' table. You can move, or remove it, as needed.
            this.salesDatabaseTableAdapter.Fill(this.easyBillDatabaseEDataSet15.SalesDatabase);

        }
    }
}
