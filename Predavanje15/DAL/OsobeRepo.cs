using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OsobeRepo
    {
        //Glumi bazu podataka
        public static List<Osoba> osobe = new List<Osoba>()
        {
            new Osoba () {Ime = "Pero", Prezime = "Perić"},
            new Osoba () {Ime = "Marko", Prezime = "Marić"},
            new Osoba () {Ime = "Ana", Prezime = "Anić"},
            new Osoba () {Ime = "Ivana", Prezime = "Ivanović"},
            new Osoba () {Ime = "Ivo", Prezime = "Ivić"},
        };

        public static List <Osoba> DohvatiOsobe()
        {
            List <Osoba> dohvaceneOsobe = new List<Osoba> ();
            foreach (Osoba o in osobe)
            {
                Osoba novaOsoba = new Osoba();
                novaOsoba.Ime = o.Ime;
                novaOsoba.Prezime = o.Prezime;
                dohvaceneOsobe.Add (novaOsoba);
            }
            return dohvaceneOsobe;
        }
    }
}
