using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{

    public class Osoba
    {
        //1. Deklaracija dogadjaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NapromjenuImena;

        private string ime;

        public string Ime;
        {
            get
                 return ime;
            }
            set
                 ime = value; 
            // 2. moramo provjeriti da je događaj implentivan
            if(NaPromjenuImena ! = null)
            {
            NaPromjenuImena(this,New eventArgs());
            }

            }



    }
}
