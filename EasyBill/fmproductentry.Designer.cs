namespace EasyBill
{
    partial class fmproductentry
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
            this.easyBillDatabaseEDataSet1 = new EasyBill.EasyBillDatabaseEDataSet1();
            this.productEntryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productEntryDetailsTableAdapter = new EasyBill.EasyBillDatabaseEDataSet1TableAdapters.ProductEntryDetailsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet1TableAdapters.TableAdapterManager();
            this.easyBillDatabaseEDataSet2 = new EasyBill.EasyBillDatabaseEDataSet2();
            this.productEntryDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productEntryDetailsTableAdapter1 = new EasyBill.EasyBillDatabaseEDataSet2TableAdapters.ProductEntryDetailsTableAdapter();
            this.tableAdapterManager1 = new EasyBill.EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager();
            this.txtpdid = new System.Windows.Forms.TextBox();
            this.txtpdname = new System.Windows.Forms.TextBox();
            this.txtpdcategory = new System.Windows.Forms.TextBox();
            this.txtpdppr = new System.Windows.Forms.TextBox();
            this.txtpdsp = new System.Windows.Forms.TextBox();
            this.txtpdunit = new System.Windows.Forms.TextBox();
            this.txtpdqu = new System.Windows.Forms.TextBox();
            this.txtpdpqu = new System.Windows.Forms.TextBox();
            this.txtpddes = new System.Windows.Forms.TextBox();
            this.txtpd = new System.Windows.Forms.TextBox();
            this.txtpdcom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IdLabel
            // 
            product_IdLabel.AutoSize = true;
            product_IdLabel.Location = new System.Drawing.Point(22, 51);
            product_IdLabel.Name = "product_IdLabel";
            product_IdLabel.Size = new System.Drawing.Size(59, 13);
            product_IdLabel.TabIndex = 0;
            product_IdLabel.Text = "Product Id:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(22, 77);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 2;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_CategoryLabel
            // 
            product_CategoryLabel.AutoSize = true;
            product_CategoryLabel.Location = new System.Drawing.Point(22, 103);
            product_CategoryLabel.Name = "product_CategoryLabel";
            product_CategoryLabel.Size = new System.Drawing.Size(92, 13);
            product_CategoryLabel.TabIndex = 4;
            product_CategoryLabel.Text = "Product Category:";
            // 
            // product_PriceLabel
            // 
            product_PriceLabel.AutoSize = true;
            product_PriceLabel.Location = new System.Drawing.Point(270, 51);
            product_PriceLabel.Name = "product_PriceLabel";
            product_PriceLabel.Size = new System.Drawing.Size(74, 13);
            product_PriceLabel.TabIndex = 6;
            product_PriceLabel.Text = "Product Price:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(270, 81);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Selling Price:";
            // 
            // product_UnitLabel
            // 
            product_UnitLabel.AutoSize = true;
            product_UnitLabel.Location = new System.Drawing.Point(22, 128);
            product_UnitLabel.Name = "product_UnitLabel";
            product_UnitLabel.Size = new System.Drawing.Size(69, 13);
            product_UnitLabel.TabIndex = 10;
            product_UnitLabel.Text = "Product Unit:";
            // 
            // unit_QuantityLabel
            // 
            unit_QuantityLabel.AutoSize = true;
            unit_QuantityLabel.Location = new System.Drawing.Point(22, 154);
            unit_QuantityLabel.Name = "unit_QuantityLabel";
            unit_QuantityLabel.Size = new System.Drawing.Size(71, 13);
            unit_QuantityLabel.TabIndex = 12;
            unit_QuantityLabel.Text = "Unit Quantity:";
            // 
            // product_QuantityLabel
            // 
            product_QuantityLabel.AutoSize = true;
            product_QuantityLabel.Location = new System.Drawing.Point(22, 185);
            product_QuantityLabel.Name = "product_QuantityLabel";
            product_QuantityLabel.Size = new System.Drawing.Size(89, 13);
            product_QuantityLabel.TabIndex = 14;
            product_QuantityLabel.Text = "Product Quantity:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Location = new System.Drawing.Point(22, 214);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(103, 13);
            product_DescriptionLabel.TabIndex = 16;
            product_DescriptionLabel.Text = "Product Description:";
            // 
            // date_of_EntryLabel
            // 
            date_of_EntryLabel.AutoSize = true;
            date_of_EntryLabel.Location = new System.Drawing.Point(9, 9);
            date_of_EntryLabel.Name = "date_of_EntryLabel";
            date_of_EntryLabel.Size = new System.Drawing.Size(72, 13);
            date_of_EntryLabel.TabIndex = 18;
            date_of_EntryLabel.Text = "Date of Entry:";
            // 
            // product_CompanyLabel
            // 
            product_CompanyLabel.AutoSize = true;
            product_CompanyLabel.Location = new System.Drawing.Point(22, 245);
            product_CompanyLabel.Name = "product_CompanyLabel";
            product_CompanyLabel.Size = new System.Drawing.Size(94, 13);
            product_CompanyLabel.TabIndex = 20;
            product_CompanyLabel.Text = "Product Company:";
            // 
            // easyBillDatabaseEDataSet1
            // 
            this.easyBillDatabaseEDataSet1.DataSetName = "EasyBillDatabaseEDataSet1";
            this.easyBillDatabaseEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productEntryDetailsBindingSource
            // 
            this.productEntryDetailsBindingSource.DataMember = "ProductEntryDetails";
            this.productEntryDetailsBindingSource.DataSource = this.easyBillDatabaseEDataSet1;
            // 
            // productEntryDetailsTableAdapter
            // 
            this.productEntryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductEntryDetailsTableAdapter = this.productEntryDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // easyBillDatabaseEDataSet2
            // 
            this.easyBillDatabaseEDataSet2.DataSetName = "EasyBillDatabaseEDataSet2";
            this.easyBillDatabaseEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productEntryDetailsBindingSource1
            // 
            this.productEntryDetailsBindingSource1.DataMember = "ProductEntryDetails";
            this.productEntryDetailsBindingSource1.DataSource = this.easyBillDatabaseEDataSet2;
            // 
            // productEntryDetailsTableAdapter1
            // 
            this.productEntryDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductEntryDetailsTableAdapter = this.productEntryDetailsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtpdid
            // 
            this.txtpdid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Id", true));
            this.txtpdid.Location = new System.Drawing.Point(131, 48);
            this.txtpdid.Name = "txtpdid";
            this.txtpdid.Size = new System.Drawing.Size(100, 20);
            this.txtpdid.TabIndex = 2;
            // 
            // txtpdname
            // 
            this.txtpdname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Name", true));
            this.txtpdname.Location = new System.Drawing.Point(131, 74);
            this.txtpdname.Name = "txtpdname";
            this.txtpdname.Size = new System.Drawing.Size(100, 20);
            this.txtpdname.TabIndex = 3;
            // 
            // txtpdcategory
            // 
            this.txtpdcategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Category", true));
            this.txtpdcategory.Location = new System.Drawing.Point(131, 100);
            this.txtpdcategory.Name = "txtpdcategory";
            this.txtpdcategory.Size = new System.Drawing.Size(100, 20);
            this.txtpdcategory.TabIndex = 5;
            // 
            // txtpdppr
            // 
            this.txtpdppr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Price", true));
            this.txtpdppr.Location = new System.Drawing.Point(379, 48);
            this.txtpdppr.Name = "txtpdppr";
            this.txtpdppr.Size = new System.Drawing.Size(100, 20);
            this.txtpdppr.TabIndex = 22;
            // 
            // txtpdsp
            // 
            this.txtpdsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Price", true));
            this.txtpdsp.Location = new System.Drawing.Point(379, 78);
            this.txtpdsp.Name = "txtpdsp";
            this.txtpdsp.Size = new System.Drawing.Size(100, 20);
            this.txtpdsp.TabIndex = 25;
            // 
            // txtpdunit
            // 
            this.txtpdunit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Unit", true));
            this.txtpdunit.Location = new System.Drawing.Point(131, 125);
            this.txtpdunit.Name = "txtpdunit";
            this.txtpdunit.Size = new System.Drawing.Size(100, 20);
            this.txtpdunit.TabIndex = 11;
            // 
            // txtpdqu
            // 
            this.txtpdqu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Unit Quantity", true));
            this.txtpdqu.Location = new System.Drawing.Point(131, 151);
            this.txtpdqu.Name = "txtpdqu";
            this.txtpdqu.Size = new System.Drawing.Size(100, 20);
            this.txtpdqu.TabIndex = 13;
            this.txtpdqu.TextChanged += new System.EventHandler(this.txtpdqu_TextChanged);
            // 
            // txtpdpqu
            // 
            this.txtpdpqu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Quantity", true));
            this.txtpdpqu.Enabled = false;
            this.txtpdpqu.Location = new System.Drawing.Point(131, 182);
            this.txtpdpqu.Name = "txtpdpqu";
            this.txtpdpqu.Size = new System.Drawing.Size(100, 20);
            this.txtpdpqu.TabIndex = 15;
            // 
            // txtpddes
            // 
            this.txtpddes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Description", true));
            this.txtpddes.Location = new System.Drawing.Point(131, 211);
            this.txtpddes.Name = "txtpddes";
            this.txtpddes.Size = new System.Drawing.Size(100, 20);
            this.txtpddes.TabIndex = 17;
            // 
            // txtpd
            // 
            this.txtpd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Date of Entry", true));
            this.txtpd.Location = new System.Drawing.Point(88, 6);
            this.txtpd.Name = "txtpd";
            this.txtpd.Size = new System.Drawing.Size(100, 20);
            this.txtpd.TabIndex = 1;
            // 
            // txtpdcom
            // 
            this.txtpdcom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEntryDetailsBindingSource1, "Product Company", true));
            this.txtpdcom.Location = new System.Drawing.Point(131, 242);
            this.txtpdcom.Name = "txtpdcom";
            this.txtpdcom.Size = new System.Drawing.Size(100, 20);
            this.txtpdcom.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmproductentry
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(product_IdLabel);
            this.Controls.Add(this.txtpdid);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.txtpdname);
            this.Controls.Add(product_CategoryLabel);
            this.Controls.Add(this.txtpdcategory);
            this.Controls.Add(product_PriceLabel);
            this.Controls.Add(this.txtpdppr);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtpdsp);
            this.Controls.Add(product_UnitLabel);
            this.Controls.Add(this.txtpdunit);
            this.Controls.Add(unit_QuantityLabel);
            this.Controls.Add(this.txtpdqu);
            this.Controls.Add(product_QuantityLabel);
            this.Controls.Add(this.txtpdpqu);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.txtpddes);
            this.Controls.Add(date_of_EntryLabel);
            this.Controls.Add(this.txtpd);
            this.Controls.Add(product_CompanyLabel);
            this.Controls.Add(this.txtpdcom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmproductentry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Entry";
            this.Load += new System.EventHandler(this.fmproductentry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntryDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet1 easyBillDatabaseEDataSet1;
        private System.Windows.Forms.BindingSource productEntryDetailsBindingSource;
        private EasyBillDatabaseEDataSet1TableAdapters.ProductEntryDetailsTableAdapter productEntryDetailsTableAdapter;
        private EasyBillDatabaseEDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private EasyBillDatabaseEDataSet2 easyBillDatabaseEDataSet2;
        private System.Windows.Forms.BindingSource productEntryDetailsBindingSource1;
        private EasyBillDatabaseEDataSet2TableAdapters.ProductEntryDetailsTableAdapter productEntryDetailsTableAdapter1;
        private EasyBillDatabaseEDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtpdid;
        private System.Windows.Forms.TextBox txtpdname;
        private System.Windows.Forms.TextBox txtpdcategory;
        private System.Windows.Forms.TextBox txtpdppr;
        private System.Windows.Forms.TextBox txtpdsp;
        private System.Windows.Forms.TextBox txtpdunit;
        private System.Windows.Forms.TextBox txtpdqu;
        private System.Windows.Forms.TextBox txtpdpqu;
        private System.Windows.Forms.TextBox txtpddes;
        private System.Windows.Forms.TextBox txtpd;
        private System.Windows.Forms.TextBox txtpdcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}