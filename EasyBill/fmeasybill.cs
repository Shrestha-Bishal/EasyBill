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
    public partial class fmeasybill : Form
    {
        public fmeasybill()
        {
            InitializeComponent();
        }

        private void EasyBill_Load(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            fmadminpanell f1 = new fmadminpanell();
            f1.Show();
            this.Hide();
        }

        private void btncashier_Click(object sender, EventArgs e)
        {
            fmcashierlogin f1 = new fmcashierlogin();
            f1.Show();
            this.Hide();
        }
    }
}
