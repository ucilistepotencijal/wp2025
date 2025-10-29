

using System;
using System.Collections.Generic;

namespace imena
{
    class Program
    {
        static void Main()
        {
            List<string> imena = new List<string>();
            string ime;

            // Unos imena dok se ne unese "kraj"
            while (true)
            {
                Console.Write("Unesi ime (ili 'kraj' za završetak): ");
                ime = Console.ReadLine();

                // Pretvori ime u mala slova za provjeru riječi "kraj"
                string ime_malo = ime.ToLower();

                if (ime_malo == "kraj")
                {
                    break;
                }

                imena.Add(ime);
            }

            Console.WriteLine("\nImena koja sadrže slovo 'a':");

            // Ispis imena koja sadrže 'a' ili 'A'
            foreach (string i in imena)
            {
                string i_malo = i.ToLower();
                if (i_malo.Contains('a'))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}