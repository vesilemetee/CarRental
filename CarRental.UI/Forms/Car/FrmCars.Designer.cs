namespace CarRental.UI.Forms.Car
{
    partial class FrmCars
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
            this.Durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_Car);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Listesi";
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
            this.Fotoğraf,
            this.Durum});
            this.lst_Car.FullRowSelect = true;
            this.lst_Car.GridLines = true;
            this.lst_Car.HideSelection = false;
            this.lst_Car.Location = new System.Drawing.Point(6, 39);
            this.lst_Car.Name = "lst_Car";
            this.lst_Car.Size = new System.Drawing.Size(1432, 310);
            this.lst_Car.TabIndex = 1;
            this.lst_Car.UseCompatibleStateImageBehavior = false;
            this.lst_Car.View = System.Windows.Forms.View.Details;

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
            this.Fotoğraf.Width = 175;
            // 
            // Durum
            // 
            this.Durum.Text = "Durum";
            this.Durum.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1224, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "ARABA VAR";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(1174, 58);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(44, 16);
            this.lblAdet.TabIndex = 21;
            this.lblAdet.Text = "ADET";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1154, 58);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 16);
            this.lblCount.TabIndex = 20;
            this.lblCount.Text = "0";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(551, 490);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(412, 201);
            this.pbPhoto.TabIndex = 25;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1657, 694);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Name = "FrmCars";
            this.Text = "FrmCars";
            this.Load += new System.EventHandler(this.FrmCars_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.ColumnHeader Durum;
    }
}