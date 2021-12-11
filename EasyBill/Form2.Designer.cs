﻿namespace EasyBill
{
    partial class Form2
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
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label product_CategoryLabel;
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label product_TotalLabel;
            System.Windows.Forms.Label vatLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label total_AmountLabel;
            this.btnRefresh = new System.Windows.Forms.Button();
            this.easyBillDatabaseEDataSet18 = new EasyBill.EasyBillDatabaseEDataSet18();
            this.salesEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesEntryTableAdapter = new EasyBill.EasyBillDatabaseEDataSet18TableAdapters.SalesEntryTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet18TableAdapters.TableAdapterManager();
            this.salesEntryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_CategoryTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_TotalTextBox = new System.Windows.Forms.TextBox();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.total_AmountTextBox = new System.Windows.Forms.TextBox();
            product_NameLabel = new System.Windows.Forms.Label();
            product_CategoryLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            product_TotalLabel = new System.Windows.Forms.Label();
            vatLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEntryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // easyBillDatabaseEDataSet18
            // 
            this.easyBillDatabaseEDataSet18.DataSetName = "EasyBillDatabaseEDataSet18";
            this.easyBillDatabaseEDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesEntryBindingSource
            // 
            this.salesEntryBindingSource.DataMember = "SalesEntry";
            this.salesEntryBindingSource.DataSource = this.easyBillDatabaseEDataSet18;
            // 
            // salesEntryTableAdapter
            // 
            this.salesEntryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SalesEntryTableAdapter = this.salesEntryTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet18TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesEntryDataGridView
            // 
            this.salesEntryDataGridView.AutoGenerateColumns = false;
            this.salesEntryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesEntryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.salesEntryDataGridView.DataSource = this.salesEntryBindingSource;
            this.salesEntryDataGridView.Location = new System.Drawing.Point(61, 3);
            this.salesEntryDataGridView.Name = "salesEntryDataGridView";
            this.salesEntryDataGridView.Size = new System.Drawing.Size(843, 459);
            this.salesEntryDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product Category";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vat";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Total Amount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(906, 9);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 2;
            product_NameLabel.Text = "Product Name:";
            product_NameLabel.Visible = false;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Product Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(962, 6);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 3;
            this.product_NameTextBox.Visible = false;
            // 
            // product_CategoryLabel
            // 
            product_CategoryLabel.AutoSize = true;
            product_CategoryLabel.Location = new System.Drawing.Point(909, 35);
            product_CategoryLabel.Name = "product_CategoryLabel";
            product_CategoryLabel.Size = new System.Drawing.Size(92, 13);
            product_CategoryLabel.TabIndex = 4;
            product_CategoryLabel.Text = "Product Category:";
            product_CategoryLabel.Visible = false;
            // 
            // product_CategoryTextBox
            // 
            this.product_CategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Product Category", true));
            this.product_CategoryTextBox.Location = new System.Drawing.Point(962, 32);
            this.product_CategoryTextBox.Name = "product_CategoryTextBox";
            this.product_CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_CategoryTextBox.TabIndex = 5;
            this.product_CategoryTextBox.Visible = false;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(928, 61);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(33, 13);
            rateLabel.TabIndex = 6;
            rateLabel.Text = "Rate:";
            rateLabel.Visible = false;
            // 
            // rateTextBox
            // 
            this.rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Rate", true));
            this.rateTextBox.Location = new System.Drawing.Point(962, 58);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 7;
            this.rateTextBox.Visible = false;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(911, 87);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            quantityLabel.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(962, 84);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 9;
            this.quantityTextBox.Visible = false;
            // 
            // product_TotalLabel
            // 
            product_TotalLabel.AutoSize = true;
            product_TotalLabel.Location = new System.Drawing.Point(908, 113);
            product_TotalLabel.Name = "product_TotalLabel";
            product_TotalLabel.Size = new System.Drawing.Size(74, 13);
            product_TotalLabel.TabIndex = 10;
            product_TotalLabel.Text = "Product Total:";
            product_TotalLabel.Visible = false;
            // 
            // product_TotalTextBox
            // 
            this.product_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Product Total", true));
            this.product_TotalTextBox.Location = new System.Drawing.Point(962, 110);
            this.product_TotalTextBox.Name = "product_TotalTextBox";
            this.product_TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_TotalTextBox.TabIndex = 11;
            this.product_TotalTextBox.Visible = false;
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new System.Drawing.Point(931, 141);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new System.Drawing.Size(26, 13);
            vatLabel.TabIndex = 12;
            vatLabel.Text = "Vat:";
            vatLabel.Visible = false;
            // 
            // vatTextBox
            // 
            this.vatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Vat", true));
            this.vatTextBox.Location = new System.Drawing.Point(962, 136);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(100, 20);
            this.vatTextBox.TabIndex = 13;
            this.vatTextBox.Visible = false;
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(910, 165);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(52, 13);
            discountLabel.TabIndex = 14;
            discountLabel.Text = "Discount:";
            discountLabel.Visible = false;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(962, 162);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 15;
            this.discountTextBox.Visible = false;
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.Location = new System.Drawing.Point(913, 191);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(73, 13);
            total_AmountLabel.TabIndex = 16;
            total_AmountLabel.Text = "Total Amount:";
            total_AmountLabel.Visible = false;
            // 
            // total_AmountTextBox
            // 
            this.total_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesEntryBindingSource, "Total Amount", true));
            this.total_AmountTextBox.Location = new System.Drawing.Point(962, 188);
            this.total_AmountTextBox.Name = "total_AmountTextBox";
            this.total_AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_AmountTextBox.TabIndex = 17;
            this.total_AmountTextBox.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 468);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(product_CategoryLabel);
            this.Controls.Add(this.product_CategoryTextBox);
            this.Controls.Add(rateLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(product_TotalLabel);
            this.Controls.Add(this.product_TotalTextBox);
            this.Controls.Add(vatLabel);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(total_AmountLabel);
            this.Controls.Add(this.total_AmountTextBox);
            this.Controls.Add(this.salesEntryDataGridView);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesEntryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private EasyBillDatabaseEDataSet18 easyBillDatabaseEDataSet18;
        private System.Windows.Forms.BindingSource salesEntryBindingSource;
        private EasyBillDatabaseEDataSet18TableAdapters.SalesEntryTableAdapter salesEntryTableAdapter;
        private EasyBillDatabaseEDataSet18TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView salesEntryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox product_CategoryTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox product_TotalTextBox;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox total_AmountTextBox;
    }
}