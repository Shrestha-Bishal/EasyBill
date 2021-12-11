namespace EasyBill
{
    partial class fmnewshipping
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
            System.Windows.Forms.Label customer_First_NameLabel;
            System.Windows.Forms.Label customer_Last_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label ship_to_nameLabel;
            System.Windows.Forms.Label shipping_AddressLabel;
            System.Windows.Forms.Label shipping_CityLabel;
            System.Windows.Forms.Label shipping_StateLabel;
            System.Windows.Forms.Label shipping_CountryLabel;
            System.Windows.Forms.Label date_of_ShippingLabel1;
            System.Windows.Forms.Label date_ReceivedLabel1;
            this.btnprinttoexcel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnewform = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnviewshipping = new System.Windows.Forms.Button();
            this.easyBillDatabaseEDataSet3 = new EasyBill.EasyBillDatabaseEDataSet3();
            this.customerDetailsForShippingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsForShippingTableAdapter = new EasyBill.EasyBillDatabaseEDataSet3TableAdapters.CustomerDetailsForShippingTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet3TableAdapters.TableAdapterManager();
            this.txtcfname = new System.Windows.Forms.TextBox();
            this.txtclname = new System.Windows.Forms.TextBox();
            this.txtcaddress = new System.Windows.Forms.TextBox();
            this.txtccity = new System.Windows.Forms.TextBox();
            this.txtccountry = new System.Windows.Forms.TextBox();
            this.txtcpostcode = new System.Windows.Forms.TextBox();
            this.txtcphone = new System.Windows.Forms.TextBox();
            this.txtcemail = new System.Windows.Forms.TextBox();
            this.txtccompany = new System.Windows.Forms.TextBox();
            this.txtcsname = new System.Windows.Forms.TextBox();
            this.txtcsaddress = new System.Windows.Forms.TextBox();
            this.txtcscity = new System.Windows.Forms.TextBox();
            this.txtcsstate = new System.Windows.Forms.TextBox();
            this.txtcscountry = new System.Windows.Forms.TextBox();
            this.txtcdshipping = new System.Windows.Forms.TextBox();
            this.txtcdreceived = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            customer_First_NameLabel = new System.Windows.Forms.Label();
            customer_Last_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            ship_to_nameLabel = new System.Windows.Forms.Label();
            shipping_AddressLabel = new System.Windows.Forms.Label();
            shipping_CityLabel = new System.Windows.Forms.Label();
            shipping_StateLabel = new System.Windows.Forms.Label();
            shipping_CountryLabel = new System.Windows.Forms.Label();
            date_of_ShippingLabel1 = new System.Windows.Forms.Label();
            date_ReceivedLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsForShippingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_First_NameLabel
            // 
            customer_First_NameLabel.AutoSize = true;
            customer_First_NameLabel.Location = new System.Drawing.Point(10, 138);
            customer_First_NameLabel.Name = "customer_First_NameLabel";
            customer_First_NameLabel.Size = new System.Drawing.Size(107, 13);
            customer_First_NameLabel.TabIndex = 106;
            customer_First_NameLabel.Text = "Customer First Name:";
            // 
            // customer_Last_NameLabel
            // 
            customer_Last_NameLabel.AutoSize = true;
            customer_Last_NameLabel.Location = new System.Drawing.Point(10, 164);
            customer_Last_NameLabel.Name = "customer_Last_NameLabel";
            customer_Last_NameLabel.Size = new System.Drawing.Size(108, 13);
            customer_Last_NameLabel.TabIndex = 108;
            customer_Last_NameLabel.Text = "Customer Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(69, 196);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 110;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(90, 222);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 112;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(72, 248);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 114;
            countryLabel.Text = "Country:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(58, 274);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(59, 13);
            post_CodeLabel.TabIndex = 116;
            post_CodeLabel.Text = "Post Code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(77, 300);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 118;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(82, 326);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 120;
            emailLabel.Text = "Email:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(63, 352);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 122;
            companyLabel.Text = "Company:";
            // 
            // ship_to_nameLabel
            // 
            ship_to_nameLabel.AutoSize = true;
            ship_to_nameLabel.Location = new System.Drawing.Point(271, 115);
            ship_to_nameLabel.Name = "ship_to_nameLabel";
            ship_to_nameLabel.Size = new System.Drawing.Size(72, 13);
            ship_to_nameLabel.TabIndex = 124;
            ship_to_nameLabel.Text = "Ship to name:";
            // 
            // shipping_AddressLabel
            // 
            shipping_AddressLabel.AutoSize = true;
            shipping_AddressLabel.Location = new System.Drawing.Point(251, 138);
            shipping_AddressLabel.Name = "shipping_AddressLabel";
            shipping_AddressLabel.Size = new System.Drawing.Size(92, 13);
            shipping_AddressLabel.TabIndex = 126;
            shipping_AddressLabel.Text = "Shipping Address:";
            // 
            // shipping_CityLabel
            // 
            shipping_CityLabel.AutoSize = true;
            shipping_CityLabel.Location = new System.Drawing.Point(271, 167);
            shipping_CityLabel.Name = "shipping_CityLabel";
            shipping_CityLabel.Size = new System.Drawing.Size(71, 13);
            shipping_CityLabel.TabIndex = 128;
            shipping_CityLabel.Text = "Shipping City:";
            // 
            // shipping_StateLabel
            // 
            shipping_StateLabel.AutoSize = true;
            shipping_StateLabel.Location = new System.Drawing.Point(264, 194);
            shipping_StateLabel.Name = "shipping_StateLabel";
            shipping_StateLabel.Size = new System.Drawing.Size(79, 13);
            shipping_StateLabel.TabIndex = 130;
            shipping_StateLabel.Text = "Shipping State:";
            // 
            // shipping_CountryLabel
            // 
            shipping_CountryLabel.AutoSize = true;
            shipping_CountryLabel.Location = new System.Drawing.Point(253, 224);
            shipping_CountryLabel.Name = "shipping_CountryLabel";
            shipping_CountryLabel.Size = new System.Drawing.Size(90, 13);
            shipping_CountryLabel.TabIndex = 132;
            shipping_CountryLabel.Text = "Shipping Country:";
            // 
            // date_of_ShippingLabel1
            // 
            date_of_ShippingLabel1.AutoSize = true;
            date_of_ShippingLabel1.Location = new System.Drawing.Point(28, 112);
            date_of_ShippingLabel1.Name = "date_of_ShippingLabel1";
            date_of_ShippingLabel1.Size = new System.Drawing.Size(89, 13);
            date_of_ShippingLabel1.TabIndex = 134;
            date_of_ShippingLabel1.Text = "Date of Shipping:";
            // 
            // date_ReceivedLabel1
            // 
            date_ReceivedLabel1.AutoSize = true;
            date_ReceivedLabel1.Location = new System.Drawing.Point(261, 248);
            date_ReceivedLabel1.Name = "date_ReceivedLabel1";
            date_ReceivedLabel1.Size = new System.Drawing.Size(82, 13);
            date_ReceivedLabel1.TabIndex = 136;
            date_ReceivedLabel1.Text = "Date Received:";
            // 
            // btnprinttoexcel
            // 
            this.btnprinttoexcel.Location = new System.Drawing.Point(291, 290);
            this.btnprinttoexcel.Name = "btnprinttoexcel";
            this.btnprinttoexcel.Size = new System.Drawing.Size(87, 23);
            this.btnprinttoexcel.TabIndex = 83;
            this.btnprinttoexcel.Text = "Print to Excel";
            this.btnprinttoexcel.UseVisualStyleBackColor = true;
            this.btnprinttoexcel.Click += new System.EventHandler(this.btnprinttoexcel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(384, 290);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 82;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnewform
            // 
            this.btnnewform.Location = new System.Drawing.Point(375, 12);
            this.btnnewform.Name = "btnnewform";
            this.btnnewform.Size = new System.Drawing.Size(75, 23);
            this.btnnewform.TabIndex = 105;
            this.btnnewform.Text = "New Form";
            this.btnnewform.UseVisualStyleBackColor = true;
            this.btnnewform.Click += new System.EventHandler(this.btnnewform_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Shipping Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Customer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "If Shipping to a location other than customer address, please fill in all fields";
            // 
            // btnviewshipping
            // 
            this.btnviewshipping.Location = new System.Drawing.Point(244, 12);
            this.btnviewshipping.Name = "btnviewshipping";
            this.btnviewshipping.Size = new System.Drawing.Size(125, 23);
            this.btnviewshipping.TabIndex = 100;
            this.btnviewshipping.Text = "View Shipping Details";
            this.btnviewshipping.UseVisualStyleBackColor = true;
            this.btnviewshipping.Click += new System.EventHandler(this.btnviewshipping_Click);
            // 
            // easyBillDatabaseEDataSet3
            // 
            this.easyBillDatabaseEDataSet3.DataSetName = "EasyBillDatabaseEDataSet3";
            this.easyBillDatabaseEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsForShippingBindingSource
            // 
            this.customerDetailsForShippingBindingSource.DataMember = "CustomerDetailsForShipping";
            this.customerDetailsForShippingBindingSource.DataSource = this.easyBillDatabaseEDataSet3;
            // 
            // customerDetailsForShippingTableAdapter
            // 
            this.customerDetailsForShippingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerDetailsForShippingTableAdapter = this.customerDetailsForShippingTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtcfname
            // 
            this.txtcfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Customer First Name", true));
            this.txtcfname.Location = new System.Drawing.Point(124, 135);
            this.txtcfname.Name = "txtcfname";
            this.txtcfname.Size = new System.Drawing.Size(100, 20);
            this.txtcfname.TabIndex = 2;
            // 
            // txtclname
            // 
            this.txtclname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Customer Last Name", true));
            this.txtclname.Location = new System.Drawing.Point(124, 161);
            this.txtclname.Name = "txtclname";
            this.txtclname.Size = new System.Drawing.Size(100, 20);
            this.txtclname.TabIndex = 3;
            // 
            // txtcaddress
            // 
            this.txtcaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Address", true));
            this.txtcaddress.Location = new System.Drawing.Point(124, 193);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(100, 20);
            this.txtcaddress.TabIndex = 4;
            // 
            // txtccity
            // 
            this.txtccity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "City", true));
            this.txtccity.Location = new System.Drawing.Point(124, 219);
            this.txtccity.Name = "txtccity";
            this.txtccity.Size = new System.Drawing.Size(100, 20);
            this.txtccity.TabIndex = 5;
            // 
            // txtccountry
            // 
            this.txtccountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Country", true));
            this.txtccountry.Location = new System.Drawing.Point(124, 245);
            this.txtccountry.Name = "txtccountry";
            this.txtccountry.Size = new System.Drawing.Size(100, 20);
            this.txtccountry.TabIndex = 6;
            // 
            // txtcpostcode
            // 
            this.txtcpostcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Post Code", true));
            this.txtcpostcode.Location = new System.Drawing.Point(124, 271);
            this.txtcpostcode.Name = "txtcpostcode";
            this.txtcpostcode.Size = new System.Drawing.Size(100, 20);
            this.txtcpostcode.TabIndex = 7;
            // 
            // txtcphone
            // 
            this.txtcphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Phone", true));
            this.txtcphone.Location = new System.Drawing.Point(124, 297);
            this.txtcphone.Name = "txtcphone";
            this.txtcphone.Size = new System.Drawing.Size(100, 20);
            this.txtcphone.TabIndex = 8;
            // 
            // txtcemail
            // 
            this.txtcemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Email", true));
            this.txtcemail.Location = new System.Drawing.Point(124, 323);
            this.txtcemail.Name = "txtcemail";
            this.txtcemail.Size = new System.Drawing.Size(100, 20);
            this.txtcemail.TabIndex = 9;
            // 
            // txtccompany
            // 
            this.txtccompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Company", true));
            this.txtccompany.Location = new System.Drawing.Point(124, 349);
            this.txtccompany.Name = "txtccompany";
            this.txtccompany.Size = new System.Drawing.Size(100, 20);
            this.txtccompany.TabIndex = 10;
            // 
            // txtcsname
            // 
            this.txtcsname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Ship to name", true));
            this.txtcsname.Location = new System.Drawing.Point(355, 112);
            this.txtcsname.Name = "txtcsname";
            this.txtcsname.Size = new System.Drawing.Size(100, 20);
            this.txtcsname.TabIndex = 11;
            // 
            // txtcsaddress
            // 
            this.txtcsaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Shipping Address", true));
            this.txtcsaddress.Location = new System.Drawing.Point(355, 138);
            this.txtcsaddress.Name = "txtcsaddress";
            this.txtcsaddress.Size = new System.Drawing.Size(100, 20);
            this.txtcsaddress.TabIndex = 12;
            // 
            // txtcscity
            // 
            this.txtcscity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Shipping City", true));
            this.txtcscity.Location = new System.Drawing.Point(355, 164);
            this.txtcscity.Name = "txtcscity";
            this.txtcscity.Size = new System.Drawing.Size(100, 20);
            this.txtcscity.TabIndex = 13;
            // 
            // txtcsstate
            // 
            this.txtcsstate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Shipping State", true));
            this.txtcsstate.Location = new System.Drawing.Point(355, 191);
            this.txtcsstate.Name = "txtcsstate";
            this.txtcsstate.Size = new System.Drawing.Size(100, 20);
            this.txtcsstate.TabIndex = 14;
            // 
            // txtcscountry
            // 
            this.txtcscountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Shipping Country", true));
            this.txtcscountry.Location = new System.Drawing.Point(355, 217);
            this.txtcscountry.Name = "txtcscountry";
            this.txtcscountry.Size = new System.Drawing.Size(100, 20);
            this.txtcscountry.TabIndex = 15;
            // 
            // txtcdshipping
            // 
            this.txtcdshipping.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Date of Shipping", true));
            this.txtcdshipping.Location = new System.Drawing.Point(123, 109);
            this.txtcdshipping.Name = "txtcdshipping";
            this.txtcdshipping.Size = new System.Drawing.Size(100, 20);
            this.txtcdshipping.TabIndex = 1;
            // 
            // txtcdreceived
            // 
            this.txtcdreceived.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerDetailsForShippingBindingSource, "Date Received", true));
            this.txtcdreceived.Location = new System.Drawing.Point(355, 245);
            this.txtcdreceived.Name = "txtcdreceived";
            this.txtcdreceived.Size = new System.Drawing.Size(100, 20);
            this.txtcdreceived.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmnewshipping
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(473, 377);
            this.Controls.Add(customer_First_NameLabel);
            this.Controls.Add(this.txtcfname);
            this.Controls.Add(customer_Last_NameLabel);
            this.Controls.Add(this.txtclname);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtccity);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtccountry);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.txtcpostcode);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtcphone);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtcemail);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.txtccompany);
            this.Controls.Add(ship_to_nameLabel);
            this.Controls.Add(this.txtcsname);
            this.Controls.Add(shipping_AddressLabel);
            this.Controls.Add(this.txtcsaddress);
            this.Controls.Add(shipping_CityLabel);
            this.Controls.Add(this.txtcscity);
            this.Controls.Add(shipping_StateLabel);
            this.Controls.Add(this.txtcsstate);
            this.Controls.Add(shipping_CountryLabel);
            this.Controls.Add(this.txtcscountry);
            this.Controls.Add(date_of_ShippingLabel1);
            this.Controls.Add(this.txtcdshipping);
            this.Controls.Add(date_ReceivedLabel1);
            this.Controls.Add(this.txtcdreceived);
            this.Controls.Add(this.btnnewform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnviewshipping);
            this.Controls.Add(this.btnprinttoexcel);
            this.Controls.Add(this.btnsave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmnewshipping";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Shipping";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsForShippingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprinttoexcel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnewform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnviewshipping;
        private EasyBillDatabaseEDataSet3 easyBillDatabaseEDataSet3;
        private System.Windows.Forms.BindingSource customerDetailsForShippingBindingSource;
        private EasyBillDatabaseEDataSet3TableAdapters.CustomerDetailsForShippingTableAdapter customerDetailsForShippingTableAdapter;
        private EasyBillDatabaseEDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtcfname;
        private System.Windows.Forms.TextBox txtclname;
        private System.Windows.Forms.TextBox txtcaddress;
        private System.Windows.Forms.TextBox txtccity;
        private System.Windows.Forms.TextBox txtccountry;
        private System.Windows.Forms.TextBox txtcpostcode;
        private System.Windows.Forms.TextBox txtcphone;
        private System.Windows.Forms.TextBox txtcemail;
        private System.Windows.Forms.TextBox txtccompany;
        private System.Windows.Forms.TextBox txtcsname;
        private System.Windows.Forms.TextBox txtcsaddress;
        private System.Windows.Forms.TextBox txtcscity;
        private System.Windows.Forms.TextBox txtcsstate;
        private System.Windows.Forms.TextBox txtcscountry;
        private System.Windows.Forms.TextBox txtcdshipping;
        private System.Windows.Forms.TextBox txtcdreceived;
        private System.Windows.Forms.Timer timer1;
    }
}