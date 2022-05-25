using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern_App
{
    interface IRapor
    {

        void Create(string UlasimTip, string KonaklamaTip, Guna.UI2.WinForms.Guna2TextBox txtID, Guna.UI2.WinForms.Guna2ComboBox cbLokasyon, Guna.UI2.WinForms.Guna2DateTimePicker tpGidis, Guna.UI2.WinForms.Guna2DateTimePicker tpDonus);
 
 
 
    }
}
