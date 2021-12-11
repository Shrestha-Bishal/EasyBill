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
    public partial class fmshowadmindetails : Form
    {
        public fmshowadmindetails()
        {
            InitializeComponent();
        }

        private void adminDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseDataSet);

        }

        private void fmshowadmindetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet6.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter2.Fill(this.easyBillDatabaseEDataSet6.AdminDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet1.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter1.Fill(this.easyBillDatabaseDataSet1.AdminDetails);
            // TODO: This line of code loads data into the 'easyBillDatabaseDataSet.AdminDetails' table. You can move, or remove it, as needed.
            this.adminDetailsTableAdapter.Fill(this.easyBillDatabaseDataSet.AdminDetails);

        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            fmpaneladmin f1 = new fmpaneladmin();
            f1.Show();
            this.Hide();
        }
    }
}
