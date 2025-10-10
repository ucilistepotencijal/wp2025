
using System.Runtime.CompilerServices;
using refAndOut;

Console.Write("unesi broj: ");
int broj = int.Parse(Console.ReadLine());

Ispis(broj);

inkrementirajPoInf(ref broj);

Inkrementiraj(broj);

Osoba o = new Osoba();
o.Ime = "ivo";
//o = null;
promjeniIme(o);
Console.WriteLine(o.Ime);
o = null;
promjeniPrezime(out o);
Console.WriteLine(o.Prezime);
partial class Program
{
    static void Inkrementiraj(int broj)
    {
        broj++;
    
    }
    static void Ispis(int broj)
    {
        Console.WriteLine("vrijednost broj je {0}", broj);
    }
    static void inkrementirajPoInf(ref int broj)
    {
        broj++;
    }
    static void promjeniIme(Osoba osoba)
    {
        osoba.Ime = "pero";
    }
    static void promjeniPrezime(out Osoba osoba)
    {
        osoba = new Osoba();
        osoba.Prezime = "peric";
    }

}
