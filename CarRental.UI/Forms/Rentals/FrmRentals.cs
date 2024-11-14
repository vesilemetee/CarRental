using CarRental.BusinessLayer;
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

namespace CarRental.UI.Forms.Rentals
{
    public partial class FrmRentals : Form
    {
        public FrmRentals()
        {
            InitializeComponent();
        }

        private void FrmRentals_Load(object sender, EventArgs e)
        {
            Fill_ListView();
        }
        public void Fill_ListView()
        {
            lstRental.Items.Clear();
            Cls_Rental cls_Rental = new Cls_Rental();
            SqlDataReader Kiralananlar = cls_Rental.Rental_Listele();
            while (Kiralananlar.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = Kiralananlar[0].ToString();
                listViewItem.SubItems.Add(Kiralananlar[1].ToString());
                listViewItem.SubItems.Add(Kiralananlar[2].ToString());
                listViewItem.SubItems.Add(Kiralananlar[3].ToString());
                listViewItem.SubItems.Add(Kiralananlar[4].ToString());
                listViewItem.SubItems.Add(Kiralananlar[5].ToString());
                listViewItem.SubItems.Add(Kiralananlar[6].ToString()); 
                listViewItem.SubItems.Add(Kiralananlar[7].ToString());
                listViewItem.SubItems.Add(Kiralananlar[8].ToString());
                listViewItem.SubItems.Add(Kiralananlar[9].ToString());
                listViewItem.SubItems.Add(Kiralananlar[10].ToString());
                listViewItem.SubItems.Add(Kiralananlar[11].ToString());
                listViewItem.SubItems.Add(Kiralananlar[12].ToString());
                listViewItem.SubItems.Add(Kiralananlar[13].ToString());
                listViewItem.SubItems.Add(Kiralananlar[14].ToString());
                listViewItem.SubItems.Add(Kiralananlar[15].ToString());
                listViewItem.SubItems.Add(Kiralananlar[16].ToString());             
                listViewItem.SubItems.Add(Kiralananlar[17].ToString());
                listViewItem.SubItems.Add(Kiralananlar[18].ToString());
                listViewItem.SubItems.Add(Kiralananlar[19].ToString());
                listViewItem.SubItems.Add(Kiralananlar[20].ToString());
                listViewItem.SubItems.Add(Kiralananlar[21].ToString());
                lstRental.Items.Add(listViewItem);
            }
        }
    }
}
