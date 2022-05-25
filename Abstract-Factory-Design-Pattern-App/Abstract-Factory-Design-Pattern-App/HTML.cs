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
    class HTML:IRapor
    {
        public void Create(string UlasimTip, string KonaklamaTip , Guna.UI2.WinForms.Guna2TextBox txtID,Guna.UI2.WinForms.Guna2ComboBox cbLokasyon,Guna.UI2.WinForms.Guna2DateTimePicker tpGidis, Guna.UI2.WinForms.Guna2DateTimePicker tpDonus)
        {
                string KullaniciBilgi = "KullaniciBilgi";
                string SeyahatBilgi = "SeyahatBilgi";
                SqlBaglantisi baglanti = new SqlBaglantisi();
                baglanti.baglan();
                SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='" + txtID.Text + "'");
                command.Connection = baglanti.baglan();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                using (StreamWriter writer2 = new StreamWriter(KullaniciBilgi + ".html", append: true))
                {
                    writer2.WriteLine("KimlikNo:" + "  " + reader["KimlikNo"] + "\t");
                    writer2.WriteLine("AdSoyad:" + " " + reader["AdSoyad"]);
                }

                using (StreamWriter writer = new StreamWriter(SeyahatBilgi + ".html", append: true))
                {
                    writer.WriteLine(UlasimTip + "\t" + cbLokasyon.Text);
                    writer.WriteLine(KonaklamaTip + "\t" + tpGidis.Value.ToShortDateString() + " - " + tpDonus.Value.ToShortDateString());
                }

            
        }
    }
}
