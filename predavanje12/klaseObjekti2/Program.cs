using KlaseObjekti2;

Osoba o = new Osoba();
o.Ime = "Matko";
o.Prezime = "Matković";
Console.WriteLine(o.PunoIme());

Console.WriteLine("Broj osoba je: " + Osoba.DohvatiBrojOsoba());

Osoba o2 = new Osoba();
o2.Ime = "Ana";
o2.Prezime = "Anić";
Console.WriteLine(o2.PunoIme());

Console.WriteLine("Broj osoba je: " + Osoba.DohvatiBrojOsoba());

Osoba o3 = new Osoba("Ivana", "Ivanović");
Console.WriteLine(o3.PunoIme());

Console.WriteLine("Broj osoba je: " + Osoba.DohvatiBrojOsoba());

