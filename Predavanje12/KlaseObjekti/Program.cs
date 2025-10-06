using KlaseObjekti;

Osoba osoba = new Osoba();
osoba.Ime = "Pero";
osoba.Prezime = "Perić";

string punoIme = osoba.VratiPunoIme();

Console.WriteLine("Puno ime osobe je " + punoIme);

Osoba osoba2 = new Osoba();

Console.Write("Unesi ime: ");
osoba2.Ime = Console.ReadLine();

Console.Write("Unesi prezime: ");
osoba2.Prezime = Console.ReadLine();

Console.WriteLine("Puno ime je {0} ", osoba2.VratiPunoIme());

Osoba osoba3 = new Osoba
{
    Ime = "Josip",
    Prezime = "Josipović"

};
Console.WriteLine(osoba3.VratiPunoIme());