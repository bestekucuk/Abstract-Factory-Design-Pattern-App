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
    class XML:IRapor
    {
       public void Create(string UlasimTip, string KonaklamaTip, Guna.UI2.WinForms.Guna2TextBox txtID, Guna.UI2.WinForms.Guna2ComboBox cbLokasyon, Guna.UI2.WinForms.Guna2DateTimePicker tpGidis, Guna.UI2.WinForms.Guna2DateTimePicker tpDonus)
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("select *from KullanıcıBilgileri where Id='" + txtID.Text + "'");
            command.Connection = baglanti.baglan();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            Kullanicilar K = new Kullanicilar();
            string xmlPath = Application.StartupPath + "Rapor.xml";
            XmlTextWriter customer = new XmlTextWriter(xmlPath, UTF8Encoding.UTF8);

            customer.Formatting = System.Xml.Formatting.Indented;

            customer.WriteStartDocument();

            customer.WriteStartElement("Rapor");

            customer.WriteStartElement("Musteri");

            customer.WriteAttributeString("KimlikNo", (string)reader["KimlikNo"]);

            customer.WriteAttributeString("AdSoyad", (string)reader["AdSoyad"]);

            customer.WriteAttributeString("ID", txtID.Text);

            customer.WriteElementString("Konaklama", KonaklamaTip);

            customer.WriteElementString("Ulasim", UlasimTip);

            customer.WriteElementString("Lokasyon", cbLokasyon.Text);

            customer.WriteEndElement();
            customer.Close();
        }
    }
}
