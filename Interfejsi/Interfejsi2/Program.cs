using Interfejsi2;

Osoba o = new Osoba();
o.Ime = "Pero";
o.Prezime = "Perić";
o.Starost = 25;

Console.WriteLine(o.Detalji());

Osoba o2 = (Osoba)o.Clone();
Console.WriteLine(o2.Detalji());

if (o.CompareTo(o2) == 0)
{
    Console.WriteLine("Isto");
}
else
{
    Console.WriteLine("Nije isto");
}
