namespace EasyBill
{
    partial class fmaddcontacts
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
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label mIddle_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label productsLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label mobile_Number_1Label;
            System.Windows.Forms.Label mobile_Number_2Label;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label emailLabel;
            this.easyBillDatabaseEDataSet5 = new EasyBill.EasyBillDatabaseEDataSet5();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new EasyBill.EasyBillDatabaseEDataSet5TableAdapters.ContactsTableAdapter();
            this.tableAdapterManager = new EasyBill.EasyBillDatabaseEDataSet5TableAdapters.TableAdapterManager();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtproducts = new System.Windows.Forms.TextBox();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtphno = new System.Windows.Forms.TextBox();
            this.txtmo = new System.Windows.Forms.TextBox();
            this.txtmono = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            first_NameLabel = new System.Windows.Forms.Label();
            mIddle_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            productsLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            mobile_Number_1Label = new System.Windows.Forms.Label();
            mobile_Number_2Label = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // easyBillDatabaseEDataSet5
            // 
            this.easyBillDatabaseEDataSet5.DataSetName = "EasyBillDatabaseEDataSet5";
            this.easyBillDatabaseEDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.easyBillDatabaseEDataSet5;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContactsTableAdapter = this.contactsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EasyBill.EasyBillDatabaseEDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(45, 14);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 1;
            first_NameLabel.Text = "First Name:";
            // 
            // txtfname
            // 
            this.txtfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "First Name", true));
            this.txtfname.Location = new System.Drawing.Point(111, 11);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 1;
            // 
            // mIddle_NameLabel
            // 
            mIddle_NameLabel.AutoSize = true;
            mIddle_NameLabel.Location = new System.Drawing.Point(234, 14);
            mIddle_NameLabel.Name = "mIddle_NameLabel";
            mIddle_NameLabel.Size = new System.Drawing.Size(73, 13);
            mIddle_NameLabel.TabIndex = 3;
            mIddle_NameLabel.Text = "MIddle Name:";
            // 
            // txtmname
            // 
            this.txtmname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "MIddle Name", true));
            this.txtmname.Location = new System.Drawing.Point(313, 11);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(100, 20);
            this.txtmname.TabIndex = 2;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(448, 14);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // txtlname
            // 
            this.txtlname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Last Name", true));
            this.txtlname.Location = new System.Drawing.Point(515, 11);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 3;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Location = new System.Drawing.Point(53, 52);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new System.Drawing.Size(52, 13);
            productsLabel.TabIndex = 7;
            productsLabel.Text = "Products:";
            // 
            // txtproducts
            // 
            this.txtproducts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Products", true));
            this.txtproducts.Location = new System.Drawing.Point(111, 46);
            this.txtproducts.Name = "txtproducts";
            this.txtproducts.Size = new System.Drawing.Size(100, 20);
            this.txtproducts.TabIndex = 4;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(253, 52);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 9;
            companyLabel.Text = "Company:";
            // 
            // txtcompany
            // 
            this.txtcompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Company", true));
            this.txtcompany.Location = new System.Drawing.Point(313, 49);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(100, 20);
            this.txtcompany.TabIndex = 5;
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(15, 89);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(81, 13);
            phone_NumberLabel.TabIndex = 11;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // txtphno
            // 
            this.txtphno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Phone Number", true));
            this.txtphno.Location = new System.Drawing.Point(111, 86);
            this.txtphno.Name = "txtphno";
            this.txtphno.Size = new System.Drawing.Size(100, 20);
            this.txtphno.TabIndex = 6;
            // 
            // mobile_Number_1Label
            // 
            mobile_Number_1Label.AutoSize = true;
            mobile_Number_1Label.Location = new System.Drawing.Point(15, 128);
            mobile_Number_1Label.Name = "mobile_Number_1Label";
            mobile_Number_1Label.Size = new System.Drawing.Size(90, 13);
            mobile_Number_1Label.TabIndex = 13;
            mobile_Number_1Label.Text = "Mobile Number 1:";
            // 
            // txtmo
            // 
            this.txtmo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Mobile Number 1", true));
            this.txtmo.Location = new System.Drawing.Point(111, 125);
            this.txtmo.Name = "txtmo";
            this.txtmo.Size = new System.Drawing.Size(100, 20);
            this.txtmo.TabIndex = 7;
            // 
            // mobile_Number_2Label
            // 
            mobile_Number_2Label.AutoSize = true;
            mobile_Number_2Label.Location = new System.Drawing.Point(234, 132);
            mobile_Number_2Label.Name = "mobile_Number_2Label";
            mobile_Number_2Label.Size = new System.Drawing.Size(90, 13);
            mobile_Number_2Label.TabIndex = 15;
            mobile_Number_2Label.Text = "Mobile Number 2:";
            // 
            // txtmono
            // 
            this.txtmono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Mobile Number 2", true));
            this.txtmono.Location = new System.Drawing.Point(385, 128);
            this.txtmono.Name = "txtmono";
            this.txtmono.Size = new System.Drawing.Size(124, 20);
            this.txtmono.TabIndex = 8;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(57, 170);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Address:";
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Address", true));
            this.txtaddress.Location = new System.Drawing.Point(111, 167);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(233, 172);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 19;
            cityLabel.Text = "City:";
            // 
            // txtcity
            // 
            this.txtcity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "City", true));
            this.txtcity.Location = new System.Drawing.Point(266, 169);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 20);
            this.txtcity.TabIndex = 10;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(385, 175);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 21;
            countryLabel.Text = "Country:";
            // 
            // txtcountry
            // 
            this.txtcountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Country", true));
            this.txtcountry.Location = new System.Drawing.Point(437, 172);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(100, 20);
            this.txtcountry.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(70, 219);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Email", true));
            this.txtemail.Location = new System.Drawing.Point(111, 216);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(154, 20);
            this.txtemail.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "(Optional)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "New Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmaddcontacts
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 266);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(mIddle_NameLabel);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(productsLabel);
            this.Controls.Add(this.txtproducts);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.txtcompany);
            this.Controls.Add(phone_NumberLabel);
            this.Controls.Add(this.txtphno);
            this.Controls.Add(mobile_Number_1Label);
            this.Controls.Add(this.txtmo);
            this.Controls.Add(mobile_Number_2Label);
            this.Controls.Add(this.txtmono);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtemail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmaddcontacts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Contacts";
            this.Load += new System.EventHandler(this.fmaddcontacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easyBillDatabaseEDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EasyBillDatabaseEDataSet5 easyBillDatabaseEDataSet5;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private EasyBillDatabaseEDataSet5TableAdapters.ContactsTableAdapter contactsTableAdapter;
        private EasyBillDatabaseEDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtproducts;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtphno;
        private System.Windows.Forms.TextBox txtmo;
        private System.Windows.Forms.TextBox txtmono;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}