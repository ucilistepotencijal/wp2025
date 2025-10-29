using ProizvoljneKolekcije_DAL;
using System.Collections;

Polaznik p1 = new Polaznik();
p1.Ime = "Pero";
p1.Prezime = "Perić";
p1.ProgramiObrazovanja = "ASP.NET";

Polaznik p2 = new Polaznik();
p2.Ime = "Ana";
p2.Prezime = "Anić";
p2.ProgramiObrazovanja = "WORDPRESS";

//1. implementacija pomoću ArrayListe
ArrayList polaznici = new ArrayList();
polaznici.Add(p1);
polaznici.Add(p2);

Console.WriteLine("Foreach ispis...");

foreach (Polaznik p in polaznici)
{
    Console.WriteLine(p.PunoIme());
}

Console.WriteLine();

Console.WriteLine("For ispis...");
for (int i = 0; i < polaznici.Count; i++)
{
    Console.WriteLine(((Polaznik)polaznici[i]).PunoIme());
}
Console.WriteLine();
Console.WriteLine("Implementacija pomoću proizvoljne kolekcije");
//2. Implementacija pomoću porizvoljne kolekcije
Polaznici polazniciKolekcija = new Polaznici();
polazniciKolekcija.Add(p1);
polazniciKolekcija.Add(p2);
polazniciKolekcija.Add("Ivan", "Ivanović");

foreach (Polaznik p in polazniciKolekcija)
{
    Console.WriteLine(p.PunoIme());
}