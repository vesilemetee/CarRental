using CarRental.BusinessLayer;
using CarRental.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRental.UI.Forms.Car
{
    public partial class FrmCarInsert : Form
    {
        public FrmCarInsert()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cls_Car cls_Car = new Cls_Car();
            cls_Car.Marka = txtBrand.Text;
            cls_Car.Model = txtMarque.Text;
            cls_Car.Plaka = txtPlaque.Text;
            cls_Car.Yıl = Convert.ToInt32(txtYear.Text);
            cls_Car.Yakıt = cmbFuel.Text;
            int FullTypeID = Cls_Car.Full_IDVer(cmbFuel.SelectedItem.ToString());
            cls_Car.Vites = cmbGear.Text;
            int GearTypeID = Cls_Car.Gear_IDVer(cmbGear.SelectedItem.ToString());
            cls_Car.Km = Convert.ToInt32(txtKm.Text);
            cls_Car.Renk = txtColor.Text;
            cls_Car.Ücret = Convert.ToDecimal(txtPrice.Text);
            cls_Car.Fotograf = pbPhoto.ImageLocation; 
            bool answer = cls_Car.Insert(FullTypeID, GearTypeID);
            if (answer == true)
            {
                Temizle();
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", true, "insert"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", false, "insert"));
            }
        }

        void Fill_Fuel_Combobox()
        {
            Cls_Car cls_Car = new Cls_Car();
            SqlDataReader YakıtTürü = cls_Car.Fuel_Listele();
            while (YakıtTürü.Read())
            {
                cmbFuel.Items.Add(YakıtTürü[0]);
            }
        }
        void Fill_Gear_Combobox()
        {
            Cls_Car cls_Car = new Cls_Car();
            SqlDataReader VitesTürü = cls_Car.Gear_Listele();
            while (VitesTürü.Read())
            {
                cmbGear.Items.Add(VitesTürü[0]);
            }
        }

        private void FrmCarInsert_Load(object sender, EventArgs e)
        {
            Fill_Fuel_Combobox();
            Fill_Gear_Combobox();
        }

        void Temizle()
        {
            txtBrand.Clear();
            txtMarque.Clear();
            txtPlaque.Clear();
            txtYear.Clear();
            txtKm.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            pbPhoto.ImageLocation="";
        }

        private void btnPictureInsert_Click(object sender, EventArgs e)
        {
            //pbPhoto.SizeMode = PictureBoxSizeMode.AutoSize;
            OpenFileDialog ofl = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pbPhoto.ImageLocation = openFileDialog1.FileName;
            //pbPhoto.ImageLocation = "~\\CarRental\\CarRental.UI\\Img";
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
