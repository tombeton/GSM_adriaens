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

        public static bool errors(string input) 
        {
            bool check;

            input = Convert.ToString(input).ToLower();

            if (input == "j" || input == "n" || input == "o")
            {
                check = true;
            }
            else 
            {
                check = false;
                MessageBox.Show("Dit is geen geldige invoer");
            }
            return check;
        }
    }
}

