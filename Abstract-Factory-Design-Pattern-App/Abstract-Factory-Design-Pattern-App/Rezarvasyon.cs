
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
using Newtonsoft.Json;
using System;
using System.Xml;

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
            JsonKaydet();
            if (Ulasim == "Ucak" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, guna2ComboBox1.Text, txtID.Text);
                JsonSeyahatBilgi(new Ucak_Otel(guna2ComboBox1.Text, tpGidis.Value,tpDonus.Value));
                

            }
            else if (Ulasim == "Ucak" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, guna2ComboBox1.Text, txtID.Text);
                JsonSeyahatBilgi(new Ucak_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));


            }
            else if (Ulasim == "Otobus" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, guna2ComboBox1.Text, txtID.Text);
                JsonSeyahatBilgi(new Otobus_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));

            }
            else if (Ulasim == "Otobus" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                HtmlKaydet(cbUlasim.Text, cbKonaklama.Text, guna2ComboBox1.Text, txtID.Text);
                JsonSeyahatBilgi(new Otobus_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));


            }
            MessageBox.Show("Rezervasyonunuz başarıyla oluşturulmuştur.");

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
                writer2.WriteLine("KimlikNo:"+"  "+reader["KimlikNo"]+"\t");
                writer2.WriteLine("AdSoyad:"+ " "+reader["AdSoyad"]);
            }

            using (StreamWriter writer = new StreamWriter(UlasimTip + ".html", append: true))
            {
                writer.WriteLine(UlasimTip+"\t"+ guna2ComboBox1.Text);
                writer.WriteLine(KonaklamaTip+"\t" + tpGidis.Value.ToShortDateString() + " - " + tpDonus.Value.ToShortDateString());
            }
            
        }
        public void JsonKaydet()
        {   
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='" + txtID.Text + "'");
            command.Connection = baglanti.baglan();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            
           
            Kullanicilar k = new Kullanicilar();
            k.AdSoyad = (string)reader["AdSoyad"];
            k.KimlikNo = (string)reader["KimlikNo"];
            k.Sifre = "*********";
            k.KullaniciAdi = (string)reader["KullaniciAdi"];
            string JSONresult = JsonConvert.SerializeObject(k);
            string path = @"C:\Users\Lenovo\OneDrive\Masaüstü\kullanicilar.json";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
            }
        }
        public void JsonSeyahatBilgi(SoyutFabrika soyutFabrika)
        {
            
            string JSONresult = JsonConvert.SerializeObject(soyutFabrika);
            string path = @"C:\Users\Lenovo\OneDrive\Masaüstü\Seyahat.json";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
                
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                { tw.WriteLine(JSONresult.ToString()); tw.Close(); }
            }
        }

        private void btnJsonSeyahat_Click(object sender, EventArgs e)
        {
            string SeyahatPath = @"C:\Users\Lenovo\OneDrive\Masaüstü\Seyahat.json";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = SeyahatPath;
            prc.Start();




        }

        private void btnJsonKullaniciBilgi_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"C:\Users\Lenovo\OneDrive\Masaüstü\kullanicilar.json";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnHtmlSeyahat_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Otobus.html";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnHtmlKullaniciBilgi_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\1.html";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            XML();
           
            string KullaniciPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Rapor.xml";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }
        public void XML()
        {

                SqlBaglantisi baglanti = new SqlBaglantisi();
                baglanti.baglan();
                SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='" + txtID.Text + "'");
                command.Connection = baglanti.baglan();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Kullanicilar K = new Kullanicilar();
                string xmlPath = Application.StartupPath + "\\Rapor.xml";
                XmlTextWriter customer = new XmlTextWriter(xmlPath, UTF8Encoding.UTF8);

                customer.Formatting = System.Xml.Formatting.Indented;

                customer.WriteStartDocument();

                customer.WriteStartElement("Rapor");

                customer.WriteStartElement("Musteri");
                
                customer.WriteAttributeString("KimlikNo", (string)reader["KimlikNo"]);

                customer.WriteAttributeString("AdSoyad", (string)reader["AdSoyad"]);

                customer.WriteAttributeString("ID", txtID.Text);

                customer.WriteElementString("Konaklama", cbKonaklama.Text);

                customer.WriteElementString("Ulasim", cbUlasim.Text);

                customer.WriteElementString("Lokasyon", guna2ComboBox1.Text);

                customer.WriteEndElement();
                customer.Close();



        }




    }   
    }

