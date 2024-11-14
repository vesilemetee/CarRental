namespace CarRental.UI.Forms.Car
{
    partial class FrmCar_Up_Del
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
            this.lst_Car = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yıl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yakıt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Renk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ücret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fotoğraf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbGear = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPlaque = new System.Windows.Forms.TextBox();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnPictureInsert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPictureInsert);
            this.groupBox1.Controls.Add(this.lst_Car);
            this.groupBox1.Controls.Add(this.pbPhoto);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cmbGear);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtMarque);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPlaque);
            this.groupBox1.Controls.Add(this.cmbFuel);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 672);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Listesi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lst_Car
            // 
            this.lst_Car.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marka,
            this.Model,
            this.Plaka,
            this.Yıl,
            this.Yakıt,
            this.Vites,
            this.Km,
            this.Renk,
            this.Ücret,
            this.Fotoğraf});
            this.lst_Car.FullRowSelect = true;
            this.lst_Car.GridLines = true;
            this.lst_Car.HideSelection = false;
            this.lst_Car.Location = new System.Drawing.Point(16, 21);
            this.lst_Car.Name = "lst_Car";
            this.lst_Car.Size = new System.Drawing.Size(1432, 310);
            this.lst_Car.TabIndex = 30;
            this.lst_Car.UseCompatibleStateImageBehavior = false;
            this.lst_Car.View = System.Windows.Forms.View.Details;
            this.lst_Car.SelectedIndexChanged += new System.EventHandler(this.lst_Car_SelectedIndexChanged_1);
            this.lst_Car.Click += new System.EventHandler(this.lst_Car_Click_1);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 46;
            // 
            // Marka
            // 
            this.Marka.Text = "MARKA";
            this.Marka.Width = 125;
            // 
            // Model
            // 
            this.Model.Text = "MODEL";
            this.Model.Width = 130;
            // 
            // Plaka
            // 
            this.Plaka.Text = "PLAKA";
            this.Plaka.Width = 72;
            // 
            // Yıl
            // 
            this.Yıl.Text = "YIL";
            this.Yıl.Width = 119;
            // 
            // Yakıt
            // 
            this.Yakıt.Text = "YAKIT";
            this.Yakıt.Width = 102;
            // 
            // Vites
            // 
            this.Vites.Text = "VİTES";
            this.Vites.Width = 135;
            // 
            // Km
            // 
            this.Km.Text = "KM";
            this.Km.Width = 110;
            // 
            // Renk
            // 
            this.Renk.Text = "RENK";
            this.Renk.Width = 126;
            // 
            // Ücret
            // 
            this.Ücret.Text = "Ücret";
            this.Ücret.Width = 151;
            // 
            // Fotoğraf
            // 
            this.Fotoğraf.Text = "Fotoğraf";
            this.Fotoğraf.Width = 306;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(1138, 354);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(310, 193);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 29;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 357);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(44, 22);
            this.txtID.TabIndex = 28;
            // 
            // cmbGear
            // 
            this.cmbGear.FormattingEnabled = true;
            this.cmbGear.Location = new System.Drawing.Point(663, 355);
            this.cmbGear.Name = "cmbGear";
            this.cmbGear.Size = new System.Drawing.Size(98, 24);
            this.cmbGear.TabIndex = 27;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Location = new System.Drawing.Point(589, 417);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 74);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Update.Location = new System.Drawing.Point(458, 417);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(125, 74);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(767, 357);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(123, 22);
            this.txtKm.TabIndex = 24;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(66, 357);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(139, 22);
            this.txtBrand.TabIndex = 22;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(992, 357);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 22);
            this.txtPrice.TabIndex = 25;
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(211, 357);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(118, 22);
            this.txtMarque.TabIndex = 21;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(896, 357);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(90, 22);
            this.txtColor.TabIndex = 26;
            // 
            // txtPlaque
            // 
            this.txtPlaque.Location = new System.Drawing.Point(335, 357);
            this.txtPlaque.Name = "txtPlaque";
            this.txtPlaque.Size = new System.Drawing.Size(117, 22);
            this.txtPlaque.TabIndex = 20;
            // 
            // cmbFuel
            // 
            this.cmbFuel.FormattingEnabled = true;
            this.cmbFuel.Location = new System.Drawing.Point(541, 355);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(116, 24);
            this.cmbFuel.TabIndex = 23;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(458, 357);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 22);
            this.txtYear.TabIndex = 19;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(945, 32);
            this.txt_Search.MaxLength = 11;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(191, 22);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.Text = "MARKA GİRİNİZ";
            this.txt_Search.WordWrap = false;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1173, 32);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(44, 16);
            this.lblAdet.TabIndex = 18;
            this.lblAdet.Text = "ADET";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1153, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 16);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "0";
            // 
            // btnPictureInsert
            // 
            this.btnPictureInsert.Location = new System.Drawing.Point(1336, 553);
            this.btnPictureInsert.Name = "btnPictureInsert";
            this.btnPictureInsert.Size = new System.Drawing.Size(77, 53);
            this.btnPictureInsert.TabIndex = 30;
            this.btnPictureInsert.Text = "RESİM EKLE";
            this.btnPictureInsert.UseVisualStyleBackColor = true;
            this.btnPictureInsert.Click += new System.EventHandler(this.btnPictureInsert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCar_Up_Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1560, 728);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCar_Up_Del";
            this.Text = "FrmCar_Up_Del";
            this.Load += new System.EventHandler(this.FrmCar_Up_Del_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cmbGear;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPlaque;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnPictureInsert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lst_Car;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Plaka;
        private System.Windows.Forms.ColumnHeader Yıl;
        private System.Windows.Forms.ColumnHeader Yakıt;
        private System.Windows.Forms.ColumnHeader Vites;
        private System.Windows.Forms.ColumnHeader Km;
        private System.Windows.Forms.ColumnHeader Renk;
        private System.Windows.Forms.ColumnHeader Ücret;
        private System.Windows.Forms.ColumnHeader Fotoğraf;
    }
}