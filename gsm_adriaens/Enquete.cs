using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsm_adriaens
{
    
    class Enquete
    {

        private int Ja, Nee, Onv;
        string j = "j";
        string n = "n";
        string o = "o";
        string msg = "";

        public Enquete()
        {

        }


        private string getantwoord;
        public string getAntwoord
        {
            get { return getAntwoord; }

            set
            {
                getantwoord = value.ToLower();
                Convert.ToString(getantwoord);
                if (getantwoord == j) Ja++;
                else if (getantwoord == n) Nee++;
                else if (getantwoord == o) Onv++;
                
            }
            
        }
        public int getJa
        {
            get { return Ja; }
            set { Ja = value; }
        }

        public int getNee
        {
            get { return Nee; }

        }

        public int getOnv
        {
            get { return Onv; }
 
        }

        
        public string getMsg()
        {
            if (Ja > Nee)
            {
                msg = "toegestaan" ;
                
            }
            else if (Ja < Nee)
            {
                msg = "niet toegestaan" ;
            }
            else
            {
                msg = " onbeslist" ;
            }
            return msg;
        }
    }

}

 