

using LINQupiti;

List<Osoba> osobe = new List<Osoba>();
osobe.Add(new Osoba { Ime = "Pero", Prezime = "Perić" });
osobe.Add(new Osoba { Ime = "Ana", Prezime = "Naić" });
osobe.Add(new Osoba { Ime = "Iva", Prezime = "Ivić" });
//osobe.Add(new Osoba { Ime = "Marko", Prezime = "Marković" });

//Pretraga bez LINQ upita
Osoba trazenaOsoba = new Osoba();
foreach (Osoba o in osobe)
{
    if (o.Ime == "Marko")
    {
        trazenaOsoba = o;
        Console.WriteLine("{0} {1}", o.Ime, o.Prezime);
    }
}

//Pretraga sa LINQ upitima
Osoba trazenaOsoba2 = (from o in osobe
                       where o.Ime == "Marko"
                       select o).SingleOrDefault();
if (trazenaOsoba2 != null)
{
    Console.WriteLine("{0} {1}", trazenaOsoba2.Ime, trazenaOsoba2.Prezime);
}
