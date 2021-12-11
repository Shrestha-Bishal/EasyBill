namespace EasyBill
{
    partial class fmshowadmindetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.easyBillDatabaseDataSet = new EasyBill.EasyBillDatabaseDataSet();
            this.adminDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter = new EasyBill.EasyBillDatabaseDataSetTableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseDataSetTableAdapters.TableAdapterManager();
            this.adminDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyBillDatabaseDataSet1 = new EasyBill.EasyBillDatabaseDataSet1();
            this.adminDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter1 = new EasyBill.EasyBillDatabaseDataSet1TableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager1 = new EasyBill.EasyBillDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.easyBillDatabaseEDataSet6 = new EasyBill.EasyBillDatabaseEDataSet6();
            this.adminDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter2 = new EasyBill.EasyBillDatabaseEDataSet6TableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager2 = new EasyBill.EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager();
            this.adminDetailsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // easyBillDatabaseDataSet
            // 
            this.easyBillDatabaseDataSet.DataSetName = "EasyBillDatabaseDataSet";
            this.easyBillDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminDetailsBindingSource
            // 
            this.adminDetailsBindingSource.DataMember = "AdminDetails";
            this.adminDetailsBindingSource.DataSource = this.easyBillDatabaseDataSet;
            // 
            // adminDetailsTableAdapter
            // 
            this.adminDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminDetailsTableAdapter = this.adminDetailsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminDetailsDataGridView
            // 
            this.adminDetailsDataGridView.AutoGenerateColumns = false;
            this.adminDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.adminDetailsDataGridView.DataSource = this.adminDetailsBindingSource;
            this.adminDetailsDataGridView.Location = new System.Drawing.Point(48, 39);
            this.adminDetailsDataGridView.Name = "adminDetailsDataGridView";
            this.adminDetailsDataGridView.Size = new System.Drawing.Size(0, 0);
            this.adminDetailsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Admin First Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Admin First Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Admin Last Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Admin Last Name";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Admin ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Admin ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // easyBillDatabaseDataSet1
            // 
            this.easyBillDatabaseDataSet1.DataSetName = "EasyBillDatabaseDataSet1";
            this.easyBillDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminDetailsBindingSource1
            // 
            this.adminDetailsBindingSource1.DataMember = "AdminDetails";
            this.adminDetailsBindingSource1.DataSource = this.easyBillDatabaseDataSet1;
            // 
            // adminDetailsTableAdapter1
            // 
            this.adminDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdminDetailsTableAdapter = this.adminDetailsTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = EasyBill.EasyBillDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // easyBillDatabaseEDataSet6
            // 
            this.easyBillDatabaseEDataSet6.DataSetName = "EasyBillDatabaseEDataSet6";
            this.easyBillDatabaseEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminDetailsBindingSource2
            // 
            this.adminDetailsBindingSource2.DataMember = "AdminDetails";
            this.adminDetailsBindingSource2.DataSource = this.easyBillDatabaseEDataSet6;
            // 
            // adminDetailsTableAdapter2
            // 
            this.adminDetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.AdminDetailsTableAdapter = this.adminDetailsTableAdapter2;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adminDetailsDataGridView1
            // 
            this.adminDetailsDataGridView1.AutoGenerateColumns = false;
            this.adminDetailsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDetailsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.adminDetailsDataGridView1.DataSource = this.adminDetailsBindingSource2;
            this.adminDetailsDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.adminDetailsDataGridView1.Name = "adminDetailsDataGridView1";
            this.adminDetailsDataGridView1.Size = new System.Drawing.Size(743, 308);
            this.adminDetailsDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Admin First Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Admin First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Admin Last Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Admin Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn10.HeaderText = "Age";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Mobile Number";
            this.dataGridViewTextBoxColumn12.HeaderText = "Mobile Number";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Admin Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Admin Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn14.HeaderText = "Password";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // fmshowadmindetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 332);
            this.Controls.Add(this.adminDetailsDataGridView1);
            this.Controls.Add(this.adminDetailsDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmshowadmindetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Details";
            this.Load += new System.EventHandler(this.fmshowadmindetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EasyBillDatabaseDataSet easyBillDatabaseDataSet;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource;
        private EasyBillDatabaseDataSetTableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter;
        private EasyBillDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView adminDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private EasyBillDatabaseDataSet1 easyBillDatabaseDataSet1;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource1;
        private EasyBillDatabaseDataSet1TableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter1;
        private EasyBillDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private EasyBillDatabaseEDataSet6 easyBillDatabaseEDataSet6;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource2;
        private EasyBillDatabaseEDataSet6TableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter2;
        private EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView adminDetailsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}