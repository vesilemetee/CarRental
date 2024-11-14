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

namespace CarRental.UI.Forms.Customer
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            Fill_ListView("müsteriler");
        }

        public void Fill_ListView(string Value)
        {
            lst_Customer.Items.Clear();
            int count = 0;
            Cls_Customer cls_Customer = new Cls_Customer();
            SqlDataReader müsteriler = cls_Customer.CustomerListele();

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
                listViewItem.SubItems.Add(müsteriler[9].ToString());
                listViewItem.SubItems.Add(müsteriler[10].ToString());
                lst_Customer.Items.Add(listViewItem);

            }
            lblCount.Text = count.ToString();
            count = 0;
        }

        private void lst_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
