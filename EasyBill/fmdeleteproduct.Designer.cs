namespace EasyBill
{
    partial class fmupdateproduct
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
            System.Windows.Forms.Label product_IdLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label product_CategoryLabel;
            System.Windows.Forms.Label product_PriceLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label product_UnitLabel;
            System.Windows.Forms.Label unit_QuantityLabel;
            System.Windows.Forms.Label product_QuantityLabel;
            System.Windows.Forms.Label product_DescriptionLabel;
            System.Windows.Forms.Label date_of_EntryLabel;
            System.Windows.Forms.Label product_CompanyLabel;
            this.easyBillDatabaseEDataSet2 = new EasyBill.EasyBillDatabaseEDataSet2();
            this.productEntryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productEntryDetailsTableAdapter = new EasyBill.EasyBillDatabaseEDataSet2TableAdapters.ProductEntryDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager();
            this.productEntryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtpcategory = new System.Windows.Forms.TextBox();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.txtpsprice = new System.Windows.Forms.TextBox();
            this.txtpunit = new System.Windows.Forms.TextBox();
            this.txtpuquantity = new System.Windows.Forms.TextBox();
            this.txtpquantity = new System.Windows.Forms.TextBox();
            this.txtpdescription = new System.Windows.Forms.TextBox();
            this.txtpdoe = new System.Windows.Forms.TextBox();
            this.txtpcompany = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            product_IdLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            product_CategoryLabel = new System.Windows.Forms.Label();
            product_PriceLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            product_UnitLabel = new System.Windows.Forms.Label();
            unit_QuantityLabel = new System.Windows.Forms.Label();
            product_QuantityLabel = new System.Windows.Forms.Label();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            date_of_EntryLabel = new System.Windows.Forms.Label();
            product_CompanyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IdLabel
            // 
            product_IdLabel.AutoSize = true;
            product_IdLabel.Location = new System.Drawing.Point(59, 19);
            product_IdLabel.Name = "product_IdLabel";
            product_IdLabel.Size = new System.Drawing.Size(59, 13);
            product_IdLabel.TabIndex = 2;
            product_IdLabel.Text = "Product Id:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(37, 45);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 4;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_CategoryLabel
            // 
            product_CategoryLabel.AutoSize = true;
            product_CategoryLabel.Location = new System.Drawing.Point(23, 67);
            product_CategoryLabel.Name = "product_CategoryLabel";
            product_CategoryLabel.Size = new System.Drawing.Size(92, 13);
            product_CategoryLabel.TabIndex = 6;
            product_CategoryLabel.Text = "Product Category:";
            // 
            // product_PriceLabel
            // 
            product_PriceLabel.AutoSize = true;
            product_PriceLabel.Location = new System.Drawing.Point(40, 93);
            product_PriceLabel.Name = "product_PriceLabel";
            product_PriceLabel.Size = new System.Drawing.Size(74, 13);
            product_PriceLabel.TabIndex = 8;
            product_PriceLabel.Text = "Product Price:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(46, 119);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 13);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Selling Price:";
            // 
            // product_UnitLabel
            // 
            product_UnitLabel.AutoSize = true;
            product_UnitLabel.Location = new System.Drawing.Point(46, 145);
            product_UnitLabel.Name = "product_UnitLabel";
            product_UnitLabel.Size = new System.Drawing.Size(69, 13);
            product_UnitLabel.TabIndex = 12;
            product_UnitLabel.Text = "Product Unit:";
            product_UnitLabel.Click += new System.EventHandler(this.product_UnitLabel_Click);
            // 
            // unit_QuantityLabel
            // 
            unit_QuantityLabel.AutoSize = true;
            unit_QuantityLabel.Location = new System.Drawing.Point(44, 171);
            unit_QuantityLabel.Name = "unit_QuantityLabel";
            unit_QuantityLabel.Size = new System.Drawing.Size(71, 13);
            unit_QuantityLabel.TabIndex = 14;
            unit_QuantityLabel.Text = "Unit Quantity:";
            // 
            // product_QuantityLabel
            // 
            product_QuantityLabel.AutoSize = true;
            product_QuantityLabel.Location = new System.Drawing.Point(30, 197);
            product_QuantityLabel.Name = "product_QuantityLabel";
            product_QuantityLabel.Size = new System.Drawing.Size(89, 13);
            product_QuantityLabel.TabIndex = 16;
            product_QuantityLabel.Text = "Product Quantity:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(16, 223);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(103, 13);
            product_DescriptionLabel.TabIndex = 18;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // date_of_EntryLabel
            // 
            date_of_EntryLabel.AutoSize = true;
            date_of_EntryLabel.Location = new System.Drawing.Point(46, 249);
            date_of_EntryLabel.Name = "date_of_EntryLabel";
            date_of_EntryLabel.Size = new System.Drawing.Size(72, 13);
            date_of_EntryLabel.TabIndex = 20;
            date_of_EntryLabel.Text = "Date of Entry:";
            // 
            // product_CompanyLabel
            // 
            product_CompanyLabel.AutoSize = true;
            product_CompanyLabel.Location = new System.Drawing.Point(21, 275);
            product_CompanyLabel.Name = "product_CompanyLabel";
            product_CompanyLabel.Size = new System.Drawing.Size(94, 13);
            product_CompanyLabel.TabIndex = 22;
            product_CompanyLabel.Text = "Product Company:";
            // 
            // easyBillDatabaseEDataSet2
            // 
            this.easyBillDatabaseEDataSet2.DataSetName = "EasyBillDatabaseEDataSet2";
            this.easyBillDatabaseEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productEntryDetailsBindingSource
            // 
            this.productEntryDetailsBindingSource.DataMember = "ProductEntryDetails";
            this.productEntryDetailsBindingSource.DataSource = this.easyBillDatabaseEDataSet2;
            // 
            // productEntryDetailsTableAdapter
            // 
            this.productEntryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductEntryDetailsTableAdapter = this.productEntryDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productEntryDetailsDataGridView
            // 
            this.productEntryDetailsDataGridView.AutoGenerateColumns = false;
            this.productEntryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productEntryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.productEntryDetailsDataGridView.DataSource = this.productEntryDetailsBindingSource;
            this.productEntryDetailsDataGridView.Location = new System.Drawing.Point(240, 12);
            this.productEntryDetailsDataGridView.Name = "productEntryDetailsDataGridView";
            this.productEntryDetailsDataGridView.Size = new System.Drawing.Size(1191, 717);
            this.productEntryDetailsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Product Unit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product Unit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Unit Quantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Unit Quantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Product Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Product Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Product Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Product Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Date of Entry";
            this.dataGridViewTextBoxColumn10.HeaderText = "Date of Entry";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Product Company";
            this.dataGridViewTextBoxColumn11.HeaderText = "Product Company";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // txtpid
            // 
            this.txtpid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Id", true));
            this.txtpid.Location = new System.Drawing.Point(125, 12);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 20);
            this.txtpid.TabIndex = 3;
            // 
            // txtpname
            // 
            this.txtpname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Name", true));
            this.txtpname.Location = new System.Drawing.Point(125, 38);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 20);
            this.txtpname.TabIndex = 5;
            // 
            // txtpcategory
            // 
            this.txtpcategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Category", true));
            this.txtpcategory.Location = new System.Drawing.Point(125, 64);
            this.txtpcategory.Name = "txtpcategory";
            this.txtpcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpcategory.TabIndex = 7;
            // 
            // txtpprice
            // 
            this.txtpprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Price", true));
            this.txtpprice.Location = new System.Drawing.Point(125, 90);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(100, 20);
            this.txtpprice.TabIndex = 9;
            // 
            // txtpsprice
            // 
            this.txtpsprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Price", true));
            this.txtpsprice.Location = new System.Drawing.Point(125, 116);
            this.txtpsprice.Name = "txtpsprice";
            this.txtpsprice.Size = new System.Drawing.Size(100, 20);
            this.txtpsprice.TabIndex = 11;
            // 
            // txtpunit
            // 
            this.txtpunit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Unit", true));
            this.txtpunit.Location = new System.Drawing.Point(125, 142);
            this.txtpunit.Name = "txtpunit";
            this.txtpunit.Size = new System.Drawing.Size(100, 20);
            this.txtpunit.TabIndex = 13;
            // 
            // txtpuquantity
            // 
            this.txtpuquantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Unit Quantity", true));
            this.txtpuquantity.Location = new System.Drawing.Point(125, 168);
            this.txtpuquantity.Name = "txtpuquantity";
            this.txtpuquantity.Size = new System.Drawing.Size(100, 20);
            this.txtpuquantity.TabIndex = 15;
            // 
            // txtpquantity
            // 
            this.txtpquantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Quantity", true));
            this.txtpquantity.Location = new System.Drawing.Point(125, 194);
            this.txtpquantity.Name = "txtpquantity";
            this.txtpquantity.Size = new System.Drawing.Size(100, 20);
            this.txtpquantity.TabIndex = 17;
            // 
            // txtpdescription
            // 
            this.txtpdescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Description", true));
            this.txtpdescription.Location = new System.Drawing.Point(125, 220);
            this.txtpdescription.Name = "txtpdescription";
            this.txtpdescription.Size = new System.Drawing.Size(100, 20);
            this.txtpdescription.TabIndex = 19;
            // 
            // txtpdoe
            // 
            this.txtpdoe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Date of Entry", true));
            this.txtpdoe.Location = new System.Drawing.Point(125, 246);
            this.txtpdoe.Name = "txtpdoe";
            this.txtpdoe.Size = new System.Drawing.Size(100, 20);
            this.txtpdoe.TabIndex = 21;
            // 
            // txtpcompany
            // 
            this.txtpcompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource, "Product Company", true));
            this.txtpcompany.Location = new System.Drawing.Point(125, 272);
            this.txtpcompany.Name = "txtpcompany";
            this.txtpcompany.Size = new System.Drawing.Size(100, 20);
            this.txtpcompany.TabIndex = 23;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(69, 295);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fmupdateproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(product_IdLabel);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.txtpname);
            this.Controls.Add(product_CategoryLabel);
            this.Controls.Add(this.txtpcategory);
            this.Controls.Add(product_PriceLabel);
            this.Controls.Add(this.txtpprice);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtpsprice);
            this.Controls.Add(product_UnitLabel);
            this.Controls.Add(this.txtpunit);
            this.Controls.Add(unit_QuantityLabel);
            this.Controls.Add(this.txtpuquantity);
            this.Controls.Add(product_QuantityLabel);
            this.Controls.Add(this.txtpquantity);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.txtpdescription);
            this.Controls.Add(date_of_EntryLabel);
            this.Controls.Add(this.txtpdoe);
            this.Controls.Add(product_CompanyLabel);
            this.Controls.Add(this.txtpcompany);
            this.Controls.Add(this.productEntryDetailsDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmupdateproduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update/Delete Product Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmupdateproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet2 easyBillDatabaseEDataSet2;
        private System.Windows.Forms.BindingSource productEntryDetailsBindingSource;
        private EasyBillDatabaseEDataSet2TableAdapters.ProductEntryDetailsTableAdapter productEntryDetailsTableAdapter;
        private EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productEntryDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtpcategory;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.TextBox txtpsprice;
        private System.Windows.Forms.TextBox txtpunit;
        private System.Windows.Forms.TextBox txtpuquantity;
        private System.Windows.Forms.TextBox txtpquantity;
        private System.Windows.Forms.TextBox txtpdescription;
        private System.Windows.Forms.TextBox txtpdoe;
        private System.Windows.Forms.TextBox txtpcompany;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button button4;
    }
}