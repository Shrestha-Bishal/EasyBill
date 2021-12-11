namespace EasyBill
{
    partial class fmaddcashier
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnewform = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // cashier_First_NameLabel
            // 
            cashier_First_NameLabel.AutoSize = true;
            cashier_First_NameLabel.Location = new System.Drawing.Point(36, 44);
            cashier_First_NameLabel.Name = "cashier_First_NameLabel";
            cashier_First_NameLabel.Size = new System.Drawing.Size(60, 13);
            cashier_First_NameLabel.TabIndex = 39;
            cashier_First_NameLabel.Text = "First Name:";
            // 
            // cashier_Last_NameLabel
            // 
            cashier_Last_NameLabel.AutoSize = true;
            cashier_Last_NameLabel.Location = new System.Drawing.Point(32, 70);
            cashier_Last_NameLabel.Name = "cashier_Last_NameLabel";
            cashier_Last_NameLabel.Size = new System.Drawing.Size(64, 13);
            cashier_Last_NameLabel.TabIndex = 41;
            cashier_Last_NameLabel.Text = " Last Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(67, 93);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 43;
            ageLabel.Text = "Age:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(48, 122);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 45;
            addressLabel.Text = "Address:";
            // 
            // mobile_NumberLabel
            // 
            mobile_NumberLabel.AutoSize = true;
            mobile_NumberLabel.Location = new System.Drawing.Point(12, 148);
            mobile_NumberLabel.Name = "mobile_NumberLabel";
            mobile_NumberLabel.Size = new System.Drawing.Size(81, 13);
            mobile_NumberLabel.TabIndex = 47;
            mobile_NumberLabel.Text = "Mobile Number:";
            // 
            // cashier_IdLabel
            // 
            cashier_IdLabel.AutoSize = true;
            cashier_IdLabel.Location = new System.Drawing.Point(37, 174);
            cashier_IdLabel.Name = "cashier_IdLabel";
            cashier_IdLabel.Size = new System.Drawing.Size(57, 13);
            cashier_IdLabel.TabIndex = 49;
            cashier_IdLabel.Text = "Cashier Id:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(37, 200);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 51;
            passwordLabel.Text = "Password:";
            // 
            // counter_NumberLabel
            // 
            counter_NumberLabel.AutoSize = true;
            counter_NumberLabel.Location = new System.Drawing.Point(6, 226);
            counter_NumberLabel.Name = "counter_NumberLabel";
            counter_NumberLabel.Size = new System.Drawing.Size(87, 13);
            counter_NumberLabel.TabIndex = 53;
            counter_NumberLabel.Text = "Counter Number:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(127, 249);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 38;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnewform
            // 
            this.btnnewform.Location = new System.Drawing.Point(132, 12);
            this.btnnewform.Name = "btnnewform";
            this.btnnewform.Size = new System.Drawing.Size(70, 23);
            this.btnnewform.TabIndex = 36;
            this.btnnewform.Text = "New Form";
            this.btnnewform.UseVisualStyleBackColor = true;
            this.btnnewform.Click += new System.EventHandler(this.btnnewform_Click);
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
            this.txtcfname.Location = new System.Drawing.Point(102, 41);
            this.txtcfname.Name = "txtcfname";
            this.txtcfname.Size = new System.Drawing.Size(100, 20);
            this.txtcfname.TabIndex = 40;
            // 
            // txtclname
            // 
            this.txtclname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Cashier Last Name", true));
            this.txtclname.Location = new System.Drawing.Point(102, 67);
            this.txtclname.Name = "txtclname";
            this.txtclname.Size = new System.Drawing.Size(100, 20);
            this.txtclname.TabIndex = 42;
            // 
            // txtcage
            // 
            this.txtcage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Age", true));
            this.txtcage.Location = new System.Drawing.Point(102, 93);
            this.txtcage.Name = "txtcage";
            this.txtcage.Size = new System.Drawing.Size(100, 20);
            this.txtcage.TabIndex = 44;
            // 
            // txtcaddress
            // 
            this.txtcaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Address", true));
            this.txtcaddress.Location = new System.Drawing.Point(102, 119);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(100, 20);
            this.txtcaddress.TabIndex = 46;
            // 
            // txtcmono
            // 
            this.txtcmono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Mobile Number", true));
            this.txtcmono.Location = new System.Drawing.Point(102, 145);
            this.txtcmono.Name = "txtcmono";
            this.txtcmono.Size = new System.Drawing.Size(100, 20);
            this.txtcmono.TabIndex = 48;
            // 
            // txtcid
            // 
            this.txtcid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Cashier Id", true));
            this.txtcid.Location = new System.Drawing.Point(102, 171);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(100, 20);
            this.txtcid.TabIndex = 50;
            // 
            // txtcpwd
            // 
            this.txtcpwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Password", true));
            this.txtcpwd.Location = new System.Drawing.Point(102, 197);
            this.txtcpwd.Name = "txtcpwd";
            this.txtcpwd.Size = new System.Drawing.Size(100, 20);
            this.txtcpwd.TabIndex = 52;
            // 
            // txtccno
            // 
            this.txtccno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashierDetailsBindingSource, "Counter Number", true));
            this.txtccno.Location = new System.Drawing.Point(102, 223);
            this.txtccno.Name = "txtccno";
            this.txtccno.Size = new System.Drawing.Size(100, 20);
            this.txtccno.TabIndex = 54;
            // 
            // fmaddcashier
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 292);
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
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnewform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmaddcashier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Cashier";
            this.Load += new System.EventHandler(this.fmaddcashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnewform;
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
    }
}