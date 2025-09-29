/* Napiši program u kojem se u funkciji ispituje je li uneseni prirodan broj prost ili složen i
odgovor ispisuje na zaslon. U programu korisnik treba imati mogućnost ponovnog računanja
ako unutar glavne metode na pitanje „Želiš li ponovo (D/N)?“ odgovori potvrdno.
Napomena: Broj je prost ako je djeljiv samo sa 1 i sa samim sobom */

using System.Collections;

bool bPonovi = true;

while (bPonovi)
{
    try
    {
        Console.Write("Unesi prirodni broj: ");
        int iBroj = int.Parse(Console.ReadLine());
        if (iBroj < 0)
        {
            throw new Exception("Niste unijeli prirodan broj!");
        }
        string sProstSlozen = Prost(iBroj) ? "prost" : "složen";

        // isto kao:
        //string sProstSlozen = "";
        //if (Prost(iBroj) == true)
        //{
        //  sProstSlozen = "Prost";
        //}
        //else
        //{
        //  sProstSlozen = "Složen";
        //}


        Console.Write("Broj je {0}. ", sProstSlozen);

        Console.Write("Želiš li ponovo (D/N)?");
        string unos = Console.ReadLine();
        if (unos.ToLower() == "n")
        {
            bPonovi = false;
        }
    }
    catch (Exception e)
    {

        Console.WriteLine("Dogodila se greška: " + e);
    }
}
partial class Program
{
    static bool Prost(int broj)
    {
        int brojDjelitelja = 0;
        for (int i = 1; i <= broj; i++)
        {
            if (broj % i == 0)
            {
                brojDjelitelja++;
            }
        }
        if (brojDjelitelja == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}