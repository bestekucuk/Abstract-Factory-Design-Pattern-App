using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus_Cadir:SoyutFabrika
    {
        public override IUlasim GetUlasim()
        {
            return new Otobus();
        }
        public override IKonaklama GetKonaklama()
        {
            return new Cadir();
        }
    }
}
