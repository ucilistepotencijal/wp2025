using Konstruktori;

Osoba o1  = new Osoba();
o1.Ime = "Ivan";
o1.Prezime = "Ivić";
Console.WriteLine("{0} {1}", o1.Ime, o1.Prezime);

Osoba o2 = new Osoba("Pero");
Console.WriteLine("{0} {1}", o2.Ime, o2.Prezime);

Osoba o3 = new Osoba("Ana", "Anić");
Console.WriteLine("{0} {1}", o3.Ime, o3.Prezime);

Osoba o4  = new Osoba("Josipović", true);
Console.WriteLine("{0} {1}", o4.Ime, o4.Prezime);

Osoba o5 = new Osoba("Josip", false);
Console.WriteLine("{0} {1}", o5.Ime, o5.Prezime);

List <Osoba> Osobe = new List <Osoba>();
Osobe.Add(o1);
Osobe.Add(o2);
Osobe.Add(o3);
Osobe.Add(o4);
Osobe.Add(o5);

Console.WriteLine("-----------------Ispis iz liste-------------");
foreach (Osoba o in Osobe)
{
    Console.WriteLine("{0} {1}", o.Ime, o.Prezime);
}