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
    public partial class fmcashierdetails : Form
    {
        private EasyBillDatabaseEDataSet easyBillDatabaseEDataSet;
        private BindingSource cashierDetailsBindingSource;
        private IContainer components;
        private EasyBillDatabaseEDataSetTableAdapters.CashierDetailsTableAdapter cashierDetailsTableAdapter;
        private DataGridView cashierDetailsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private EasyBillDatabaseEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    
        public fmcashierdetails()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.easyBillDatabaseEDataSet = new EasyBill.EasyBillDatabaseEDataSet();
            this.cashierDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDetailsTableAdapter = new EasyBill.EasyBillDatabaseEDataSetTableAdapters.CashierDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSetTableAdapters.TableAdapterManager();
            this.cashierDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // easyBillDatabaseEDataSet
            // 
            this.easyBillDatabaseEDataSet.DataSetName = "EasyBillDatabaseEDataSet";
            this.easyBillDatabaseEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierDetailsBindingSource
            // 
            this.cashierDetailsBindingSource.DataMember = "CashierDetails";
            this.cashierDetailsBindingSource.DataSource = this.easyBillDatabaseEDataSet;
            // 
            // cashierDetailsTableAdapter
            // 
            this.cashierDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CashierDetailsTableAdapter = this.cashierDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cashierDetailsDataGridView
            // 
            this.cashierDetailsDataGridView.AutoGenerateColumns = false;
            this.cashierDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cashierDetailsDataGridView.DataSource = this.cashierDetailsBindingSource;
            this.cashierDetailsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.cashierDetailsDataGridView.Name = "cashierDetailsDataGridView";
            this.cashierDetailsDataGridView.Size = new System.Drawing.Size(843, 431);
            this.cashierDetailsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cashier First Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cashier First Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cashier Last Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cashier Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cashier Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cashier Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Counter Number";
            this.dataGridViewTextBoxColumn8.HeaderText = "Counter Number";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // fmcashierdetails
            // 
            this.ClientSize = new System.Drawing.Size(864, 448);
            this.Controls.Add(this.cashierDetailsDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmcashierdetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Details";
            this.Load += new System.EventHandler(this.fmcashierdetailss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void cashierDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cashierDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.easyBillDatabaseEDataSet);

        }

        private void fmcashierdetailss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyBillDatabaseEDataSet.CashierDetails' table. You can move, or remove it, as needed.
            this.cashierDetailsTableAdapter.Fill(this.easyBillDatabaseEDataSet.CashierDetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmpaneladmin a = new fmpaneladmin();
            a.Show();
            this.Hide();
        }
    }
}
