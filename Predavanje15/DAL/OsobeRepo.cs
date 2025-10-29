using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Remove one of the duplicate DohvatiOsobe method declarations to resolve ambiguity
    public class OsobeRepo
    {
        public static readonly List<Osoba> osobe;
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
    }
}

