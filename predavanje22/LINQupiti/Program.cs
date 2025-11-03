
using LINQupiti;

List<Osoba> osobe = new List<Osoba>();
osobe.Add(new Osoba { Ime = "pero", Prezime = "peric" });
osobe.Add(new Osoba { Ime = "ana", Prezime = "anic" });
osobe.Add(new Osoba { Ime = "iva", Prezime = "ivic" });
osobe.Add(new Osoba { Ime = "marko", Prezime = "markovic" });

Osoba trazenaOsoba = new Osoba();
foreach(Osoba o in osobe)
{
    if(o.Ime =="marko")
    {
        trazenaOsoba = o;
        Console.WriteLine("{0} {1}", o.Ime,o.Prezime);

    }
   
}

Osoba trazenaOsoba2 = (from o in osobe
                       where o.Ime == "marko"
                       select o).SingleOrDefault();

if(trazenaOsoba2 != null)
{
    Console.WriteLine("{0} {1}", trazenaOsoba2.Ime, trazenaOsoba2.Prezime);
}
