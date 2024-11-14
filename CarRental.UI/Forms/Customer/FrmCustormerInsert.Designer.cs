namespace CarRental.UI.Forms.Customer
{
    partial class FrmCustormerInsert
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
            this.lblTC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDrivingLicenseNo = new System.Windows.Forms.TextBox();
            this.cmbDrivingLicenceType = new System.Windows.Forms.ComboBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblDrivingLicenceNo = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblDrivingLicenceType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtNo = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(125, 42);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(60, 29);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(111, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "İsim : ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(67, 100);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(118, 29);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Soyisim :";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthdate.Location = new System.Drawing.Point(6, 129);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(179, 29);
            this.lblBirthdate.TabIndex = 0;
            this.lblBirthdate.Text = "Doğum Tarihi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDrivingLicenseNo);
            this.groupBox1.Controls.Add(this.cmbDrivingLicenceType);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.lblDrivingLicenceNo);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblDrivingLicenceType);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Location = new System.Drawing.Point(26, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // txtDrivingLicenseNo
            // 
            this.txtDrivingLicenseNo.Location = new System.Drawing.Point(191, 192);
            this.txtDrivingLicenseNo.MaxLength = 6;
            this.txtDrivingLicenseNo.Name = "txtDrivingLicenseNo";
            this.txtDrivingLicenseNo.Size = new System.Drawing.Size(200, 22);
            this.txtDrivingLicenseNo.TabIndex = 5;
            // 
            // cmbDrivingLicenceType
            // 
            this.cmbDrivingLicenceType.FormattingEnabled = true;
            this.cmbDrivingLicenceType.Location = new System.Drawing.Point(191, 162);
            this.cmbDrivingLicenceType.Name = "cmbDrivingLicenceType";
            this.cmbDrivingLicenceType.Size = new System.Drawing.Size(200, 24);
            this.cmbDrivingLicenceType.TabIndex = 4;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(191, 135);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthdate.TabIndex = 3;
            // 
            // lblDrivingLicenceNo
            // 
            this.lblDrivingLicenceNo.AutoSize = true;
            this.lblDrivingLicenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrivingLicenceNo.Location = new System.Drawing.Point(42, 187);
            this.lblDrivingLicenceNo.Name = "lblDrivingLicenceNo";
            this.lblDrivingLicenceNo.Size = new System.Drawing.Size(143, 29);
            this.lblDrivingLicenceNo.TabIndex = 2;
            this.lblDrivingLicenceNo.Text = "Ehliyet No :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(191, 108);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(192, 46);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(199, 22);
            this.txtTc.TabIndex = 1;
            // 
            // lblDrivingLicenceType
            // 
            this.lblDrivingLicenceType.AutoSize = true;
            this.lblDrivingLicenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrivingLicenceType.Location = new System.Drawing.Point(23, 158);
            this.lblDrivingLicenceType.Name = "lblDrivingLicenceType";
            this.lblDrivingLicenceType.Size = new System.Drawing.Size(162, 29);
            this.lblDrivingLicenceType.TabIndex = 0;
            this.lblDrivingLicenceType.Text = "Ehliyet Türü :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.mtxtNo);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblAdres);
            this.groupBox2.Location = new System.Drawing.Point(26, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(191, 97);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 107);
            this.txtAdres.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // mtxtNo
            // 
            this.mtxtNo.Location = new System.Drawing.Point(191, 36);
            this.mtxtNo.Mask = "(999) 000-0000";
            this.mtxtNo.Name = "mtxtNo";
            this.mtxtNo.Size = new System.Drawing.Size(200, 22);
            this.mtxtNo.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(84, 32);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 29);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Telefon :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(96, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 29);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(102, 91);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(93, 29);
            this.lblAdres.TabIndex = 0;
            this.lblAdres.Text = "Adres :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNotes);
            this.groupBox3.Controls.Add(this.lblNot);
            this.groupBox3.Location = new System.Drawing.Point(26, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 190);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(192, 41);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(186, 107);
            this.txtNotes.TabIndex = 3;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(92, 41);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(94, 29);
            this.lblNot.TabIndex = 0;
            this.lblNot.Text = "Notlar :";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(197, 756);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(111, 60);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "KAYDET";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // FrmCustormerInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(480, 828);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustormerInsert";
            this.Text = "FrmCustormerInsert";
            this.Load += new System.EventHandler(this.FrmCustormerInsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDrivingLicenceType;
        private System.Windows.Forms.Label lblDrivingLicenceNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtDrivingLicenseNo;
        private System.Windows.Forms.ComboBox cmbDrivingLicenceType;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.MaskedTextBox mtxtNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Button btn_Insert;
    }
}