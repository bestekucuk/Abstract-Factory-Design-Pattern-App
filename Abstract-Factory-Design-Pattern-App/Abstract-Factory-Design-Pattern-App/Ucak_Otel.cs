using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Ucak_Otel:SoyutFabrika
    {
        private string Lokasyon;
        private DateTime GidisTarih;
        private DateTime DonusTarih;
        public Ucak_Otel(string Lokasyon, DateTime GidisTarih, DateTime DonusTarih)
        {
            this.Lokasyon = Lokasyon;
            this.GidisTarih = GidisTarih;
            this.DonusTarih = DonusTarih;
        }
        public override IUlasim GetUlasim()
        {
            return new Ucak(this.Lokasyon, this.GidisTarih, this.DonusTarih);
        }
        public override IKonaklama GetKonaklama()
        {
            return new Otel(this.GidisTarih, this.DonusTarih);
        }
    }
}
