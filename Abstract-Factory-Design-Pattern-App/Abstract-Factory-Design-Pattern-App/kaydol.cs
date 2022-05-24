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
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.AdSoyad=txtboxKullaniciAdi.Text;
            kullanici1.KimlikNo = txtboxKimlikNo.Text;
            kullanici1.KullaniciAdi = txtboxKullaniciAdi.Text;
            kullanici1.Sifre = txtboxSifre.Text;
            kullanici1.Kaydet(kullanici1);
            MessageBox.Show("Başarıyla Kaydolundu");
        }
    }
}
