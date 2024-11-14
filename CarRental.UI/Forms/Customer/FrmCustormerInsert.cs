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
using CarRental.BusinessLayer;
using CarRental.TypeLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRental.UI.Forms.Customer
{
    public partial class FrmCustormerInsert : Form
    {
        public FrmCustormerInsert()
        {
            InitializeComponent();
        }
        //int LİstviewID;
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Cls_Customer cls_Customer = new Cls_Customer();
            cls_Customer.Tc = txtTc.Text;
            cls_Customer.Isim = txtName.Text;
            cls_Customer.Soyisim = txtSurname.Text;
            cls_Customer.DoğumTarihi = Convert.ToDateTime(dtpBirthdate.Value);
            cls_Customer.EhliyetTürü = cmbDrivingLicenceType.Text;
            int DrivingLicenceTypeID = Cls_Customer.IDVer(cmbDrivingLicenceType.SelectedItem.ToString());
            //cls_Customer.EhliyetTürü = cmbDrivingLicenceType.ValueMember;
            cls_Customer.EhliyetNo = Convert.ToInt32(txtDrivingLicenseNo.Text);
            cls_Customer.Telefon = mtxtNo.Text;
            cls_Customer.Email = txtEmail.Text;
            cls_Customer.Adres = txtAdres.Text;
            cls_Customer.Notlar = txtNotes.Text;
            bool answer = cls_Customer.Insert(DrivingLicenceTypeID);
            if (answer == true)
            {
                Temizle();
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", true, "insert"));

            }
            else
            {
                MessageBox.Show(Cls_Common_Messages.CRUD_Message("Müşteri", false, "insert"));
            }
        }

        private void FrmCustormerInsert_Load(object sender, EventArgs e)
        {
            Fill_DrivingLicenceType_Combobox();
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

        void Temizle()
        {
            txtTc.Clear();
            txtName.Clear();
            txtSurname.Clear();
            dtpBirthdate.Text = DateTime.Now.ToShortDateString();
            txtDrivingLicenseNo.Clear();
            mtxtNo.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            txtNotes.Clear();
        }
    }
}
