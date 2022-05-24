using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    
    public class Cadir:IKonaklama
    {
        private DateTime GidisTarihi;
        private DateTime DonusTarihi;
        public Cadir(DateTime GidisTarihi,DateTime DonusTarihi)
        {
            this.GidisTarihi = GidisTarihi;
            this.DonusTarihi = DonusTarihi;
        }
        public string GetKonaklama()
        {
            return GidisTarihi.ToShortDateString() + "" + DonusTarihi.ToShortDateString();
        }
    }
}
