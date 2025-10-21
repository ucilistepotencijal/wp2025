
using System.Threading.Channels;
using numeracije;

Console.WriteLine(Spol.Muski);
Console.WriteLine((int)Spol.Muski);

Osoba osoba = new Osoba();
osoba.Ime = "iva";
osoba.Prezime = "ivic";
osoba.Spol = Spol.Zenski;
osoba.IspisiDetalje();

string jos = "da";
List<Osoba> osobe = new List<Osoba>();

while (jos != "ne")
{
    Osoba osoba2 = new Osoba();
    Console.Write("unesi ime: ");
    osoba2.Ime = Console.ReadLine();
    Console.Write("unesi prezime: ");
    osoba2.Prezime = Console.ReadLine();
    Console.Write("unesi spol (0=muski, 1=zenski): ");
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
        osoba2.Spol = Spol.nepoznato;
    }
    osobe.Add(osoba2);
    Console.WriteLine("zelite li unijeti jos osoba (da/ne?)");
    jos = Console.ReadLine();
}
foreach (Osoba o in osobe)
{
    switch (o.Spol)
    {
        case Spol.Muski:
            Console.WriteLine("osoba {0} {1} je musko", o.Ime, o.Prezime);
            break;
        case Spol.Zenski:
            Console.WriteLine("osoba {0} {1} je zensko", o.Ime, o.Prezime);
            break;
        default:
            Console.WriteLine("nije poznat spol osobe {0} {1}", o.Ime, o.Prezime);
            break;

    }
}