
/* Napravite program koji traži unos riječi od korisnika. Program treba
nastaviti tražiti unos dok korisnik ne unese riječ koja je već prethodno unesena.
Nakon toga, program treba ispisati riječ koja se ponovila i završiti izvršavanje */



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var uneseneRijeci = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        while (true)
        {
            Console.Write("Unesite riječ: ");
            string rijec = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(rijec))
            {
                Console.WriteLine("Unos ne smije biti prazan. Pokušajte ponovno.");
                continue;
            }

            if (!uneseneRijeci.Add(rijec))
            {
                Console.WriteLine($"Riječ koja se ponovila: {rijec}");
                break;
            }
        }
    }
}

