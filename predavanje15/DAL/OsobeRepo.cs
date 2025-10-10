using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OsobeRepo
    {
        public static List<Osoba> osobe = new List<Osoba>()
        {
            new Osoba() {Ime = "pero", Prezime = "peric"},
            new Osoba() {Ime = "marko", Prezime = "markic"},
            new Osoba() {Ime = "ana", Prezime = "anic"},
            new Osoba() {Ime = "ivana", Prezime = "ivanovic"},
            new Osoba() {Ime = "ivo", Prezime = "ivic"},
        };

        public static List<Osoba> dohvatiOsobe()
        {
            List<Osoba> dohvaceneOsobe = new List<Osoba>();
            foreach(Osoba o in osobe)
            {
                Osoba novaOsoba = new Osoba();
                novaOsoba.Ime = o.Ime;
                novaOsoba.Prezime = o.Prezime;
                dohvaceneOsobe.Add(novaOsoba);
            }
            return dohvaceneOsobe;
        }
    }
}
