using Enumeracije;

Console.WriteLine(Spol.Muski);
Console.WriteLine((int)Spol.Muski);
Osoba osoba = new Osoba();
osoba.Ime = "Iva";
osoba.Prezime = "Ivić";
osoba.Spol = Spol.Zenski;
osoba.IspisiDetalje();

string jos = "da";
List<Osoba> osobe = new List<Osoba>();
while (jos != "ne")
{
    Osoba osoba2 = new Osoba();
    Console.Write("Unesi ime: ");
    osoba2.Ime = Console.ReadLine();
    Console.Write("Unesi prezime: ");
    osoba2.Prezime = Console.ReadLine();
    Console.Write("Unesi spol (0=muški, 1=ženski): ");
    int mojSpol = int.Parse(Console.ReadLine());
    if (mojSpol == 0)
    {
        osoba2.Spol = Spol.Muski;
    }
    else if (mojSpol == 1)
    {
        osoba2.Spol = Spol.Zenski;
    }
    else
    {
        osoba2.Spol = Spol.Nepoznato;
    }
    osobe.Add(osoba2);
    Console.Write("Želite li unijeti još osoba (da/ne)? ");
    jos = Console.ReadLine();
}
foreach (Osoba o in osobe)
{
    switch (o.Spol)
    {
        case Spol.Muski:
            Console.WriteLine("Osoba {0} {1} je muško.", o.Ime, o.Prezime);
            break;
        case Spol.Zenski:
            Console.WriteLine("Osoba {0} {1} je žensko.", o.Ime, o.Prezime);
            break;
        default:
            Console.WriteLine("Nije poznat spol osobe {0} {1}!", o.Ime, o.Prezime);
            break;
    }
}