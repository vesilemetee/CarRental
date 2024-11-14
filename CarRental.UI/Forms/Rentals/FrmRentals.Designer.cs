namespace CarRental.UI.Forms.Rentals
{
    partial class FrmRentals
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Müşteri Bilgileri", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstRental = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yıl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yakıt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Km = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Renk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.İsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoğumTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EhliyetTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EhliyetNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlışTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KiraÜcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToplamGün = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToplamÜcret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRental);
            this.groupBox1.Location = new System.Drawing.Point(19, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1761, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Listesi";
            // 
            // lstRental
            // 
            this.lstRental.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Marka,
            this.Model,
            this.Plaka,
            this.Yıl,
            this.Yakıt,
            this.Vites,
            this.Km,
            this.Renk,
            this.Tc,
            this.İsim,
            this.Soyisim,
            this.DoğumTarihi,
            this.EhliyetTürü,
            this.EhliyetNo,
            this.Telefon,
            this.AlışTarihi,
            this.TeslimTarihi,
            this.KiraÜcreti,
            this.ToplamGün,
            this.ToplamÜcret,
            this.Durum});
            this.lstRental.FullRowSelect = true;
            listViewGroup1.Header = "Müşteri Bilgileri";
            listViewGroup1.Name = "Müşteri Bilgileri";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.lstRental.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstRental.HideSelection = false;
            this.lstRental.Location = new System.Drawing.Point(12, 40);
            this.lstRental.Name = "lstRental";
            this.lstRental.Size = new System.Drawing.Size(1749, 328);
            this.lstRental.TabIndex = 0;
            this.lstRental.UseCompatibleStateImageBehavior = false;
            this.lstRental.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Marka
            // 
            this.Marka.Text = "Marka";
            this.Marka.Width = 98;
            // 
            // Model
            // 
            this.Model.Text = "Model";
            // 
            // Plaka
            // 
            this.Plaka.Text = "Plaka";
            // 
            // Yıl
            // 
            this.Yıl.Text = "Yıl";
            // 
            // Yakıt
            // 
            this.Yakıt.Text = "Yakıt";
            // 
            // Vites
            // 
            this.Vites.Text = "Vites";
            // 
            // Km
            // 
            this.Km.Text = "Km";
            // 
            // Renk
            // 
            this.Renk.Text = "Renk";
            // 
            // Tc
            // 
            this.Tc.Text = "Tc";
            // 
            // İsim
            // 
            this.İsim.Text = "İsim";
            // 
            // Soyisim
            // 
            this.Soyisim.Text = "Soyisim";
            this.Soyisim.Width = 108;
            // 
            // DoğumTarihi
            // 
            this.DoğumTarihi.Text = "DoğumTarihi";
            this.DoğumTarihi.Width = 107;
            // 
            // EhliyetTürü
            // 
            this.EhliyetTürü.Text = "EhliyetTürü";
            this.EhliyetTürü.Width = 108;
            // 
            // EhliyetNo
            // 
            this.EhliyetNo.Text = "EhliyetNo";
            this.EhliyetNo.Width = 100;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 82;
            // 
            // AlışTarihi
            // 
            this.AlışTarihi.Text = "AlışTarihi";
            this.AlışTarihi.Width = 103;
            // 
            // TeslimTarihi
            // 
            this.TeslimTarihi.Text = "TeslimTarihi";
            this.TeslimTarihi.Width = 138;
            // 
            // KiraÜcreti
            // 
            this.KiraÜcreti.Text = "KiraÜcreti";
            this.KiraÜcreti.Width = 83;
            // 
            // ToplamGün
            // 
            this.ToplamGün.Text = "ToplamGün";
            this.ToplamGün.Width = 118;
            // 
            // ToplamÜcret
            // 
            this.ToplamÜcret.Text = "ToplamÜcret";
            this.ToplamÜcret.Width = 83;
            // 
            // Durum
            // 
            this.Durum.Text = "Durum";
            // 
            // FrmRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1792, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRentals";
            this.Text = "FrmRentals";
            this.Load += new System.EventHandler(this.FrmRentals_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstRental;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Marka;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Plaka;
        private System.Windows.Forms.ColumnHeader Yıl;
        private System.Windows.Forms.ColumnHeader Yakıt;
        private System.Windows.Forms.ColumnHeader Vites;
        private System.Windows.Forms.ColumnHeader Km;
        private System.Windows.Forms.ColumnHeader Renk;
        private System.Windows.Forms.ColumnHeader Tc;
        private System.Windows.Forms.ColumnHeader İsim;
        private System.Windows.Forms.ColumnHeader Soyisim;
        private System.Windows.Forms.ColumnHeader DoğumTarihi;
        private System.Windows.Forms.ColumnHeader EhliyetTürü;
        private System.Windows.Forms.ColumnHeader EhliyetNo;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader AlışTarihi;
        private System.Windows.Forms.ColumnHeader TeslimTarihi;
        private System.Windows.Forms.ColumnHeader KiraÜcreti;
        private System.Windows.Forms.ColumnHeader ToplamGün;
        private System.Windows.Forms.ColumnHeader ToplamÜcret;
        private System.Windows.Forms.ColumnHeader Durum;
    }
}