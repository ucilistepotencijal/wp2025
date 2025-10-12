using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OsobeRepo
    {
        //glumi bazu podataka
        public static List<Osoba> osobe = new List<Osoba>()
        {
            new Osoba() {Ime = "Pero", Prezime = "Perić"},
            new Osoba() {Ime = "Marko", Prezime = "Markić"},
            new Osoba() {Ime = "Ana", Prezime = "Anić"},
            new Osoba() {Ime = "Ivana", Prezime = "Ivanović"},
            new Osoba() {Ime = "Ivo", Prezime = "Ivić"}
        };

        public static List<Osoba> DohvatiOsobe()
        {
            List<Osoba> dohvaceneOsobe = new List<Osoba>();
            foreach (Osoba o in osobe) //ovo je samo primjer, jer bi irl dohvaćali iz rezultata baze podataka i
            //kreirali novu osobu
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
