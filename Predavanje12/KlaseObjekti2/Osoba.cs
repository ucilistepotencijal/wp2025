using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti2
{
    internal class Osoba
    {   //Static clanovi odnose se na cijelu klasu
        //Private modifikator pristupa označava privatne članove klase
        private static int brojOsoba = 0; //static znači da direktno pozivamo DohvaiBrojOsoba() na klasi Osoba
        public static int DohvatiBrojOsoba()
        {
            return brojOsoba;
        }

        //konstruktor klase Osoba - konstruktor: metoda koja se poziva kad se radi istanca klase
        public Osoba()
        {
            brojOsoba++; //svaki put kad dodamo jednu osobu brojač će se povećati za 1
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        //Modifikator pristupa punlic omogućuje pristupanje svojstvima, metodama i događajima izvan definicije klase
        public string Ime { get; set; }
        public string Prezime { get; set; }

        //Definicija metode (funkcije)
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
