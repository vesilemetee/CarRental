using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRental.UI.Forms
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string Kullanici;
            string sifre;

            Kullanici = txtName.Text;
            sifre = txtPassword.Text;

            if (Kullanici == "admin" && sifre == "123")
            {
                this.Hide();
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                
            }
            else
            {
                label3.Text = "Kullanıcı Adı veya Şifre Yanlış!";
                label3.BackColor = Color.Red;
                label3.Show();
            }
        }

        private void FrmUserLogin_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void ŞifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (ŞifreGöster.Checked)
            {
                //karakteri göster.
                txtPassword.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
