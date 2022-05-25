
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
            HTML html = new HTML();
            
            JSON json = new JSON();
            XML xml = new XML();
            xml.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis, tpDonus);
            json.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis, tpDonus);
            if (Ulasim == "Ucak" && Konaklama == "Otel")
            {
                
                Seyahat seyahat = new Seyahat(new Ucak_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                html.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis,tpDonus);
                json.JsonSeyahatBilgi(new Ucak_Otel(guna2ComboBox1.Text, tpGidis.Value,tpDonus.Value));
                

            }
            else if (Ulasim == "Ucak" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                html.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis, tpDonus);
                json.JsonSeyahatBilgi(new Ucak_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));


            }
            else if (Ulasim == "Otobus" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                html.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis, tpDonus);
                json.JsonSeyahatBilgi(new Otobus_Otel(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));

            }
            else if (Ulasim == "Otobus" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));
                seyahat.BuildSeyahat();
                html.Create(Ulasim, Konaklama, txtID, cbLokasyon, tpGidis, tpDonus);
                json.JsonSeyahatBilgi(new Otobus_Cadir(guna2ComboBox1.Text, tpGidis.Value, tpDonus.Value));


            }
            MessageBox.Show("Rezervasyonunuz başarıyla oluşturulmuştur.");

        }

       
       
        
        private void btnJsonSeyahat_Click(object sender, EventArgs e)
        {
            string SeyahatPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Dosyalar\JSON\Seyahat.json";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = SeyahatPath;
            prc.Start();




        }

        private void btnJsonKullaniciBilgi_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Dosyalar\JSON\KullaniciBilgi.json";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnHtmlSeyahat_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"file:///C:/Users/Lenovo/source/repos/Abstract-Factory-Design-Pattern-App/Abstract-Factory-Design-Pattern-App/Abstract-Factory-Design-Pattern-App/bin/Debug/SeyahatBilgi.html";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnHtmlKullaniciBilgi_Click(object sender, EventArgs e)
        {
            string KullaniciPath = @"file:///C:/Users/Lenovo/source/repos/Abstract-Factory-Design-Pattern-App/Abstract-Factory-Design-Pattern-App/Abstract-Factory-Design-Pattern-App/bin/Debug/KullaniciBilgi.html";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            
           
            string KullaniciPath = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Rapor.xml";
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = KullaniciPath;
            prc.Start();
        }
        




    }   
    }

