
/*Napravi program koji traži unos rečenice od korisnika, a zatim ispisuje
koliko samoglasnika i koliko suglasnika rečenica sadrži. Program treba biti otporan
na greške pri unosu. */


using System;

class Program
{
    static void Main()
    {
        string input;
        while (true)
        {
            Console.Write("Unesite rečenicu: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Greška: Unos ne smije biti prazan. Pokušajte ponovno.");
                continue;
            }
            break;
        }

        int brojSamoglasnika = 0;
        int brojSuglasnika = 0;
        string samoglasnici = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (samoglasnici.Contains(c))
                    brojSamoglasnika++;
                else
                    brojSuglasnika++;
            }
        }

        Console.WriteLine($"Broj samoglasnika: {brojSamoglasnika}");
        Console.WriteLine($"Broj suglasnika: {brojSuglasnika}");
    }
}