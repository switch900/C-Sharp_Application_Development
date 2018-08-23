namespace COMP2614Assign06
{
    partial class ClientEditDialog
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
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(373, 187);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 19;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            this.checkBoxCreditHold.Click += new System.EventHandler(this.CheckBoxCreditHold_Click);
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(12, 40);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(64, 13);
            this.labelClientCode.TabIndex = 1;
            this.labelClientCode.Text = "C&lient Code:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(12, 71);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 3;
            this.labelCompanyName.Text = "C&ompany Name:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(12, 108);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(57, 13);
            this.labelAddress1.TabIndex = 5;
            this.labelAddress1.Text = "Address &1:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(12, 145);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(57, 13);
            this.labelAddress2.TabIndex = 7;
            this.labelAddress2.Text = "Address &2:";
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxClientCode.Location = new System.Drawing.Point(93, 37);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientCode.TabIndex = 2;
            this.textBoxClientCode.Tag = "";
            this.textBoxClientCode.Click += new System.EventHandler(this.TextBoxClientCode_Click);
            this.textBoxClientCode.DoubleClick += new System.EventHandler(this.TextBoxClientCode_DoubleClick);
            this.textBoxClientCode.Leave += new System.EventHandler(this.TextBoxClientCode_Leave);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(93, 68);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 4;
            this.textBoxCompanyName.Click += new System.EventHandler(this.TextBoxCompanyName_Click);
            this.textBoxCompanyName.DoubleClick += new System.EventHandler(this.TextBoxCompanyName_DoubleClick);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(93, 105);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress1.TabIndex = 6;
            this.textBoxAddress1.Click += new System.EventHandler(this.TextBoxAddress1_Click_1);
            this.textBoxAddress1.DoubleClick += new System.EventHandler(this.TextBoxAddress1_DoubleClick);
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(93, 142);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress2.TabIndex = 8;
            this.textBoxAddress2.Click += new System.EventHandler(this.TextBoxAddress2_Click);
            this.textBoxAddress2.DoubleClick += new System.EventHandler(this.TextBoxAddress2_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(118, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(351, 33);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 10;
            this.textBoxCity.Click += new System.EventHandler(this.TextBoxCity_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(267, 40);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "C&ity:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(267, 71);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 11;
            this.labelProvince.Text = "&Province:";
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(351, 142);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.ShortcutsEnabled = false;
            this.textBoxYTDSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxYTDSales.TabIndex = 16;
            this.textBoxYTDSales.Click += new System.EventHandler(this.TextBoxYTDSales_Click);
            this.textBoxYTDSales.DoubleClick += new System.EventHandler(this.TextBoxYTDSales_DoubleClick);
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(267, 145);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(61, 13);
            this.labelYTDSales.TabIndex = 15;
            this.labelYTDSales.Text = "&YTD Sales:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPostalCode.Location = new System.Drawing.Point(351, 105);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 14;
            this.textBoxPostalCode.Click += new System.EventHandler(this.TextBoxPostalCode_Click);
            this.textBoxPostalCode.DoubleClick += new System.EventHandler(this.TextBoxPostalCode_DoubleClick);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(267, 108);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 13;
            this.labelPostalCode.Text = "Pos&tal Code:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(93, 184);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(181, 20);
            this.textBoxNotes.TabIndex = 18;
            this.textBoxNotes.Click += new System.EventHandler(this.TextBoxNotes_Click);
            this.textBoxNotes.DoubleClick += new System.EventHandler(this.TextBoxNotes_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "&Notes:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BC",
            "AB",
            "SK",
            "MB",
            "ON",
            "QC",
            "NB",
            "PE",
            "NS",
            "NL",
            "YT",
            "NT",
            "NU"});
            this.comboBox1.Location = new System.Drawing.Point(351, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Enter += new System.EventHandler(this.ComboBox1_Enter);
            // 
            // ClientEditDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(488, 270);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelClientCode);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Name = "ClientEditDialog";
            this.Text = "Client Edit Dialog";
            this.Load += new System.EventHandler(this.ProductEditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}