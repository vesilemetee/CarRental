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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.UI.Forms.Car
{
    public partial class FrmCar_Up_Del : Form
    {
        public FrmCar_Up_Del()
        {
            InitializeComponent();
        }
        int ListViewID;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_Car cls_Car = new Cls_Car();
            cls_Car.ID = Convert.ToInt32(txtID.Text);
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
            bool answer = cls_Car.Update(FullTypeID,GearTypeID);
            if (answer == true)
            {
                Fill_ListView("all");
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", true, "update"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", false, "update"));
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Cls_Car cls_Car = new Cls_Car();
            cls_Car.ID = Convert.ToInt32(txtID.Text);
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
            cls_Car.Fotograf = pbPhoto.ImageLocation.ToString();
            bool answer = cls_Car.Delete(FullTypeID, GearTypeID);
            if (answer == true)
            {
                Fill_ListView("all");
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", true, "delete"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Araba", false, "delete"));
            }
        }

        private void FrmCar_Up_Del_Load(object sender, EventArgs e)
        {
            Fill_ListView("all");
            Fill_Fuel_Combobox();
            Fill_Gear_Combobox();
        }

        public void Fill_ListView(string Value)
        {
            lst_Car.Items.Clear();
            SqlDataReader arabalar;
            int count = 0;
            Cls_Car cls_Car = new Cls_Car();
            if (Value == "all")
            {
                arabalar = cls_Car.CarListele();
            }
            else
            {
                arabalar = cls_Car.Listele_Arama(txt_Search.Text);
            }

            while (arabalar.Read())
            {
                count++;
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = arabalar[0].ToString();
                listViewItem.SubItems.Add(arabalar[1].ToString());
                listViewItem.SubItems.Add(arabalar[2].ToString());
                listViewItem.SubItems.Add(arabalar[3].ToString());
                listViewItem.SubItems.Add(arabalar[4].ToString());
                listViewItem.SubItems.Add(arabalar[5].ToString());
                listViewItem.SubItems.Add(arabalar[6].ToString());
                listViewItem.SubItems.Add(arabalar[7].ToString());
                listViewItem.SubItems.Add(arabalar[8].ToString());
                listViewItem.SubItems.Add(arabalar[9].ToString());
                listViewItem.SubItems.Add(arabalar[10].ToString());
                lst_Car.Items.Add(listViewItem);
            }
            lblCount.Text = count.ToString();
            count = 0;
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

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            Fill_ListView("arama");
        }


        private void btnPictureInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pbPhoto.ImageLocation = openFileDialog1.FileName;
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void lst_Car_Click_1(object sender, EventArgs e)
        {
            ListViewID = Convert.ToInt32(lst_Car.FocusedItem.SubItems[0].Text);
            txtID.Text = lst_Car.FocusedItem.SubItems[0].Text;
            txtBrand.Text = lst_Car.FocusedItem.SubItems[1].Text;
            txtMarque.Text = lst_Car.FocusedItem.SubItems[2].Text;
            txtPlaque.Text = lst_Car.FocusedItem.SubItems[3].Text;
            txtYear.Text = lst_Car.FocusedItem.SubItems[4].Text;
            cmbFuel.Text = lst_Car.FocusedItem.SubItems[5].Text;
            cmbGear.Text = lst_Car.FocusedItem.SubItems[6].Text;
            txtKm.Text = lst_Car.FocusedItem.SubItems[7].Text;
            txtColor.Text = lst_Car.FocusedItem.SubItems[8].Text;
            txtPrice.Text = lst_Car.FocusedItem.SubItems[9].Text;
            pbPhoto.ImageLocation = lst_Car.FocusedItem.SubItems[10].ToString();
            //pbPhoto.ImageLocation = lst_Car.FocusedItem.SubItems[10].Text;
            //string yol = "C:\\Users\\VESİLE\\source\\repos\\CarRental\\CarRental.UI\\Img";
            //int id = int.Parse(lst_Car.SelectedItems[0].SubItems[0].Text);
            //string alan = lst_Car.SelectedItems[0].SubItems[10].Text;
            //pbPhoto.ImageLocation = yol + "/" + alan;
        }

        private void lst_Car_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
