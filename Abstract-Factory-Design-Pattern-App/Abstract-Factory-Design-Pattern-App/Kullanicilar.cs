using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Abstract_Factory_Design_Pattern_App
{
    class Kullanicilar
    {
       
            public int Id { get; set; }
            public string AdSoyad { get; set; }
            public string KimlikNo { get; set; }
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }
            public Kullanicilar kaydet { get; set; }
            public void Kaydet(Kullanicilar kullanıcı)
            {
                SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
                sqlBaglantisi.baglan();

                SqlCommand command = new SqlCommand("insert into KullanıcıBilgileri (AdSoyad,KimlikNo,KullaniciAdi,Sifre) values (@AdSoyad,@KimlikNo,@KullaniciAdi,@Sifre)", sqlBaglantisi.baglan());
                command.Parameters.AddWithValue("@AdSoyad", this.AdSoyad);
                command.Parameters.AddWithValue("@KimlikNo", this.KimlikNo);
                command.Parameters.AddWithValue("@KullaniciAdi", this.KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", this.Sifre);
                command.ExecuteNonQuery();
                sqlBaglantisi.baglan().Close();

            }
        public SqlDataReader KullanıcıKontrol(Guna.UI2.WinForms.Guna2TextBox KullaniciAdi,Guna.UI2.WinForms.Guna2TextBox Sifre)
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = baglanti.baglan();
            sqlCommand.CommandText = "select*from KullanıcıBilgileri where KullaniciAdi='" + KullaniciAdi.Text + "'";
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read() == true)
            {
                if (Sifre.Text == reader["Sifre"].ToString())
                {
                    Rezarvasyon rezarvasyon = new Rezarvasyon();
                    rezarvasyon.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz", "Hata1", MessageBoxButtons.OK);
                    
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi konrol ediniz ", "Hata2");
                
            }
           baglanti.baglan().Close();
            return reader;

        }

    }
    }

