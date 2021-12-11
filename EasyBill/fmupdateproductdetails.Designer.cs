namespace EasyBill
{
    partial class fmupdateproductdetails
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
            this.btnupdate = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
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
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(253, 290);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 50;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // product_IdLabel
            // 
            product_IdLabel.AutoSize = true;
            product_IdLabel.Location = new System.Drawing.Point(81, -16);
            product_IdLabel.Name = "product_IdLabel";
            product_IdLabel.Size = new System.Drawing.Size(59, 13);
            product_IdLabel.TabIndex = 28;
            product_IdLabel.Text = "Product Id:";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(147, -23);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 20);
            this.txtpid.TabIndex = 29;
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(24, 37);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 30;
            product_NameLabel.Text = "Product Name:";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(112, 30);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 20);
            this.txtpname.TabIndex = 31;
            // 
            // product_CategoryLabel
            // 
            product_CategoryLabel.AutoSize = true;
            product_CategoryLabel.Location = new System.Drawing.Point(10, 59);
            product_CategoryLabel.Name = "product_CategoryLabel";
            product_CategoryLabel.Size = new System.Drawing.Size(92, 13);
            product_CategoryLabel.TabIndex = 32;
            product_CategoryLabel.Text = "Product Category:";
            // 
            // txtpcategory
            // 
            this.txtpcategory.Location = new System.Drawing.Point(112, 56);
            this.txtpcategory.Name = "txtpcategory";
            this.txtpcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpcategory.TabIndex = 33;
            // 
            // product_PriceLabel
            // 
            product_PriceLabel.AutoSize = true;
            product_PriceLabel.Location = new System.Drawing.Point(27, 85);
            product_PriceLabel.Name = "product_PriceLabel";
            product_PriceLabel.Size = new System.Drawing.Size(74, 13);
            product_PriceLabel.TabIndex = 34;
            product_PriceLabel.Text = "Product Price:";
            // 
            // txtpprice
            // 
            this.txtpprice.Location = new System.Drawing.Point(112, 82);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.Size = new System.Drawing.Size(100, 20);
            this.txtpprice.TabIndex = 35;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(33, 111);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 13);
            priceLabel.TabIndex = 36;
            priceLabel.Text = "Selling Price:";
            // 
            // txtpsprice
            // 
            this.txtpsprice.Location = new System.Drawing.Point(112, 108);
            this.txtpsprice.Name = "txtpsprice";
            this.txtpsprice.Size = new System.Drawing.Size(100, 20);
            this.txtpsprice.TabIndex = 37;
            // 
            // product_UnitLabel
            // 
            product_UnitLabel.AutoSize = true;
            product_UnitLabel.Location = new System.Drawing.Point(33, 137);
            product_UnitLabel.Name = "product_UnitLabel";
            product_UnitLabel.Size = new System.Drawing.Size(69, 13);
            product_UnitLabel.TabIndex = 38;
            product_UnitLabel.Text = "Product Unit:";
            // 
            // txtpunit
            // 
            this.txtpunit.Location = new System.Drawing.Point(112, 134);
            this.txtpunit.Name = "txtpunit";
            this.txtpunit.Size = new System.Drawing.Size(100, 20);
            this.txtpunit.TabIndex = 39;
            // 
            // unit_QuantityLabel
            // 
            unit_QuantityLabel.AutoSize = true;
            unit_QuantityLabel.Location = new System.Drawing.Point(31, 163);
            unit_QuantityLabel.Name = "unit_QuantityLabel";
            unit_QuantityLabel.Size = new System.Drawing.Size(71, 13);
            unit_QuantityLabel.TabIndex = 40;
            unit_QuantityLabel.Text = "Unit Quantity:";
            // 
            // txtpuquantity
            // 
            this.txtpuquantity.Location = new System.Drawing.Point(112, 160);
            this.txtpuquantity.Name = "txtpuquantity";
            this.txtpuquantity.Size = new System.Drawing.Size(100, 20);
            this.txtpuquantity.TabIndex = 41;
            // 
            // product_QuantityLabel
            // 
            product_QuantityLabel.AutoSize = true;
            product_QuantityLabel.Location = new System.Drawing.Point(17, 189);
            product_QuantityLabel.Name = "product_QuantityLabel";
            product_QuantityLabel.Size = new System.Drawing.Size(89, 13);
            product_QuantityLabel.TabIndex = 42;
            product_QuantityLabel.Text = "Product Quantity:";
            // 
            // txtpquantity
            // 
            this.txtpquantity.Location = new System.Drawing.Point(112, 186);
            this.txtpquantity.Name = "txtpquantity";
            this.txtpquantity.Size = new System.Drawing.Size(100, 20);
            this.txtpquantity.TabIndex = 43;
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(3, 215);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(103, 13);
            product_DescriptionLabel.TabIndex = 44;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // txtpdescription
            // 
            this.txtpdescription.Location = new System.Drawing.Point(112, 212);
            this.txtpdescription.Name = "txtpdescription";
            this.txtpdescription.Size = new System.Drawing.Size(100, 20);
            this.txtpdescription.TabIndex = 45;
            // 
            // date_of_EntryLabel
            // 
            date_of_EntryLabel.AutoSize = true;
            date_of_EntryLabel.Location = new System.Drawing.Point(33, 241);
            date_of_EntryLabel.Name = "date_of_EntryLabel";
            date_of_EntryLabel.Size = new System.Drawing.Size(72, 13);
            date_of_EntryLabel.TabIndex = 46;
            date_of_EntryLabel.Text = "Date of Entry:";
            // 
            // txtpdoe
            // 
            this.txtpdoe.Location = new System.Drawing.Point(112, 238);
            this.txtpdoe.Name = "txtpdoe";
            this.txtpdoe.Size = new System.Drawing.Size(100, 20);
            this.txtpdoe.TabIndex = 47;
            // 
            // product_CompanyLabel
            // 
            product_CompanyLabel.AutoSize = true;
            product_CompanyLabel.Location = new System.Drawing.Point(8, 267);
            product_CompanyLabel.Name = "product_CompanyLabel";
            product_CompanyLabel.Size = new System.Drawing.Size(94, 13);
            product_CompanyLabel.TabIndex = 48;
            product_CompanyLabel.Text = "Product Company:";
            // 
            // txtpcompany
            // 
            this.txtpcompany.Location = new System.Drawing.Point(112, 264);
            this.txtpcompany.Name = "txtpcompany";
            this.txtpcompany.Size = new System.Drawing.Size(100, 20);
            this.txtpcompany.TabIndex = 49;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 52;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 53;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 54;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 55;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(228, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 56;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(228, 160);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 57;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(228, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 58;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(228, 212);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 59;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(228, 238);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 60;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(228, 264);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 61;
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
            this.productEntryDetailsDataGridView.Location = new System.Drawing.Point(345, 30);
            this.productEntryDetailsDataGridView.Name = "productEntryDetailsDataGridView";
            this.productEntryDetailsDataGridView.Size = new System.Drawing.Size(1002, 254);
            this.productEntryDetailsDataGridView.TabIndex = 62;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Update to:";
            // 
            // fmupdateproductdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productEntryDetailsDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmupdateproductdetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product Details";
            this.Load += new System.EventHandler(this.fmupdateproductdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
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
        private System.Windows.Forms.Label label1;
    }
}