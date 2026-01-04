// Unesi prirodni broj, a zatim znamenke upisanog broja ispisuj unatrag. 
// Svaku znamenku broja spremiti kao poseban element kolekcije
using System.Collections;

//1. način - matematika

ArrayList listaZnamenki = new ArrayList();

Console.Write("Upiši višeznamenkasti Prirodni broj: ");
int broj = int.Parse(Console.ReadLine());

//npr. znamenke broja 123
// 123 / 10 = 12 i ostatak 3
// 12 / 10 = 1 i ostatak 2
// 1 / 10 = 0 i ostatak 1



while (broj > 0)
{
    int znamenka = broj % 10;
    broj /= 10;
    listaZnamenki.Add(znamenka);
}

Console.WriteLine("Ispis višeznamenkastog prirodnog broja unazad: ");
for (int i = 0; i < listaZnamenki.Count; i++)
{
    Console.WriteLine(listaZnamenki[i]);
}

// 2. način
bool bBrojJeDobar = false;
string sBroj = "";
do
{
    Console.Write("Upiši višeznamenkasti prirodni broj: ");
    sBroj = Console.ReadLine();
	try
	{
		int iBroj = int.Parse(sBroj);
        if (iBroj > 9)
        {
            bBrojJeDobar = true;
        }
        else
        {
            Console.WriteLine("Broj nije višeznamenkast prirodni broj!");
        }
    }
	catch (Exception)
	{
        Console.WriteLine("Krivi unos!");
    }
} while (!bBrojJeDobar);
for (int i = sBroj.Length - 1; i >= 0; i--)
{
    Console.WriteLine(sBroj[i]);
}