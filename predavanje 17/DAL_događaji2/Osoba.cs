using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_događaji2
{
    public class Osoba
    {
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        public delegate void NaPozivMetodePunoImeDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPozivMetodePunoIme;

        private string ime;
        public string Ime
        { get { return ime; } set { ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            } }

        public string Prezime { get; set; }
        public string PunoIme()
        {
            if(NaPozivMetodePunoIme != null)
            {
                NaPozivMetodePunoIme(this, new EventArgs());
            }
            return ime + " " + Prezime;
        }

       
    }
}
