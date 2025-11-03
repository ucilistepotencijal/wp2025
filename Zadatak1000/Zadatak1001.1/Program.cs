
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> djeljivi23 = new List<int>();
        List<int> djeljivi2 = new List<int>();
        List<int> djeljivi3 = new List<int>();
        List<int> ostali = new List<int>();

        Console.WriteLine("Unesite brojeve (0 za kraj):");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out int broj))
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovno.");
                continue;
            }
            if (broj == 0)
                break;

            if (broj % 2 == 0 && broj % 3 == 0)
                djeljivi23.Add(broj);
            else if (broj % 2 == 0)
                djeljivi2.Add(broj);
            else if (broj % 3 == 0)
                djeljivi3.Add(broj);
            else
                ostali.Add(broj);
        }

        Console.WriteLine("\nBrojevi djeljivi s 2 i 3: " + string.Join(", ", djeljivi23));
        Console.WriteLine("Brojevi djeljivi s 2 ali ne sa 3: " + string.Join(", ", djeljivi2));
        Console.WriteLine("Brojevi djeljivi s 3 ali ne s 2: " + string.Join(", ", djeljivi3));
        Console.WriteLine("Ostali brojevi: " + string.Join(", ", ostali));
    }
}

