

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Osoba
    {
        // Deklaracija događaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs eventArgs);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        public delegate void NaPozivMetodePunoImeDelegat(object sender, EventArgs eventArgs);
        public event NaPozivMetodePunoImeDelegat NaPozivMetodePunoIme;

        private string ime;
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }

        public string Prezime { get; set; }
        public string PunoIme()
        {
            if (NaPozivMetodePunoIme != null)
            {
                NaPozivMetodePunoIme(this, new EventArgs());
            }
            return Ime + " " + Prezime;
        }
    }
}