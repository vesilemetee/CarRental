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

namespace CarRental.UI.Forms.Customer
{
    public partial class FrmCustormer_Up_Del : Form
    {
        public FrmCustormer_Up_Del()
        {
            InitializeComponent();
        }

        string ListViewID;
        int ListviewID;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Updat_Click(object sender, EventArgs e)
        {
            Cls_Customer cls_Customer = new Cls_Customer();
            cls_Customer.ID = Convert.ToInt32(txtID.Text);
            cls_Customer.Tc = txtttc.Text;
            cls_Customer.Isim = txtName.Text;
            cls_Customer.Soyisim = txtSurname.Text;
            cls_Customer.DoğumTarihi = Convert.ToDateTime(dtpBirthdate.Value);
            cls_Customer.EhliyetTürü = cmbDrivingLicenceType.Text;
            int DrivingLicenceTypeID = Cls_Customer.IDVer(cmbDrivingLicenceType.SelectedItem.ToString());
            cls_Customer.EhliyetNo = Convert.ToInt32(txtDrivingLicenseNo.Text);
            cls_Customer.Telefon = mtxtNo.Text;
            cls_Customer.Email = txtEmail.Text;
            cls_Customer.Adres = txtAdres.Text;
            cls_Customer.Notlar = txtNotes.Text;
            bool answer = cls_Customer.Update(DrivingLicenceTypeID);
            if (answer == true)
            {
                Fill_ListView("all");
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", true, "update"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", false, "update"));
            }
        }

        private void FrmCustormer_Up_Del_Load(object sender, EventArgs e)
        {
            Fill_ListView("all");
            Fill_DrivingLicenceType_Combobox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Cls_Customer cls_Customer = new Cls_Customer();
            cls_Customer.ID = Convert.ToInt32(txtID.Text);
            cls_Customer.Tc = txtttc.Text;
            cls_Customer.Isim = txtName.Text;
            cls_Customer.Soyisim = txtSurname.Text;
            cls_Customer.DoğumTarihi = Convert.ToDateTime(dtpBirthdate.Value);
            cls_Customer.EhliyetTürü = cmbDrivingLicenceType.Text;
            int DrivingLicenceTypeID = Cls_Customer.IDVer(cmbDrivingLicenceType.SelectedItem.ToString());
            cls_Customer.EhliyetNo = Convert.ToInt32(txtDrivingLicenseNo.Text);
            cls_Customer.Telefon = mtxtNo.Text;
            cls_Customer.Email = txtEmail.Text;
            cls_Customer.Adres = txtAdres.Text;
            cls_Customer.Notlar = txtNotes.Text;
            bool answer = cls_Customer.Delete(DrivingLicenceTypeID);
            if (answer == true)
            {
                Fill_ListView("all");
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", true, "delete"));
            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", false, "delete"));
            }
        }


        private void lst_Customer_Click(object sender, EventArgs e)
        {
            ListViewID = lst_Customer.FocusedItem.SubItems[0].Text;
            txtID.Text = lst_Customer.FocusedItem.SubItems[0].Text;
            txtttc.Text = lst_Customer.FocusedItem.SubItems[1].Text;
            txtName.Text = lst_Customer.FocusedItem.SubItems[2].Text;
            txtSurname.Text = lst_Customer.FocusedItem.SubItems[3].Text;
            dtpBirthdate.Text = lst_Customer.FocusedItem.SubItems[4].Text;
            cmbDrivingLicenceType.Text = lst_Customer.FocusedItem.SubItems[5].Text;
            txtDrivingLicenseNo.Text = lst_Customer.FocusedItem.SubItems[6].Text;
            mtxtNo.Text = lst_Customer.FocusedItem.SubItems[7].Text;
            txtEmail.Text = lst_Customer.FocusedItem.SubItems[8].Text;
            txtAdres.Text = lst_Customer.FocusedItem.SubItems[9].Text;
            txtNotes.Text = lst_Customer.FocusedItem.SubItems[10].Text;
        }

        public void Fill_ListView(string Value)
        {
            lst_Customer.Items.Clear();
            SqlDataReader müsteriler;
            int count = 0;
            Cls_Customer cls_Customer = new Cls_Customer();
            if (Value == "all")
            {
                müsteriler = cls_Customer.CustomerListele();
            }
            else
            {
                müsteriler = cls_Customer.Listele_Arama(txt_Search.Text);
            }

            while (müsteriler.Read())
            {
                count++;
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = müsteriler[0].ToString();
                listViewItem.SubItems.Add(müsteriler[1].ToString());
                listViewItem.SubItems.Add(müsteriler[2].ToString());
                listViewItem.SubItems.Add(müsteriler[3].ToString());
                listViewItem.SubItems.Add(müsteriler[4].ToString());
                listViewItem.SubItems.Add(müsteriler[5].ToString());
                listViewItem.SubItems.Add(müsteriler[6].ToString());
                listViewItem.SubItems.Add(müsteriler[7].ToString());
                listViewItem.SubItems.Add(müsteriler[8].ToString());
                listViewItem.SubItems.Add(müsteriler[9].ToString());
                listViewItem.SubItems.Add(müsteriler[10].ToString());
                lst_Customer.Items.Add(listViewItem);
            }
            lblCount.Text = count.ToString();
            count = 0;
        }
       

        void Fill_DrivingLicenceType_Combobox()
        {
            Cls_Customer cls_Customer = new Cls_Customer();
            SqlDataReader EhliyetTürü = cls_Customer.Listele();
            while (EhliyetTürü.Read())
            {
                cmbDrivingLicenceType.Items.Add(EhliyetTürü[0]);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
           Fill_ListView("arama");
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
