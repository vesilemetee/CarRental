using CarRental.UI.Forms.Car;
using CarRental.UI.Forms.CarRental;
using CarRental.UI.Forms.Customer;
using CarRental.UI.Forms.Rentals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.UI.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustormer_Up_Del frmCustormer_Up = new FrmCustormer_Up_Del();
            frmCustormer_Up.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Show();
            
        }

        private void mÜŞTERİEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustormerInsert frmCustormerInsert = new FrmCustormerInsert();
            frmCustormerInsert.Show();
        }

        private void mÜŞTERİLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers(); 
            frmCustomers.Show();
        }

        private void aRABAEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarInsert frmCarInsert = new FrmCarInsert();
            frmCarInsert.Show();
        }

        private void aRABAGÜNCELLEMESİLMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCar_Up_Del frmCar_Up_Del = new FrmCar_Up_Del();
            frmCar_Up_Del.Show();
        }

        private void aRABALARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCars frmCars = new FrmCars();
            frmCars.Show();
        }

        private void aRABAKİRALAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarRental frmCarRental = new FrmCarRental();
            frmCarRental.Show();
        }

        private void kİRALANANLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRentals frmRentals = new FrmRentals();
            frmRentals.Show();
        }
    }
}
