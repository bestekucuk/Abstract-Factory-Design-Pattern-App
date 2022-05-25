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
    class JSON:IRapor
    {
        public void Create(string UlasimTip, string KonaklamaTip, Guna.UI2.WinForms.Guna2TextBox txtID, Guna.UI2.WinForms.Guna2ComboBox cbLokasyon, Guna.UI2.WinForms.Guna2DateTimePicker tpGidis, Guna.UI2.WinForms.Guna2DateTimePicker tpDonus)
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='" + txtID.Text + "'");
            command.Connection = baglanti.baglan();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();


            Kullanicilar k = new Kullanicilar();
            k.Id = Convert.ToInt32(txtID.Text);
            k.AdSoyad = (string)reader["AdSoyad"];
            k.KimlikNo = (string)reader["KimlikNo"];
            k.Sifre = "*********";
            k.KullaniciAdi = (string)reader["KullaniciAdi"];
            string JSONresult = JsonConvert.SerializeObject(k);
            string path = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Dosyalar\JSON\KullaniciBilgi.Json";
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
            string path = @"C:\Users\Lenovo\source\repos\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\Abstract-Factory-Design-Pattern-App\bin\Debug\Dosyalar\JSON\Seyahat.json";

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

    }
}
