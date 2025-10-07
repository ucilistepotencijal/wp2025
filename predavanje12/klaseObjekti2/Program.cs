
using klaseObjekti2;

Osoba o = new Osoba();
o.ime = "matko";
o.prezime = " matkovic";

Console.WriteLine(o.punoIme());

Console.WriteLine("broj osoba je: " + Osoba.dohvatiBrojOsoba());

Osoba o2 = new Osoba();
o2.ime = "ana";
o2.prezime = "anic";
Console.WriteLine(o2.punoIme());

Console.WriteLine("broj osoba je: " + Osoba.dohvatiBrojOsoba());

Osoba o3 = new Osoba();
Console.WriteLine(o3.punoIme());

Console.WriteLine("broj osoba je: " + Osoba.dohvatiBrojOsoba());