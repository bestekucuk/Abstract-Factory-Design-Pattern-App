using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Abstract_Factory_Design_Pattern_App
{
    public class Otobus : IUlasim
    {
        private string Lokasyon;
        private DateTime GidisTarihi;
        private DateTime DonusTarihi;
        public Otobus(string Lokasyon, DateTime GidisTarihi, DateTime DonusTarihi)
        {

            this.Lokasyon = Lokasyon;
            this.GidisTarihi = GidisTarihi;
            this.DonusTarihi = DonusTarihi;
        }

        public string UlasimTarih()
        {
            return GidisTarihi.ToShortDateString() + " " + DonusTarihi.ToShortDateString();
        }
        public string UlasimYer()
        {
            return Lokasyon;
        }
    }
}
