using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory_Design_Pattern_App
{
    public partial class Rezarvasyon : Form
    {
        public Rezarvasyon()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string Ulasim = cbUlasim.Text;
            string Konaklama = cbKonaklama.Text;
           


            if(Ulasim=="Ucak" && Konaklama=="Otel")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Otel());
                seyahat.BuildSeyahat();
                MessageBox.Show("Kaydoldu");
            }
            else if(Ulasim=="Ucak" && Konaklama=="Cadir")
            {
                Seyahat seyahat = new Seyahat(new Ucak_Cadir());
                seyahat.BuildSeyahat();
                MessageBox.Show("Kaydoldu");
            }
            else if (Ulasim == "Otobus" && Konaklama == "Cadir")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Cadir());
                seyahat.BuildSeyahat();
                MessageBox.Show("Kaydoldu");
            }
            else if (Ulasim == "Otobus" && Konaklama == "Otel")
            {
                Seyahat seyahat = new Seyahat(new Otobus_Otel());
                seyahat.BuildSeyahat();
                MessageBox.Show("Kaydoldu");
            }
        }
    }
}
