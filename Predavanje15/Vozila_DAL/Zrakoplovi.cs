using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_DAL
{
    public class Zrakoplovi    
    {
        public static List<Zrakoplov> zrakoploviBaza = new List<Zrakoplov>()
        {
            new Zrakoplov () {Naziv = "Boeing 747", Boja = "Bijela", KS = 24000},
            new Zrakoplov () {Naziv = "Airbus A380", Boja = "Crna", KS = 34000},
            new Zrakoplov () {Naziv = "Boeing 777", Boja = "Plava", KS = 22000},
            new Zrakoplov () {Naziv = "Airbus A330", Boja = "Žuta", KS = 19000},
            new Zrakoplov () {Naziv = "Concorde", Boja = "Bijela", KS = 73000},
        };

        public static List<Zrakoplov> DohvatiZrakoplove()
        {
            List<Zrakoplov> dohvaceniZrakoplovi = new List<Zrakoplov>();
            foreach (Zrakoplov z in zrakoploviBaza)
            {
                Zrakoplov noviZrakoplov = new Zrakoplov();
                noviZrakoplov.Naziv = z.Naziv;
                noviZrakoplov.Boja = z.Boja;
                noviZrakoplov.KS = z.KS;
                dohvaceniZrakoplovi.Add(noviZrakoplov);
            }
            return dohvaceniZrakoplovi;
        }
    }
}
