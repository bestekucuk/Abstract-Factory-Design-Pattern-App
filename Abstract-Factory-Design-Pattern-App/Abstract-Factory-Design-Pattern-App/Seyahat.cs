using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Seyahat
    {
        
        private SoyutFabrika _soyutFabrika;
        private IUlasim _ulasim;
        private IKonaklama _konaklama;

        public Seyahat(SoyutFabrika soyutFabrika)
        {
            _soyutFabrika = soyutFabrika;   
           _ulasim=_soyutFabrika.GetUlasim();
            _konaklama=_soyutFabrika.GetKonaklama();
        }
        public void BuildSeyahat()
        {
            _ulasim.UlasimYer();
            _ulasim.UlasimTarih();
            _konaklama.GetKonaklama();

        }
           
        
    }
}
