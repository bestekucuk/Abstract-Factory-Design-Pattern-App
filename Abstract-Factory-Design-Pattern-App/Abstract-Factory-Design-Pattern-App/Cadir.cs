using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    internal class Cadir: IKonaklama
    {
        public void BuildKonaklama()
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("insert into SeyahatBilgileri (KonaklamaTipi) values (@KonaklamaTipi)", baglanti.baglan());
            command.Parameters.AddWithValue("@KonaklamaTipi", "Çadır");
            baglanti.baglan().Close();
        }
    }
}
