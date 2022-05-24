using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        }
    }

