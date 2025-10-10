using RefAndOut;

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

//ispisujemo broj
Ispis(broj);

//Pozivamo metodu kojoj proslijeđujemo broj po vrijednosti
InkrementirajPoReferenci(ref broj); //po referenci znaci da je ta varijabla upisana negdje u komp memoriju - predaje se memorijska lokacija tog broja a ne broj.

//Ispisujem broj
Ispis(broj);

Osoba o = new Osoba();
o.Ime = "Ivo";
//o = null;
PromijeniIme(ref o); //Objekti se po defaultu proslijeđuju po referenci
Console.WriteLine(o.Ime);
o = null;
PromijeniPrezime(out o); //Ova metoda može vraćati i string npr. (trenutno je void), ali u isto vrijeme vrća i int pomoću out-a )
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
    static void PromijeniIme(ref Osoba osoba)
    {
        osoba.Ime = "Pero";
    }
    static void PromijeniPrezime(out Osoba osoba) //out nam služi kad je nešto neinicijalizirano a s tim moramo nešto odraditi
    {
        osoba = new Osoba();
        osoba.Prezime = "Perić";
    }

}
