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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            kaydol kaydol = new kaydol();
            this.Hide();
            kaydol.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.KullanıcıKontrol(txtkullaniciAdi, txtSifre);
           
        }
       
    }
}
