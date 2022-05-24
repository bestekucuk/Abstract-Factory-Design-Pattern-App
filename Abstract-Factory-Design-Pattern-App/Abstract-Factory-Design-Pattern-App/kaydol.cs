using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory_Design_Pattern_App
{
    public partial class kaydol : Form
    {
        public kaydol()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
            this.Hide();
        }

        private void txtboxKimlikNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtKimlikNo_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtboxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
