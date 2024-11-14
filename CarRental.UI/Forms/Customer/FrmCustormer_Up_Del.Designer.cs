namespace CarRental.UI.Forms.Customer
{
    partial class FrmCustormer_Up_Del
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Customer = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İSİM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOYİSİM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_Updat = new System.Windows.Forms.Button();
            this.txtttc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDrivingLicenseNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.mtxtNo = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmbDrivingLicenceType = new System.Windows.Forms.ComboBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Customer);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1691, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Listesi";
            // 
            // lst_Customer
            // 
            this.lst_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Tc,
            this.İSİM,
            this.SOYİSİM,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lst_Customer.FullRowSelect = true;
            this.lst_Customer.GridLines = true;
            this.lst_Customer.HideSelection = false;
            this.lst_Customer.Location = new System.Drawing.Point(17, 55);
            this.lst_Customer.Name = "lst_Customer";
            this.lst_Customer.Size = new System.Drawing.Size(1635, 310);
            this.lst_Customer.TabIndex = 0;
            this.lst_Customer.UseCompatibleStateImageBehavior = false;
            this.lst_Customer.View = System.Windows.Forms.View.Details;
            this.lst_Customer.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lst_Customer.Click += new System.EventHandler(this.lst_Customer_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 75;
            // 
            // Tc
            // 
            this.Tc.Text = "TC";
            this.Tc.Width = 124;
            // 
            // İSİM
            // 
            this.İSİM.Text = "İSİM";
            this.İSİM.Width = 157;
            // 
            // SOYİSİM
            // 
            this.SOYİSİM.Text = "SOYİSİM";
            this.SOYİSİM.Width = 129;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DOĞUM TARİHİ";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EHLİYET TÜRÜ";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EHLİYET NO";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELEFON";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E-MAİL";
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ADRES";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NOTLAR";
            this.columnHeader7.Width = 107;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(1064, 29);
            this.txt_Search.MaxLength = 11;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(191, 22);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.Text = "TC GİRİNİZ";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(613, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Updat
            // 
            this.btn_Updat.Location = new System.Drawing.Point(479, 508);
            this.btn_Updat.Name = "btn_Updat";
            this.btn_Updat.Size = new System.Drawing.Size(108, 50);
            this.btn_Updat.TabIndex = 4;
            this.btn_Updat.Text = "GÜNCELLE";
            this.btn_Updat.UseVisualStyleBackColor = true;
            this.btn_Updat.Click += new System.EventHandler(this.btn_Updat_Click);
            // 
            // txtttc
            // 
            this.txtttc.Location = new System.Drawing.Point(112, 455);
            this.txtttc.Name = "txtttc";
            this.txtttc.Size = new System.Drawing.Size(141, 22);
            this.txtttc.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(264, 455);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(386, 455);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // txtDrivingLicenseNo
            // 
            this.txtDrivingLicenseNo.Location = new System.Drawing.Point(760, 455);
            this.txtDrivingLicenseNo.Name = "txtDrivingLicenseNo";
            this.txtDrivingLicenseNo.Size = new System.Drawing.Size(108, 22);
            this.txtDrivingLicenseNo.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1005, 455);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(1152, 453);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(131, 92);
            this.txtAdres.TabIndex = 10;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(1289, 453);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(141, 92);
            this.txtNotes.TabIndex = 11;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // mtxtNo
            // 
            this.mtxtNo.Location = new System.Drawing.Point(875, 455);
            this.mtxtNo.Mask = "(999) 000-0000";
            this.mtxtNo.Name = "mtxtNo";
            this.mtxtNo.Size = new System.Drawing.Size(124, 22);
            this.mtxtNo.TabIndex = 12;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(534, 455);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(133, 22);
            this.dtpBirthdate.TabIndex = 13;
            // 
            // cmbDrivingLicenceType
            // 
            this.cmbDrivingLicenceType.FormattingEnabled = true;
            this.cmbDrivingLicenceType.Location = new System.Drawing.Point(674, 455);
            this.cmbDrivingLicenceType.Name = "cmbDrivingLicenceType";
            this.cmbDrivingLicenceType.Size = new System.Drawing.Size(80, 24);
            this.cmbDrivingLicenceType.TabIndex = 14;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1261, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 16);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "0";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1281, 32);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(44, 16);
            this.lblAdet.TabIndex = 16;
            this.lblAdet.Text = "ADET";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 455);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(77, 22);
            this.txtID.TabIndex = 17;
            // 
            // FrmCustormer_Up_Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1874, 568);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.cmbDrivingLicenceType);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.mtxtNo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDrivingLicenseNo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtttc);
            this.Controls.Add(this.btn_Updat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCustormer_Up_Del";
            this.Text = "FrmCustormer_Up_Del";
            this.Load += new System.EventHandler(this.FrmCustormer_Up_Del_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lst_Customer;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader İSİM;
        private System.Windows.Forms.ColumnHeader SOYİSİM;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_Updat;
        private System.Windows.Forms.TextBox txtttc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDrivingLicenseNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.MaskedTextBox mtxtNo;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.ComboBox cmbDrivingLicenceType;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox txtID;
    }
}