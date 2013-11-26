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

        public static bool errors(string input) 
        {
            bool check;

            if (input == "j")
            {
                check = true;
            }
            else check = false;

            return check;
        }

    }

}

