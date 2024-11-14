using CarRental.BusinessLayer;
using CarRental.TypeLayer;
using CarRental.DataLayer;
using CarRental.UI.Forms.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.UI.Forms.CarRental
{
    public partial class FrmCarRental : Form
    {

        public FrmCarRental()
        {
            InitializeComponent();
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        void Fill_Car_Combobox()
        {
            Cls_CarRental cls_CarRental = new Cls_CarRental();
            SqlDataReader araba = cls_CarRental.Brand_Listele1();
            while (araba.Read())
            {
                cmbBrand.Items.Add(araba[0]).ToString();
                txtMarque.Text = araba[1].ToString();
                txtPlaque.Text = araba[2].ToString();
                txtYear.Text = araba[3].ToString();
                txtFuel.Text = araba[4].ToString();
                txtGear.Text = araba[5].ToString();
                txtKm.Text = araba[6].ToString();
                txtColor.Text = araba[7].ToString();
                txtPrice.Text = araba[8].ToString();
                Car_Temizle();
            }
        }

        void Fill_Customer_Combobox()
        {
            Cls_CarRental cls_CarRental = new Cls_CarRental();
            SqlDataReader müsteri = cls_CarRental.Customer_Listele1();
            while (müsteri.Read())
            {
                cmbTC.Items.Add(müsteri[0]);
                txtName.Text = müsteri[1].ToString();
                txtSurname.Text = müsteri[2].ToString();
                dtpBirthdate.Text = müsteri[3].ToString();
                txtDrivingLicenceType.Text = (müsteri[4]).ToString();
                txtDrivingLicenseNo.Text = (müsteri[5]).ToString();
                mtxtNo.Text = müsteri[7].ToString();
                Customer_Temizle();
            }

        }

        void Car_Temizle()
        {
            //cmbBrand.Items.Clear();
            txtMarque.Clear();
            txtPlaque.Clear();
            txtYear.Clear();
            txtFuel.Clear();
            txtGear.Clear();
            txtKm.Clear();
            txtColor.Clear();
            txtPrice.Clear();
        }
        void Customer_Temizle()
        {
            //cmbBrand.Items.Clear();
            txtName.Clear();
            txtSurname.Clear();
            dtpBirthdate.Text = DateTime.Now.ToShortDateString();
            txtDrivingLicenceType.Clear();
            txtDrivingLicenseNo.Clear();
            mtxtNo.Clear();
        }
        void CarRental_Temizle()
        {
            dtpAlış.Text = DateTime.Now.ToShortDateString();
            dtpdönüş.Text = DateTime.Now.ToShortDateString();
            txtDay.Clear();
            txtCountPrice.Clear();
        }

        private void FrmCarRental_Load(object sender, EventArgs e)
        {
            Fill_Car_Combobox();
            Fill_Customer_Combobox();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_CarRental cls_CarRental = new Cls_CarRental();
            SqlDataReader araba = cls_CarRental.Brand_Listele(cmbBrand.Text);
            while (araba.Read())
            {
                cmbBrand.Items.Add(araba[1]).ToString();
                txtMarque.Text = araba[2].ToString();
                txtPlaque.Text = araba[3].ToString();
                txtYear.Text = araba[4].ToString();
                txtFuel.Text = araba[5].ToString();
                txtGear.Text = araba[6].ToString();
                txtKm.Text = araba[7].ToString();
                txtColor.Text = araba[8].ToString();
                txtPrice.Text = araba[9].ToString();

            }
        }
        

        private void cmbTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_CarRental cls_CarRental = new Cls_CarRental();
            SqlDataReader müsteri = cls_CarRental.Customer_Listele(cmbTC.Text);
            while (müsteri.Read())
            {
                cmbTC.Items.Add(müsteri[1]);
                txtName.Text = müsteri[2].ToString();
                txtSurname.Text = müsteri[3].ToString();
                dtpBirthdate.Text = müsteri[4].ToString();
                txtDrivingLicenceType.Text = müsteri[5].ToString();
                txtDrivingLicenseNo.Text = müsteri[6].ToString();
                mtxtNo.Text = müsteri[7].ToString();
            }

        }


        private void btnRental_Click(object sender, EventArgs e)
        {
            Cls_CarRental cls_CarRental = new Cls_CarRental();
            cls_CarRental.Marka = cmbBrand.Text;
            cls_CarRental.Model = txtMarque.Text;
            cls_CarRental.Plaka = txtPlaque.Text;
            cls_CarRental.Yıl = Convert.ToInt32(txtYear.Text);
            cls_CarRental.Yakıt = txtFuel.Text;
            cls_CarRental.Vites = txtGear.Text;
            cls_CarRental.Km = Convert.ToInt32(txtKm.Text);
            cls_CarRental.Renk = txtColor.Text;
            cls_CarRental.Tc = cmbTC.Text;
            cls_CarRental.Isim = txtName.Text;
            cls_CarRental.Soyisim = txtSurname.Text;
            cls_CarRental.DoğumTarihi = Convert.ToDateTime(dtpBirthdate.Value);
            cls_CarRental.EhliyetTürü = txtDrivingLicenceType.Text;
            cls_CarRental.EhliyetNo = Convert.ToInt32(txtDrivingLicenseNo.Text);
            cls_CarRental.Telefon = mtxtNo.Text;
            cls_CarRental.AlışTarihi = Convert.ToDateTime(dtpBirthdate.Value.ToString());
            cls_CarRental.TeslimTarihi = Convert.ToDateTime(dtpBirthdate.Value.ToString());
            cls_CarRental.KiraÜcreti = Convert.ToInt32(txtPrice.Text);
            cls_CarRental.ToplamGün = Convert.ToInt32(txtDay.Text);
            cls_CarRental.ToplamÜcret = Convert.ToInt32(txtCountPrice.Text);
            cls_CarRental.Durum = "Dolu";
            bool answer = cls_CarRental.Insert();
            if (answer == true)
            {
                Car_Temizle();
                Customer_Temizle();
                CarRental_Temizle();
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba Kiralandı", true, "insert"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba Kiralandı", false, "insert"));
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TimeSpan günfarkı = DateTime.Parse(dtpdönüş.Text) - DateTime.Parse(dtpAlış.Text);
            int fark = günfarkı.Days;//Gün farkı hesaplandı
            txtDay.Text = fark.ToString();
            txtCountPrice.Text = (fark * int.Parse(txtPrice.Text)).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
