namespace EasyBill
{
    partial class fmupdatedeletecashier
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
            System.Windows.Forms.Label cashier_First_NameLabel;
            System.Windows.Forms.Label cashier_Last_NameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label mobile_NumberLabel;
            System.Windows.Forms.Label cashier_IdLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label counter_NumberLabel;
            this.easyBillDatabaseEDataSet = new EasyBill.EasyBillDatabaseEDataSet();
            this.cashierDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashierDetailsTableAdapter = new EasyBill.EasyBillDatabaseEDataSetTableAdapters.CashierDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSetTableAdapters.TableAdapterManager();
            this.txtcfname = new System.Windows.Forms.TextBox();
            this.txtclname = new System.Windows.Forms.TextBox();
            this.txtcage = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtcmono = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtcpwd = new System.Windows.Forms.TextBox();
            this.txtccno = new System.Windows.Forms.TextBox();
            this.cashierDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndeletecashier = new System.Windows.Forms.Button();
            this.btnupdatecashier = new System.Windows.Forms.Button();
            cashier_First_NameLabel = new System.Windows.Forms.Label();
            cashier_Last_NameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            mobile_NumberLabel = new System.Windows.Forms.Label();
            cashier_IdLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            counter_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cashier_First_NameLabel
            // 
            cashier_First_NameLabel.AutoSize = true;
            cashier_First_NameLabel.Location = new System.Drawing.Point(12, 47);
            cashier_First_NameLabel.Name = "cashier_First_NameLabel";
            cashier_First_NameLabel.Size = new System.Drawing.Size(98, 13);
            cashier_First_NameLabel.TabIndex = 1;
            cashier_First_NameLabel.Text = "Cashier First Name:";
            // 
            // cashier_Last_NameLabel
            // 
            cashier_Last_NameLabel.AutoSize = true;
            cashier_Last_NameLabel.Location = new System.Drawing.Point(12, 73);
            cashier_Last_NameLabel.Name = "cashier_Last_NameLabel";
            cashier_Last_NameLabel.Size = new System.Drawing.Size(99, 13);
            cashier_Last_NameLabel.TabIndex = 3;
            cashier_Last_NameLabel.Text = "Cashier Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(12, 99);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 125);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // mobile_NumberLabel
            // 
            mobile_NumberLabel.AutoSize = true;
            mobile_NumberLabel.Location = new System.Drawing.Point(12, 151);
            mobile_NumberLabel.Name = "mobile_NumberLabel";
            mobile_NumberLabel.Size = new System.Drawing.Size(81, 13);
            mobile_NumberLabel.TabIndex = 9;
            mobile_NumberLabel.Text = "Mobile Number:";
            // 
            // cashier_IdLabel
            // 
            cashier_IdLabel.AutoSize = true;
            cashier_IdLabel.Location = new System.Drawing.Point(12, 177);
            cashier_IdLabel.Name = "cashier_IdLabel";
            cashier_IdLabel.Size = new System.Drawing.Size(57, 13);
            cashier_IdLabel.TabIndex = 11;
            cashier_IdLabel.Text = "Cashier Id:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 203);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
            // 
            // counter_NumberLabel
            // 
            counter_NumberLabel.AutoSize = true;
            counter_NumberLabel.Location = new System.Drawing.Point(12, 229);
            counter_NumberLabel.Name = "counter_NumberLabel";
            counter_NumberLabel.Size = new System.Drawing.Size(87, 13);
            counter_NumberLabel.TabIndex = 15;
            counter_NumberLabel.Text = "Counter Number:";
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
            // txtcfname
            // 
            this.txtcfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Cashier First Name", true));
            this.txtcfname.Location = new System.Drawing.Point(117, 44);
            this.txtcfname.Name = "txtcfname";
            this.txtcfname.Size = new System.Drawing.Size(100, 20);
            this.txtcfname.TabIndex = 2;
            // 
            // txtclname
            // 
            this.txtclname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Cashier Last Name", true));
            this.txtclname.Location = new System.Drawing.Point(117, 70);
            this.txtclname.Name = "txtclname";
            this.txtclname.Size = new System.Drawing.Size(100, 20);
            this.txtclname.TabIndex = 4;
            // 
            // txtcage
            // 
            this.txtcage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Age", true));
            this.txtcage.Location = new System.Drawing.Point(117, 96);
            this.txtcage.Name = "txtcage";
            this.txtcage.Size = new System.Drawing.Size(100, 20);
            this.txtcage.TabIndex = 6;
            // 
            // txtcaddress
            // 
            this.txtcaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Address", true));
            this.txtcaddress.Location = new System.Drawing.Point(117, 122);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(100, 20);
            this.txtcaddress.TabIndex = 8;
            // 
            // txtcmono
            // 
            this.txtcmono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Mobile Number", true));
            this.txtcmono.Location = new System.Drawing.Point(117, 148);
            this.txtcmono.Name = "txtcmono";
            this.txtcmono.Size = new System.Drawing.Size(100, 20);
            this.txtcmono.TabIndex = 10;
            // 
            // txtcid
            // 
            this.txtcid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Cashier Id", true));
            this.txtcid.Location = new System.Drawing.Point(117, 174);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(100, 20);
            this.txtcid.TabIndex = 12;
            // 
            // txtcpwd
            // 
            this.txtcpwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Password", true));
            this.txtcpwd.Location = new System.Drawing.Point(117, 200);
            this.txtcpwd.Name = "txtcpwd";
            this.txtcpwd.Size = new System.Drawing.Size(100, 20);
            this.txtcpwd.TabIndex = 14;
            // 
            // txtccno
            // 
            this.txtccno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Counter Number", true));
            this.txtccno.Location = new System.Drawing.Point(117, 226);
            this.txtccno.Name = "txtccno";
            this.txtccno.Size = new System.Drawing.Size(100, 20);
            this.txtccno.TabIndex = 16;
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
            this.cashierDetailsDataGridView.Location = new System.Drawing.Point(258, 45);
            this.cashierDetailsDataGridView.Name = "cashierDetailsDataGridView";
            this.cashierDetailsDataGridView.Size = new System.Drawing.Size(835, 335);
            this.cashierDetailsDataGridView.TabIndex = 17;
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
            // btndeletecashier
            // 
            this.btndeletecashier.Location = new System.Drawing.Point(142, 266);
            this.btndeletecashier.Name = "btndeletecashier";
            this.btndeletecashier.Size = new System.Drawing.Size(75, 23);
            this.btndeletecashier.TabIndex = 21;
            this.btndeletecashier.Text = "Delete";
            this.btndeletecashier.UseVisualStyleBackColor = true;
            this.btndeletecashier.Click += new System.EventHandler(this.btndeletecashier_Click);
            // 
            // btnupdatecashier
            // 
            this.btnupdatecashier.Location = new System.Drawing.Point(61, 266);
            this.btnupdatecashier.Name = "btnupdatecashier";
            this.btnupdatecashier.Size = new System.Drawing.Size(75, 23);
            this.btnupdatecashier.TabIndex = 20;
            this.btnupdatecashier.Text = "Update";
            this.btnupdatecashier.UseVisualStyleBackColor = true;
            this.btnupdatecashier.Click += new System.EventHandler(this.btnupdatecashier_Click);
            // 
            // fmupdatedeletecashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 392);
            this.Controls.Add(this.btndeletecashier);
            this.Controls.Add(this.btnupdatecashier);
            this.Controls.Add(this.cashierDetailsDataGridView);
            this.Controls.Add(cashier_First_NameLabel);
            this.Controls.Add(this.txtcfname);
            this.Controls.Add(cashier_Last_NameLabel);
            this.Controls.Add(this.txtclname);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.txtcage);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(mobile_NumberLabel);
            this.Controls.Add(this.txtcmono);
            this.Controls.Add(cashier_IdLabel);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtcpwd);
            this.Controls.Add(counter_NumberLabel);
            this.Controls.Add(this.txtccno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmupdatedeletecashier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update/Delete Cashier";
            this.Load += new System.EventHandler(this.fmupdatedeletecashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet easyBillDatabaseEDataSet;
        private System.Windows.Forms.BindingSource cashierDetailsBindingSource;
        private EasyBillDatabaseEDataSetTableAdapters.CashierDetailsTableAdapter cashierDetailsTableAdapter;
        private EasyBillDatabaseEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtcfname;
        private System.Windows.Forms.TextBox txtclname;
        private System.Windows.Forms.TextBox txtcage;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtcmono;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txtcpwd;
        private System.Windows.Forms.TextBox txtccno;
        private System.Windows.Forms.DataGridView cashierDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btndeletecashier;
        private System.Windows.Forms.Button btnupdatecashier;
    }
}