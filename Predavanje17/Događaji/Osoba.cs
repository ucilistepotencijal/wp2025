using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Događaji
{
    public class Osoba
    {
        //1.Deklaracija događaja
        public delegate void NaPromjenuImenaDelegat(object senderm, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        private string ime;
        public string Ime
        {
            get
            { return ime;
            }
            set
            {
                ime = value;
                //2. moramo provjeriti da je događaj implementiran
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
    }
}

    

