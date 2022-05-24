using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus: IUlasim
    {
        public void BuildUlasim()
        {
            SqlBaglantisi baglanti = new SqlBaglantisi();
            baglanti.baglan();
            SqlCommand command = new SqlCommand("insert into SeyahatBilgileri (UlasimTipi) values (@UlasimTipi)", baglanti.baglan());
            command.Parameters.AddWithValue("@UlasimTipi", "Otobüs");
            baglanti.baglan().Close();

        }
    }
}
