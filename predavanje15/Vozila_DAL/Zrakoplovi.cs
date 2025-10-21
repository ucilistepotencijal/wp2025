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
            new Zrakoplov{Naziv = "boeing 747", Boja ="bijela", KS =240000},
            new Zrakoplov{ Naziv = "Airbus A320", Boja = "Siva", KS = 180000, Tvrtka = "Airbus" },
            new Zrakoplov{ Naziv = "Cessna 172", Boja = "Plava", KS = 160, Tvrtka = "Cessna" },
            new Zrakoplov{ Naziv = "F-16 Falcon", Boja = "Siva", KS = 29000, Tvrtka = "Lockheed Martin" },
            new Zrakoplov{ Naziv = "Antonov 225", Boja = "Bijela", KS = 282000, Tvrtka = "Antonov" }
        };

        public static List<Zrakoplov> dohvatiZrakoplove()
        {
            List<Zrakoplov> dohvaceniZrakoplovi = new List<Zrakoplov>();
                foreach (Zrakoplov zrakoplov in zrakoploviBaza)
                {
                Zrakoplov novi = new Zrakoplov
                {
                    Naziv = zrakoplov.Naziv,
                    Boja = zrakoplov.Boja,
                    KS = zrakoplov.KS,
                    Tvrtka = zrakoplov.Tvrtka
                };

                dohvaceniZrakoplovi.Add(novi);
            }
            return dohvaceniZrakoplovi;
        }

    }
}
