
Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

//ispisujem broj
Ispis(broj);

//Pozivam metodu kojoj prosljeđujemo broj po vrijednosti
Inkrementiraj(broj);   

//Ispisujem broj
Ispis(broj);


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

}

static void InkrementirajPoReferenci (ref int broj) 
{
    broj++;
