using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus_Cadir:SoyutFabrika
    {
        private string Lokasyon;
        private DateTime GidisTarih;
        private DateTime DonusTarih;
        public override IUlasim GetUlasim()
        {
            return new Otobus(this.Lokasyon, this.GidisTarih, this.DonusTarih);
        }
        public override IKonaklama GetKonaklama()
        {
            return new Cadir(this.GidisTarih, this.DonusTarih);
        }
    }
}
