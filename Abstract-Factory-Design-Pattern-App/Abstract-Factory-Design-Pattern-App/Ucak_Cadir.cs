using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Ucak_Cadir:SoyutFabrika
    {
        public override IUlasim GetUlasim()
        {
            throw new NotImplementedException();
        }
        public override IKonaklama GetKonaklama()
        {
            throw new NotImplementedException();
        }
    }
}
