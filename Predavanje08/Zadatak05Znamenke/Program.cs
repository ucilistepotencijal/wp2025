// Unesi prirodni broj, a zatim znamenke upisanog broja ispisuj unatrag. 
// Svaku znamenku broja spremiti kao poseban element kolekcije
using System.Collections;

ArrayList listaZnamenki = new ArrayList();

Console.Write("Upiši višeznamenkasti Prirodni broj: ");
int broj = int.Parse(Console.ReadLine());

while (broj > 0)
{
    int znamenka = broj % 10;
    broj /= 10;
    listaZnamenki.Add(znamenka);
}
        
Console.WriteLine("Ispis višeznamenkastog prirodnog broja unazad: ");
for (int i = 0;i < listaZnamenki.Count; i++)
{
    Console.WriteLine(listaZnamenki[i]);
}

bool bBrojJeDobar = false;
string sBroj = "";

do
{
    Console.Write("Upši višeznamenkasti broj: ")
    try
    {

    }
    catch (Exception) 
    {

    }
} while (true);