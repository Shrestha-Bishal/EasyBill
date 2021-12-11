namespace EasyBill
{
    partial class fmprintbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmprintbill));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.btnPrint_Clickk = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.easyBillDatabaseDataSet = new EasyBill.EasyBillDatabaseDataSet();
            this.adminDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDetailsTableAdapter = new EasyBill.EasyBillDatabaseDataSetTableAdapters.AdminDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseDataSetTableAdapters.TableAdapterManager();
            this.adminDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adminDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adminDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.easyBillDatabaseEDataSet16 = new EasyBill.EasyBillDatabaseEDataSet16();
            this.forgotcashieridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.forgotcashieridTableAdapter = new EasyBill.EasyBillDatabaseEDataSet16TableAdapters.ForgotcashieridTableAdapter();
            this.tableAdapterManager1 = new EasyBill.EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager();
            this.forgotcashieridDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printexample2 = new System.Drawing.Printing.PrintDocument();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingNavigator)).BeginInit();
            this.adminDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 2);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(716, 269);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 0.22D;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // btnPrint_Clickk
            // 
            this.btnPrint_Clickk.Location = new System.Drawing.Point(653, 482);
            this.btnPrint_Clickk.Name = "btnPrint_Clickk";
            this.btnPrint_Clickk.Size = new System.Drawing.Size(75, 23);
            this.btnPrint_Clickk.TabIndex = 1;
            this.btnPrint_Clickk.Text = "Print";
            this.btnPrint_Clickk.UseVisualStyleBackColor = true;
            this.btnPrint_Clickk.Click += new System.EventHandler(this.btnPrint_Clickk_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(37, 289);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(319, 228);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(235, 277);
            this.dataGridView7.TabIndex = 8;
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
            // adminDetailsBindingNavigator
            // 
            this.adminDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adminDetailsBindingNavigator.BindingSource = this.adminDetailsBindingSource;
            this.adminDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adminDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adminDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.adminDetailsBindingNavigatorSaveItem});
            this.adminDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adminDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adminDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adminDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adminDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adminDetailsBindingNavigator.Name = "adminDetailsBindingNavigator";
            this.adminDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adminDetailsBindingNavigator.Size = new System.Drawing.Size(908, 25);
            this.adminDetailsBindingNavigator.TabIndex = 9;
            this.adminDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // adminDetailsBindingNavigatorSaveItem
            // 
            this.adminDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adminDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adminDetailsBindingNavigatorSaveItem.Image")));
            this.adminDetailsBindingNavigatorSaveItem.Name = "adminDetailsBindingNavigatorSaveItem";
            this.adminDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.adminDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.adminDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.adminDetailsBindingNavigatorSaveItem_Click);
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
            this.adminDetailsDataGridView.Location = new System.Drawing.Point(13, 289);
            this.adminDetailsDataGridView.Name = "adminDetailsDataGridView";
            this.adminDetailsDataGridView.Size = new System.Drawing.Size(616, 220);
            this.adminDetailsDataGridView.TabIndex = 9;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ForgotcashieridTableAdapter = this.forgotcashieridTableAdapter;
            this.tableAdapterManager1.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // forgotcashieridDataGridView
            // 
            this.forgotcashieridDataGridView.AutoGenerateColumns = false;
            this.forgotcashieridDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.forgotcashieridDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.forgotcashieridDataGridView.DataSource = this.forgotcashieridBindingSource;
            this.forgotcashieridDataGridView.Location = new System.Drawing.Point(165, 132);
            this.forgotcashieridDataGridView.Name = "forgotcashieridDataGridView";
            this.forgotcashieridDataGridView.Size = new System.Drawing.Size(445, 220);
            this.forgotcashieridDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cashier First Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cashier First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cashier Last Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cashier Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cashier Id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cashier Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Load data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Print 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printexample2
            // 
            this.printexample2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printexample2_PrintPage);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Export to Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fmprintbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 562);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.forgotcashieridDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adminDetailsDataGridView);
            this.Controls.Add(this.adminDetailsBindingNavigator);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrint_Clickk);
            this.Controls.Add(this.printPreviewControl1);
            this.Name = "fmprintbill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Print";
            this.Load += new System.EventHandler(this.fmprintbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsBindingNavigator)).EndInit();
            this.adminDetailsBindingNavigator.ResumeLayout(false);
            this.adminDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forgotcashieridDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button btnPrint_Clickk;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingNavigator adminDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource adminDetailsBindingSource;
        private EasyBillDatabaseDataSet easyBillDatabaseDataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton adminDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView7;
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
        private System.Windows.Forms.Button button1;
        private EasyBillDatabaseEDataSet16 easyBillDatabaseEDataSet16;
        private System.Windows.Forms.BindingSource forgotcashieridBindingSource;
        private EasyBillDatabaseEDataSet16TableAdapters.ForgotcashieridTableAdapter forgotcashieridTableAdapter;
        private EasyBillDatabaseEDataSet16TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView forgotcashieridDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printexample2;
        private System.Windows.Forms.Button button4;
    }
}