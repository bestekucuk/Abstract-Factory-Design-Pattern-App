using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus_Otel:SoyutFabrika
    {
        public DateTime GidisTarih;
        public DateTime DonusTarih;
        private string Lokasyon;
        public Otobus_Otel(string Lokasyon,DateTime GidisTarih,DateTime DonusTarih)
        {
            this.GidisTarih = GidisTarih;
            this.DonusTarih = DonusTarih;
            this.Lokasyon = Lokasyon;
        }
        public override IUlasim GetUlasim()
        {
            return new Otobus(this.Lokasyon, this.GidisTarih, this.DonusTarih);
        }
        public override IKonaklama GetKonaklama()
        {
            return new Otel(this.GidisTarih,this.DonusTarih);
        }
    }
}

