using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public partial class Rezarvasyon : Form
    {
        public Rezarvasyon()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string Ulasim = cbUlasim.Text;
            string Konaklama = cbKonaklama.Text;
            if (Ulasim == "Ucak" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, cbLokasyon.Text, txtID.Text);

            }
            else if (Ulasim == "Ucak" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, cbLokasyon.Text,txtID.Text);


            }
            else if (Ulasim == "Otobus" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, cbLokasyon.Text,txtID.Text);

            }
            else if (Ulasim == "Otobus" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, cbLokasyon.Text,txtID.Text);


            }

        }

        public void HtmlKaydet(string UlasimTip,string KonaklamaTip,string Lokasyon,string KullaniciBilgi)
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='"+txtID.Text+"'");
            command.Connection = baglanti.baglan();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            using (StreamWriter writer2=new StreamWriter(KullaniciBilgi+".html",append:true))
            {
                writer2.WriteLine("KimlikNo:"+reader["KimlikNo"]);
                writer2.WriteLine("AdSoyad:"+ reader["AdSoyad"]);
            }

            using (StreamWriter writer = new StreamWriter(UlasimTip + ".html", append: true))
            {
                writer.WriteLine(UlasimTip+cbLokasyon.Text);
            }
            using (StreamWriter writer1=new StreamWriter(KonaklamaTip+".html",append:true))
            {
                writer1.WriteLine(KonaklamaTip + tpGidis.Value.ToShortDateString() + " - " + tpDonus.Value.ToShortDateString());
            }
        }
    }
}
