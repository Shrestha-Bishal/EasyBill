namespace EasyBill
{
    partial class fmforgotcashierpassword
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
            System.Windows.Forms.Label cashier_IdLabel;
            this.easyBillDatabaseEDataSet16 = new EasyBill.EasyBillDatabaseEDataSet16();
            this.forgotcashieridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forgotcashieridTableAdapter = new EasyBill.EasyBillDatabaseEDataSet16TableAdapters.ForgotcashieridTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager();
            this.cashier_First_NameTextBox = new System.Windows.Forms.TextBox();
            this.cashier_Last_NameTextBox = new System.Windows.Forms.TextBox();
            this.cashier_IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            cashier_First_NameLabel = new System.Windows.Forms.Label();
            cashier_Last_NameLabel = new System.Windows.Forms.Label();
            cashier_IdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cashier_First_NameLabel
            // 
            cashier_First_NameLabel.AutoSize = true;
            cashier_First_NameLabel.Location = new System.Drawing.Point(34, 44);
            cashier_First_NameLabel.Name = "cashier_First_NameLabel";
            cashier_First_NameLabel.Size = new System.Drawing.Size(98, 13);
            cashier_First_NameLabel.TabIndex = 1;
            cashier_First_NameLabel.Text = "Cashier First Name:";
            // 
            // cashier_Last_NameLabel
            // 
            cashier_Last_NameLabel.AutoSize = true;
            cashier_Last_NameLabel.Location = new System.Drawing.Point(34, 70);
            cashier_Last_NameLabel.Name = "cashier_Last_NameLabel";
            cashier_Last_NameLabel.Size = new System.Drawing.Size(99, 13);
            cashier_Last_NameLabel.TabIndex = 3;
            cashier_Last_NameLabel.Text = "Cashier Last Name:";
            // 
            // cashier_IdLabel
            // 
            cashier_IdLabel.AutoSize = true;
            cashier_IdLabel.Location = new System.Drawing.Point(34, 96);
            cashier_IdLabel.Name = "cashier_IdLabel";
            cashier_IdLabel.Size = new System.Drawing.Size(57, 13);
            cashier_IdLabel.TabIndex = 5;
            cashier_IdLabel.Text = "Cashier Id:";
            // 
            // easyBillDatabaseEDataSet16
            // 
            this.easyBillDatabaseEDataSet16.DataSetName = "EasyBillDatabaseEDataSet16";
            this.easyBillDatabaseEDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // forgotcashieridBindingSource
            // 
            this.forgotcashieridBindingSource.DataMember = "Forgotcashierid";
            this.forgotcashieridBindingSource.DataSource = this.easyBillDatabaseEDataSet16;
            // 
            // forgotcashieridTableAdapter
            // 
            this.forgotcashieridTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ForgotcashieridTableAdapter = this.forgotcashieridTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cashier_First_NameTextBox
            // 
            this.cashier_First_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forgotcashieridBindingSource, "Cashier First Name", true));
            this.cashier_First_NameTextBox.Location = new System.Drawing.Point(139, 41);
            this.cashier_First_NameTextBox.Name = "cashier_First_NameTextBox";
            this.cashier_First_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashier_First_NameTextBox.TabIndex = 2;
            // 
            // cashier_Last_NameTextBox
            // 
            this.cashier_Last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forgotcashieridBindingSource, "Cashier Last Name", true));
            this.cashier_Last_NameTextBox.Location = new System.Drawing.Point(139, 67);
            this.cashier_Last_NameTextBox.Name = "cashier_Last_NameTextBox";
            this.cashier_Last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashier_Last_NameTextBox.TabIndex = 4;
            // 
            // cashier_IdTextBox
            // 
            this.cashier_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.forgotcashieridBindingSource, "Cashier Id", true));
            this.cashier_IdTextBox.Location = new System.Drawing.Point(139, 93);
            this.cashier_IdTextBox.Name = "cashier_IdTextBox";
            this.cashier_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashier_IdTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the data in respective fields";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "New Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmforgotcashierpassword
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 158);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(cashier_First_NameLabel);
            this.Controls.Add(this.cashier_First_NameTextBox);
            this.Controls.Add(cashier_Last_NameLabel);
            this.Controls.Add(this.cashier_Last_NameTextBox);
            this.Controls.Add(cashier_IdLabel);
            this.Controls.Add(this.cashier_IdTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmforgotcashierpassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.fmforgotcashierpassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet16 easyBillDatabaseEDataSet16;
        private System.Windows.Forms.BindingSource forgotcashieridBindingSource;
        private EasyBillDatabaseEDataSet16TableAdapters.ForgotcashieridTableAdapter forgotcashieridTableAdapter;
        private EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cashier_First_NameTextBox;
        private System.Windows.Forms.TextBox cashier_Last_NameTextBox;
        private System.Windows.Forms.TextBox cashier_IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}