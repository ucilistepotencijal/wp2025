using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLaseObjekti2
{
    internal class Osoba
    {//Static članovi odnose se na cijelu klasu
        //Private modifikator pristupa označava privatne članove klase
        private static int brojOsoba = 0; 
        public static int DohvatiBrojOsoba()
        { 
            return brojOsoba; 
        }
        //Konstruktor klase osoba
        public Osoba()
        {
            brojOsoba++;
        }
        public Osoba (string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        //Modifikator pristupa public omogucuje pristupanje metodama i događajima
        //izvan definicije klase
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //Definicija metode (funkcije)
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }


    }
}
