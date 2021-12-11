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
    public partial class fmviewcontacts : Form
    {
        public fmviewcontacts()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet5);

        }

        private void fmviewcontacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet5.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.easyBillDatabaseEDataSet5.Contacts);

        }
    }
}
