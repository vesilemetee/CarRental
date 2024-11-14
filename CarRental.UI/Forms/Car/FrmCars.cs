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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CarRental.UI.Forms.Car
{
    public partial class FrmCars : Form
    {
        public FrmCars()
        {
            InitializeComponent();
        }

        private void FrmCars_Load(object sender, EventArgs e)
        {
            Fill_ListView("arabalar");
        }
        public void Fill_ListView(string Value)
        {
            lst_Car.Items.Clear();
            int count = 0;
            Cls_Car cls_Car = new Cls_Car();
            SqlDataReader arabalar = cls_Car.CarListele();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
