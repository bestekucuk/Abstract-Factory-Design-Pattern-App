using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otel: IKonaklama
    {
        private DateTime GidisTarih;
        private DateTime DonusTarih;
        public Otel(DateTime GidisTarihi,DateTime DonusTarihi)
        {
            this.GidisTarih = GidisTarihi;
            this.DonusTarih = DonusTarihi;
        }
        public string GetKonaklama()
        {
            return GidisTarih.ToShortDateString() + "" + DonusTarih.ToShortDateString();

        }
    }


}
