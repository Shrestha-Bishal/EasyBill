namespace EasyBill
{
    partial class fmsales
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
            System.Windows.Forms.Label cashierLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            this.easyBillDatabaseEDataSet14 = new EasyBill.EasyBillDatabaseEDataSet14();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new EasyBill.EasyBillDatabaseEDataSet14TableAdapters.SalesTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet14TableAdapters.TableAdapterManager();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_CategoryTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_TotalTextBox = new System.Windows.Forms.TextBox();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.total_AmountTextBox = new System.Windows.Forms.TextBox();
            this.cashierTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            product_NameLabel = new System.Windows.Forms.Label();
            product_CategoryLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            product_TotalLabel = new System.Windows.Forms.Label();
            vatLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            cashierLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(30, 11);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(78, 13);
            product_NameLabel.TabIndex = 1;
            product_NameLabel.Text = "Product Name:";
            // 
            // product_CategoryLabel
            // 
            product_CategoryLabel.AutoSize = true;
            product_CategoryLabel.Location = new System.Drawing.Point(30, 37);
            product_CategoryLabel.Name = "product_CategoryLabel";
            product_CategoryLabel.Size = new System.Drawing.Size(92, 13);
            product_CategoryLabel.TabIndex = 3;
            product_CategoryLabel.Text = "Product Category:";
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(30, 63);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(33, 13);
            rateLabel.TabIndex = 5;
            rateLabel.Text = "Rate:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(30, 89);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity:";
            // 
            // product_TotalLabel
            // 
            product_TotalLabel.AutoSize = true;
            product_TotalLabel.Location = new System.Drawing.Point(30, 115);
            product_TotalLabel.Name = "product_TotalLabel";
            product_TotalLabel.Size = new System.Drawing.Size(74, 13);
            product_TotalLabel.TabIndex = 9;
            product_TotalLabel.Text = "Product Total:";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new System.Drawing.Point(30, 141);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new System.Drawing.Size(26, 13);
            vatLabel.TabIndex = 11;
            vatLabel.Text = "Vat:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(30, 167);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(52, 13);
            discountLabel.TabIndex = 13;
            discountLabel.Text = "Discount:";
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.Location = new System.Drawing.Point(30, 193);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(73, 13);
            total_AmountLabel.TabIndex = 15;
            total_AmountLabel.Text = "Total Amount:";
            // 
            // cashierLabel
            // 
            cashierLabel.AutoSize = true;
            cashierLabel.Location = new System.Drawing.Point(30, 219);
            cashierLabel.Name = "cashierLabel";
            cashierLabel.Size = new System.Drawing.Size(45, 13);
            cashierLabel.TabIndex = 17;
            cashierLabel.Text = "Cashier:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(30, 245);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(30, 271);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 21;
            timeLabel.Text = "Time:";
            // 
            // easyBillDatabaseEDataSet14
            // 
            this.easyBillDatabaseEDataSet14.DataSetName = "EasyBillDatabaseEDataSet14";
            this.easyBillDatabaseEDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.easyBillDatabaseEDataSet14;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet14TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Product Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(128, 8);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_NameTextBox.TabIndex = 2;
            // 
            // product_CategoryTextBox
            // 
            this.product_CategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Product Category", true));
            this.product_CategoryTextBox.Location = new System.Drawing.Point(128, 34);
            this.product_CategoryTextBox.Name = "product_CategoryTextBox";
            this.product_CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_CategoryTextBox.TabIndex = 4;
            // 
            // rateTextBox
            // 
            this.rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Rate", true));
            this.rateTextBox.Location = new System.Drawing.Point(128, 60);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(100, 20);
            this.rateTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(128, 86);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // product_TotalTextBox
            // 
            this.product_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Product Total", true));
            this.product_TotalTextBox.Location = new System.Drawing.Point(128, 112);
            this.product_TotalTextBox.Name = "product_TotalTextBox";
            this.product_TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.product_TotalTextBox.TabIndex = 10;
            // 
            // vatTextBox
            // 
            this.vatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Vat", true));
            this.vatTextBox.Location = new System.Drawing.Point(128, 138);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(100, 20);
            this.vatTextBox.TabIndex = 12;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(128, 164);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 14;
            // 
            // total_AmountTextBox
            // 
            this.total_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Total Amount", true));
            this.total_AmountTextBox.Location = new System.Drawing.Point(128, 190);
            this.total_AmountTextBox.Name = "total_AmountTextBox";
            this.total_AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_AmountTextBox.TabIndex = 16;
            // 
            // cashierTextBox
            // 
            this.cashierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Cashier", true));
            this.cashierTextBox.Location = new System.Drawing.Point(128, 216);
            this.cashierTextBox.Name = "cashierTextBox";
            this.cashierTextBox.Size = new System.Drawing.Size(100, 20);
            this.cashierTextBox.TabIndex = 18;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(128, 242);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 20;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(128, 268);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 20);
            this.timeTextBox.TabIndex = 22;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(153, 294);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Save_Click);
            // 
            // fmsales
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 326);
            this.Controls.Add(this.btnsave);
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
            this.Controls.Add(cashierLabel);
            this.Controls.Add(this.cashierTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmsales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Entry";
            this.Load += new System.EventHandler(this.fmsalesentry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet14 easyBillDatabaseEDataSet14;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private EasyBillDatabaseEDataSet14TableAdapters.SalesTableAdapter salesTableAdapter;
        private EasyBillDatabaseEDataSet14TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox product_CategoryTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox product_TotalTextBox;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox total_AmountTextBox;
        private System.Windows.Forms.TextBox cashierTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button btnsave;
    }
}