using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_DAL
{
    public class Zrakoplovi
    {
        public static List<Zrakoplov> ZrakoploviBaza = new List<Zrakoplov>()
        {
            new Zrakoplov{Naziv = "Boeing 747", Boja = "bijela", KS = 240000},
            new Zrakoplov{Naziv = "Cessna 172 SkyHaek", Boja = "crvena", KS = 180},
            new Zrakoplov{Naziv = "Boeing 737", Boja = "plava", KS = 54000},
            new Zrakoplov{Naziv = "Airbus A320neo", Boja = "bijela", KS = 60000},
            new Zrakoplov{Naziv = "Antonov an-225", Boja = "bijela", KS = 310000}
        };

        public static List<Zrakoplov> DohvatiZrakoplove()
        {
            List<Zrakoplov> dohvaceniZrakoplovi = new List<Zrakoplov>();
            foreach (Zrakoplov zrakoplov in ZrakoploviBaza)
            {
                Zrakoplov z = new Zrakoplov();
                z.Naziv = zrakoplov.Naziv;
                z.Boja = zrakoplov.Boja;
                z.KS = zrakoplov.KS;
                dohvaceniZrakoplovi.Add(z);
            }
            return dohvaceniZrakoplovi;
        }
    }
}
