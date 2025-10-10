using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila_DAL;

namespace Vozila_DAL
{
    public class Zrakoplovi
    {
        public static List<Zrakoplov> ZrakoplovBaza = new List<Zrakoplov>();
    {
        new Zrakoplov{Naziv = "Boing 747", Boja = "Bijela" ,KS =24000},
        new Zrakoplov{Naziv = "Cessna 172 SkyHaek", Boja = "Crvena",KS = 180},
        new Zrakoplov { Naziv = "Boing 737", Boja = "Plava", KS = 54000 },
        new Zrakoplov { Naziv = "Airbus A320Neo", Boja = "Bijela",KS = 60000},
        new Zrakoplov { Naziv = "Antonov an-225", Boja ="Bijela",KS = 31000}
     };
public static List <Zrakoplov> DohvatiZrakoplove()
{
    List<Zrakoplov> dohvaceniZrakoplovi = new List<Zrakoplov>();
    foreach(Zrakoplov zrakoplov in ZrakoplovBaza)
    {
        Zrakoplov z=new Zrakoplov();
        z.Naziv = zrakoplov.Naziv;
        z.Boja = zrakoplov.Boja;    
        z.KS = zrakoplov.KS;
        dohvaceniZrakoplovi.Add(z);
            return dohvaceniZrakoplovi;
    }

}
}