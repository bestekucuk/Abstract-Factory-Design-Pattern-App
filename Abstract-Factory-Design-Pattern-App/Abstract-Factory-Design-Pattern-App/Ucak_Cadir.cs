using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Ucak_Cadir:SoyutFabrika
    {
        public override IUlasim GetUlasim()
        {

            return new Ucak();
          

        }
        public override IKonaklama GetKonaklama()
        {


            return new Cadir();
           
        }
    }
}
