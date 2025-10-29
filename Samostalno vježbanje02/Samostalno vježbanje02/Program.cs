/* Zadatak 1: Napravi program koji traži unos rečenice od korisnika, a zatim ispisuje 
koliko samoglasnika i koliko suglasnika rečenica sadrži. Program treba biti otporan 
na greške pri unosu.*/

// Fixes for CS1529, CS8956, and IDE0130:
// - Remove C++-style 'using namespace std;' (not valid in C#)
// - Convert C++ code to valid C# code
// - Use correct namespace matching folder structure

using System;

namespace Samostalno_vježbanje02
{
    class Program
    {
        // Function to count vowels and consonants
        static void BrojSamoglasnikaISuglasnika(string recenica, out int brojSamoglasnika, out int brojSuglasnika)
        {
            string samoglasnici = "aeiouAEIOU";
            brojSamoglasnika = 0;
            brojSuglasnika = 0;

            foreach (char znak in recenica)
            {
                if (char.IsLetter(znak))
                {
                    if (samoglasnici.IndexOf(znak) != -1)
                        brojSamoglasnika++;
                    else
                        brojSuglasnika++;
                }
            }
        }

        static void Main(string[] args)
        {
            int samoglasnici = 0, suglasnici = 0;
            while (true)
            {
                Console.Write("Unesi recenicu: ");
                string recenica = Console.ReadLine();

                // Input validation — must not be empty
                if (string.IsNullOrEmpty(recenica))
                {
                    Console.WriteLine("❗ Greska: recenica ne moze biti prazna. Pokusaj ponovo.\n");
                    continue;
                }

                // If input is valid — count
                BrojSamoglasnikaISuglasnika(recenica, out samoglasnici, out suglasnici);

                Console.WriteLine($"\n➡ Broj samoglasnika: {samoglasnici}");
                Console.WriteLine($"➡ Broj suglasnika: {suglasnici}");
                break;
            }
        }
    }
}