using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public abstract class SoyutFabrika
    {
        public abstract IUlasim GetUlasim();
        public abstract IKonaklama GetKonaklama();
    }
}
