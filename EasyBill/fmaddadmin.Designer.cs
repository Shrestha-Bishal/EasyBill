namespace EasyBill
{
    partial class fmaddadmin
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
            System.Windows.Forms.Label mobile_numberLabel;
            System.Windows.Forms.Label admin_IDLabel;
            System.Windows.Forms.Label passwordLabel;
            this.easyBillDatabaseDataSet = new EasyBill.EasyBillDatabaseDataSet();
            this.adminDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter = new EasyBill.EasyBillDatabaseDataSetTableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseDataSetTableAdapters.TableAdapterManager();
            this.txtafname = new System.Windows.Forms.TextBox();
            this.txtalname = new System.Windows.Forms.TextBox();
            this.txtaage = new System.Windows.Forms.TextBox();
            this.txtaaddress = new System.Windows.Forms.TextBox();
            this.txtamono = new System.Windows.Forms.TextBox();
            this.txtaid = new System.Windows.Forms.TextBox();
            this.txtapwd = new System.Windows.Forms.TextBox();
            this.btnnewformm = new System.Windows.Forms.Button();
            this.btnSaveadmindetails = new System.Windows.Forms.Button();
            admin_First_NameLabel = new System.Windows.Forms.Label();
            admin_Last_NameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            mobile_numberLabel = new System.Windows.Forms.Label();
            admin_IDLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_First_NameLabel
            // 
            admin_First_NameLabel.AutoSize = true;
            admin_First_NameLabel.Location = new System.Drawing.Point(46, 56);
            admin_First_NameLabel.Name = "admin_First_NameLabel";
            admin_First_NameLabel.Size = new System.Drawing.Size(63, 13);
            admin_First_NameLabel.TabIndex = 1;
            admin_First_NameLabel.Text = " First Name:";
            // 
            // admin_Last_NameLabel
            // 
            admin_Last_NameLabel.AutoSize = true;
            admin_Last_NameLabel.Location = new System.Drawing.Point(45, 82);
            admin_Last_NameLabel.Name = "admin_Last_NameLabel";
            admin_Last_NameLabel.Size = new System.Drawing.Size(64, 13);
            admin_Last_NameLabel.TabIndex = 3;
            admin_Last_NameLabel.Text = " Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(80, 108);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(61, 134);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // mobile_numberLabel
            // 
            mobile_numberLabel.AutoSize = true;
            mobile_numberLabel.Location = new System.Drawing.Point(30, 160);
            mobile_numberLabel.Name = "mobile_numberLabel";
            mobile_numberLabel.Size = new System.Drawing.Size(79, 13);
            mobile_numberLabel.TabIndex = 9;
            mobile_numberLabel.Text = "Mobile number:";
            // 
            // admin_IDLabel
            // 
            admin_IDLabel.AutoSize = true;
            admin_IDLabel.Location = new System.Drawing.Point(56, 186);
            admin_IDLabel.Name = "admin_IDLabel";
            admin_IDLabel.Size = new System.Drawing.Size(53, 13);
            admin_IDLabel.TabIndex = 11;
            admin_IDLabel.Text = "Admin ID:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(53, 212);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 13;
            passwordLabel.Text = "Password:";
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
            // txtafname
            // 
            this.txtafname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin First Name", true));
            this.txtafname.Location = new System.Drawing.Point(116, 53);
            this.txtafname.Name = "txtafname";
            this.txtafname.Size = new System.Drawing.Size(100, 20);
            this.txtafname.TabIndex = 1;
            // 
            // txtalname
            // 
            this.txtalname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin Last Name", true));
            this.txtalname.Location = new System.Drawing.Point(116, 79);
            this.txtalname.Name = "txtalname";
            this.txtalname.Size = new System.Drawing.Size(100, 20);
            this.txtalname.TabIndex = 2;
            // 
            // txtaage
            // 
            this.txtaage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Age", true));
            this.txtaage.Location = new System.Drawing.Point(116, 105);
            this.txtaage.Name = "txtaage";
            this.txtaage.Size = new System.Drawing.Size(100, 20);
            this.txtaage.TabIndex = 3;
            // 
            // txtaaddress
            // 
            this.txtaaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Address", true));
            this.txtaaddress.Location = new System.Drawing.Point(116, 131);
            this.txtaaddress.Name = "txtaaddress";
            this.txtaaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaaddress.TabIndex = 4;
            // 
            // txtamono
            // 
            this.txtamono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Mobile number", true));
            this.txtamono.Location = new System.Drawing.Point(116, 157);
            this.txtamono.Name = "txtamono";
            this.txtamono.Size = new System.Drawing.Size(100, 20);
            this.txtamono.TabIndex = 5;
            // 
            // txtaid
            // 
            this.txtaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Admin ID", true));
            this.txtaid.Location = new System.Drawing.Point(116, 183);
            this.txtaid.Name = "txtaid";
            this.txtaid.Size = new System.Drawing.Size(100, 20);
            this.txtaid.TabIndex = 6;
            // 
            // txtapwd
            // 
            this.txtapwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adminDetailsBindingSource, "Password", true));
            this.txtapwd.Location = new System.Drawing.Point(116, 209);
            this.txtapwd.Name = "txtapwd";
            this.txtapwd.Size = new System.Drawing.Size(100, 20);
            this.txtapwd.TabIndex = 7;
            // 
            // btnnewformm
            // 
            this.btnnewformm.Location = new System.Drawing.Point(147, 12);
            this.btnnewformm.Name = "btnnewformm";
            this.btnnewformm.Size = new System.Drawing.Size(69, 23);
            this.btnnewformm.TabIndex = 16;
            this.btnnewformm.Text = "New Form";
            this.btnnewformm.UseVisualStyleBackColor = true;
            this.btnnewformm.Click += new System.EventHandler(this.btnViewadminDetails_Click);
            // 
            // btnSaveadmindetails
            // 
            this.btnSaveadmindetails.Location = new System.Drawing.Point(140, 235);
            this.btnSaveadmindetails.Name = "btnSaveadmindetails";
            this.btnSaveadmindetails.Size = new System.Drawing.Size(76, 23);
            this.btnSaveadmindetails.TabIndex = 17;
            this.btnSaveadmindetails.Text = "Save";
            this.btnSaveadmindetails.UseVisualStyleBackColor = true;
            this.btnSaveadmindetails.Click += new System.EventHandler(this.btnSaveadmindetails_Click);
            // 
            // fmaddadmin
            // 
            this.AcceptButton = this.btnSaveadmindetails;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 268);
            this.Controls.Add(this.btnSaveadmindetails);
            this.Controls.Add(this.btnnewformm);
            this.Controls.Add(admin_First_NameLabel);
            this.Controls.Add(this.txtafname);
            this.Controls.Add(admin_Last_NameLabel);
            this.Controls.Add(this.txtalname);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.txtaage);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtaaddress);
            this.Controls.Add(mobile_numberLabel);
            this.Controls.Add(this.txtamono);
            this.Controls.Add(admin_IDLabel);
            this.Controls.Add(this.txtaid);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtapwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmaddadmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Admin";
            this.Load += new System.EventHandler(this.fmaddadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseDataSet easyBillDatabaseDataSet;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource;
        private EasyBillDatabaseDataSetTableAdapters.AdminDetailsTableAdapter adminDetailsTableAdapter;
        private EasyBillDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtafname;
        private System.Windows.Forms.TextBox txtalname;
        private System.Windows.Forms.TextBox txtaage;
        private System.Windows.Forms.TextBox txtaaddress;
        private System.Windows.Forms.TextBox txtamono;
        private System.Windows.Forms.TextBox txtaid;
        private System.Windows.Forms.TextBox txtapwd;
        private System.Windows.Forms.Button btnnewformm;
        private System.Windows.Forms.Button btnSaveadmindetails;
    }
}