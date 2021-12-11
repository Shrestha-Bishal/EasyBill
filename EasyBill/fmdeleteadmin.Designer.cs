namespace EasyBill
{
    partial class fmdeleteadmin
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
            System.Windows.Forms.Label admin_First_NameLabel;
            System.Windows.Forms.Label admin_Last_NameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label mobile_NumberLabel;
            System.Windows.Forms.Label admin_IdLabel;
            System.Windows.Forms.Label passwordLabel;
            this.easyBillDatabaseEDataSet6 = new EasyBill.EasyBillDatabaseEDataSet6();
            this.adminDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter = new EasyBill.EasyBillDatabaseEDataSet6TableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager();
            this.adminDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtafname = new System.Windows.Forms.TextBox();
            this.txtalname = new System.Windows.Forms.TextBox();
            this.txtaage = new System.Windows.Forms.TextBox();
            this.txtaaddress = new System.Windows.Forms.TextBox();
            this.txtamo = new System.Windows.Forms.TextBox();
            this.txtaid = new System.Windows.Forms.TextBox();
            this.txtapw = new System.Windows.Forms.TextBox();
            admin_First_NameLabel = new System.Windows.Forms.Label();
            admin_Last_NameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            mobile_NumberLabel = new System.Windows.Forms.Label();
            admin_IdLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_First_NameLabel
            // 
            admin_First_NameLabel.AutoSize = true;
            admin_First_NameLabel.Location = new System.Drawing.Point(12, 21);
            admin_First_NameLabel.Name = "admin_First_NameLabel";
            admin_First_NameLabel.Size = new System.Drawing.Size(92, 13);
            admin_First_NameLabel.TabIndex = 2;
            admin_First_NameLabel.Text = "Admin First Name:";
            // 
            // admin_Last_NameLabel
            // 
            admin_Last_NameLabel.AutoSize = true;
            admin_Last_NameLabel.Location = new System.Drawing.Point(12, 47);
            admin_Last_NameLabel.Name = "admin_Last_NameLabel";
            admin_Last_NameLabel.Size = new System.Drawing.Size(93, 13);
            admin_Last_NameLabel.TabIndex = 4;
            admin_Last_NameLabel.Text = "Admin Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(12, 73);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 99);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // mobile_NumberLabel
            // 
            mobile_NumberLabel.AutoSize = true;
            mobile_NumberLabel.Location = new System.Drawing.Point(12, 125);
            mobile_NumberLabel.Name = "mobile_NumberLabel";
            mobile_NumberLabel.Size = new System.Drawing.Size(81, 13);
            mobile_NumberLabel.TabIndex = 10;
            mobile_NumberLabel.Text = "Mobile Number:";
            // 
            // admin_IdLabel
            // 
            admin_IdLabel.AutoSize = true;
            admin_IdLabel.Location = new System.Drawing.Point(12, 151);
            admin_IdLabel.Name = "admin_IdLabel";
            admin_IdLabel.Size = new System.Drawing.Size(51, 13);
            admin_IdLabel.TabIndex = 12;
            admin_IdLabel.Text = "Admin Id:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 177);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // easyBillDatabaseEDataSet6
            // 
            this.easyBillDatabaseEDataSet6.DataSetName = "EasyBillDatabaseEDataSet6";
            this.easyBillDatabaseEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminDetailsBindingSource
            // 
            this.adminDetailsBindingSource.DataMember = "AdminDetails";
            this.adminDetailsBindingSource.DataSource = this.easyBillDatabaseEDataSet6;
            // 
            // adminDetailsTableAdapter
            // 
            this.adminDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminDetailsTableAdapter = this.adminDetailsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.adminDetailsDataGridView.Location = new System.Drawing.Point(230, 12);
            this.adminDetailsDataGridView.Name = "adminDetailsDataGridView";
            this.adminDetailsDataGridView.Size = new System.Drawing.Size(744, 220);
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Admin Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Admin Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtafname
            // 
            this.txtafname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin First Name", true));
            this.txtafname.Location = new System.Drawing.Point(111, 18);
            this.txtafname.Name = "txtafname";
            this.txtafname.Size = new System.Drawing.Size(100, 20);
            this.txtafname.TabIndex = 3;
            // 
            // txtalname
            // 
            this.txtalname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin Last Name", true));
            this.txtalname.Location = new System.Drawing.Point(111, 44);
            this.txtalname.Name = "txtalname";
            this.txtalname.Size = new System.Drawing.Size(100, 20);
            this.txtalname.TabIndex = 5;
            // 
            // txtaage
            // 
            this.txtaage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Age", true));
            this.txtaage.Location = new System.Drawing.Point(111, 70);
            this.txtaage.Name = "txtaage";
            this.txtaage.Size = new System.Drawing.Size(100, 20);
            this.txtaage.TabIndex = 7;
            // 
            // txtaaddress
            // 
            this.txtaaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Address", true));
            this.txtaaddress.Location = new System.Drawing.Point(111, 96);
            this.txtaaddress.Name = "txtaaddress";
            this.txtaaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaaddress.TabIndex = 9;
            // 
            // txtamo
            // 
            this.txtamo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Mobile Number", true));
            this.txtamo.Location = new System.Drawing.Point(111, 122);
            this.txtamo.Name = "txtamo";
            this.txtamo.Size = new System.Drawing.Size(100, 20);
            this.txtamo.TabIndex = 11;
            // 
            // txtaid
            // 
            this.txtaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin Id", true));
            this.txtaid.Location = new System.Drawing.Point(111, 148);
            this.txtaid.Name = "txtaid";
            this.txtaid.Size = new System.Drawing.Size(100, 20);
            this.txtaid.TabIndex = 13;
            // 
            // txtapw
            // 
            this.txtapw.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Password", true));
            this.txtapw.Location = new System.Drawing.Point(111, 174);
            this.txtapw.Name = "txtapw";
            this.txtapw.Size = new System.Drawing.Size(100, 20);
            this.txtapw.TabIndex = 15;
            // 
            // fmdeleteadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 285);
            this.Controls.Add(admin_First_NameLabel);
            this.Controls.Add(this.txtafname);
            this.Controls.Add(admin_Last_NameLabel);
            this.Controls.Add(this.txtalname);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.txtaage);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtaaddress);
            this.Controls.Add(mobile_NumberLabel);
            this.Controls.Add(this.txtamo);
            this.Controls.Add(admin_IdLabel);
            this.Controls.Add(this.txtaid);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtapw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminDetailsDataGridView);
            this.Name = "fmdeleteadmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Admin";
            this.Load += new System.EventHandler(this.fmdeleteadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet6 easyBillDatabaseEDataSet6;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource;
        private EasyBillDatabaseEDataSet6TableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter;
        private EasyBillDatabaseEDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView adminDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtafname;
        private System.Windows.Forms.TextBox txtalname;
        private System.Windows.Forms.TextBox txtaage;
        private System.Windows.Forms.TextBox txtaaddress;
        private System.Windows.Forms.TextBox txtamo;
        private System.Windows.Forms.TextBox txtaid;
        private System.Windows.Forms.TextBox txtapw;
    }
}