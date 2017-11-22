namespace Assignment5
{
    partial class ContactForm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gboName = new System.Windows.Forms.GroupBox();
            this.gboEMailAndPhone = new System.Windows.Forms.GroupBox();
            this.txtEMailPersonal = new System.Windows.Forms.TextBox();
            this.txtEMailBus = new System.Windows.Forms.TextBox();
            this.lblEMailPersonal = new System.Windows.Forms.Label();
            this.lblEMailBus = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.gboAddress = new System.Windows.Forms.GroupBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnContactOK = new System.Windows.Forms.Button();
            this.gboName.SuspendLayout();
            this.gboEMailAndPhone.SuspendLayout();
            this.gboAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(634, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(634, 22);
            this.textBox1.TabIndex = 3;
            // 
            // gboName
            // 
            this.gboName.Controls.Add(this.textBox1);
            this.gboName.Controls.Add(this.txtFirstName);
            this.gboName.Controls.Add(this.lblLastName);
            this.gboName.Controls.Add(this.lblFirstName);
            this.gboName.Location = new System.Drawing.Point(25, 19);
            this.gboName.Name = "gboName";
            this.gboName.Size = new System.Drawing.Size(828, 100);
            this.gboName.TabIndex = 4;
            this.gboName.TabStop = false;
            this.gboName.Text = "Name";
            // 
            // gboEMailAndPhone
            // 
            this.gboEMailAndPhone.Controls.Add(this.txtEMailPersonal);
            this.gboEMailAndPhone.Controls.Add(this.txtEMailBus);
            this.gboEMailAndPhone.Controls.Add(this.lblEMailPersonal);
            this.gboEMailAndPhone.Controls.Add(this.lblEMailBus);
            this.gboEMailAndPhone.Controls.Add(this.txtCellPhone);
            this.gboEMailAndPhone.Controls.Add(this.txtHomePhone);
            this.gboEMailAndPhone.Controls.Add(this.lblCellPhone);
            this.gboEMailAndPhone.Controls.Add(this.lblHomePhone);
            this.gboEMailAndPhone.Location = new System.Drawing.Point(26, 134);
            this.gboEMailAndPhone.Name = "gboEMailAndPhone";
            this.gboEMailAndPhone.Size = new System.Drawing.Size(827, 196);
            this.gboEMailAndPhone.TabIndex = 5;
            this.gboEMailAndPhone.TabStop = false;
            this.gboEMailAndPhone.Text = "E-mail and Phones";
            // 
            // txtEMailPersonal
            // 
            this.txtEMailPersonal.Location = new System.Drawing.Point(175, 155);
            this.txtEMailPersonal.Name = "txtEMailPersonal";
            this.txtEMailPersonal.Size = new System.Drawing.Size(634, 22);
            this.txtEMailPersonal.TabIndex = 11;
            // 
            // txtEMailBus
            // 
            this.txtEMailBus.Location = new System.Drawing.Point(175, 114);
            this.txtEMailBus.Name = "txtEMailBus";
            this.txtEMailBus.Size = new System.Drawing.Size(634, 22);
            this.txtEMailBus.TabIndex = 10;
            // 
            // lblEMailPersonal
            // 
            this.lblEMailPersonal.AutoSize = true;
            this.lblEMailPersonal.Location = new System.Drawing.Point(15, 160);
            this.lblEMailPersonal.Name = "lblEMailPersonal";
            this.lblEMailPersonal.Size = new System.Drawing.Size(111, 17);
            this.lblEMailPersonal.TabIndex = 9;
            this.lblEMailPersonal.Text = "E-mail, Personal";
            // 
            // lblEMailBus
            // 
            this.lblEMailBus.AutoSize = true;
            this.lblEMailBus.Location = new System.Drawing.Point(15, 119);
            this.lblEMailBus.Name = "lblEMailBus";
            this.lblEMailBus.Size = new System.Drawing.Size(112, 17);
            this.lblEMailBus.TabIndex = 8;
            this.lblEMailBus.Text = "E-mail, Business";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(175, 72);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(634, 22);
            this.txtCellPhone.TabIndex = 7;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(175, 31);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(634, 22);
            this.txtHomePhone.TabIndex = 6;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(15, 77);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(76, 17);
            this.lblCellPhone.TabIndex = 5;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(15, 36);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(90, 17);
            this.lblHomePhone.TabIndex = 4;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // gboAddress
            // 
            this.gboAddress.Controls.Add(this.cboCountry);
            this.gboAddress.Controls.Add(this.txtZipCode);
            this.gboAddress.Controls.Add(this.lblCountry);
            this.gboAddress.Controls.Add(this.lblZipCode);
            this.gboAddress.Controls.Add(this.txtCity);
            this.gboAddress.Controls.Add(this.txtStreet);
            this.gboAddress.Controls.Add(this.lblCity);
            this.gboAddress.Controls.Add(this.lblStreet);
            this.gboAddress.Location = new System.Drawing.Point(26, 350);
            this.gboAddress.Name = "gboAddress";
            this.gboAddress.Size = new System.Drawing.Size(827, 196);
            this.gboAddress.TabIndex = 12;
            this.gboAddress.TabStop = false;
            this.gboAddress.Text = "Address";
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(175, 153);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(629, 24);
            this.cboCountry.TabIndex = 11;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(175, 114);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(634, 22);
            this.txtZipCode.TabIndex = 10;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(15, 160);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(15, 119);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 17);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(175, 72);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(634, 22);
            this.txtCity.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(175, 31);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(634, 22);
            this.txtStreet.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 77);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(15, 36);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street";
            // 
            // btnContactOK
            // 
            this.btnContactOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContactOK.Location = new System.Drawing.Point(960, 166);
            this.btnContactOK.Name = "btnContactOK";
            this.btnContactOK.Size = new System.Drawing.Size(91, 61);
            this.btnContactOK.TabIndex = 13;
            this.btnContactOK.Text = "OK";
            this.btnContactOK.UseVisualStyleBackColor = true;
            this.btnContactOK.Click += new System.EventHandler(this.btnContactOK_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 558);
            this.Controls.Add(this.btnContactOK);
            this.Controls.Add(this.gboAddress);
            this.Controls.Add(this.gboEMailAndPhone);
            this.Controls.Add(this.gboName);
            this.Name = "ContactForm";
            this.Text = "Form1";
            this.gboName.ResumeLayout(false);
            this.gboName.PerformLayout();
            this.gboEMailAndPhone.ResumeLayout(false);
            this.gboEMailAndPhone.PerformLayout();
            this.gboAddress.ResumeLayout(false);
            this.gboAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gboName;
        private System.Windows.Forms.GroupBox gboEMailAndPhone;
        private System.Windows.Forms.TextBox txtEMailPersonal;
        private System.Windows.Forms.TextBox txtEMailBus;
        private System.Windows.Forms.Label lblEMailPersonal;
        private System.Windows.Forms.Label lblEMailBus;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.GroupBox gboAddress;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnContactOK;
    }
}

