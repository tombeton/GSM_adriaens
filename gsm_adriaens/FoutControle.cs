using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsm_adriaens
{
    class FoutControle
    {
        public string fout = "";

        public FoutControle()
        {
            Convert.ToString(fout).ToLower();
            if (fout != "j" || fout != "n" || fout != "o")
            {
                MessageBox.Show("Dit is geen geldige invoer");
            
            }
        }

    }

}

