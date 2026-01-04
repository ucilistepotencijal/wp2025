using RefAndOut;

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

//ispisujem broj
Ispis(broj);

//Pozivamo metodu kojoj prosljeđujemo broj po vrijednosti
Inkrementiraj(broj);

//Ispisujem broj
Ispis(broj);

//Pozivamo metodu kojoj prosljeđujemo broj po vrijednosti
InkrementirajPoReferenci(ref broj);

//Ispisujem broj
Ispis(broj);

Osoba o = new Osoba();
o.Ime = "Ivo";
//o = null;
PromijeniIme(o); // Objekti se po defaultu prosljeđuju po referenci
Console.WriteLine(o.Ime);
o = null;
PromijeniPrezime(out o);
Console.WriteLine(o.Prezime);

partial class Program
{
    static void Inkrementiraj(int broj)
    {
        broj++;
    }
    static void Ispis(int broj)
    {
        Console.WriteLine("Vrijednost broja je {0}", broj);
    }
    static void InkrementirajPoReferenci(ref int broj)
    {
        broj++;
    }

    static void PromijeniIme(Osoba osoba)
    {
        osoba.Ime = "Pero";
    }
    static void PromijeniPrezime(out Osoba osoba)
    {
        osoba = new Osoba();
        osoba.Prezime = "Perić";
    }
}