using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otel: IKonaklama
    {
        public void BuildKonaklama()
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("insert into SeyahatBilgi (KonaklamaTipi) values (@KonaklamaTipi)", baglanti.baglan());
            command.Parameters.AddWithValue("@KonaklamaTipi", "Otel");
            command.ExecuteNonQuery();
            baglanti.baglan().Close();
        }
    }
}
