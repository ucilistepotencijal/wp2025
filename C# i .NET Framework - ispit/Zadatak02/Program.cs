// Zadatak 2: Napravi program koji traži unos brojeva sve dok se ne unese broj 0.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<int> djeljiviSa2i3 = new List<int>();
        List<int> djeljiviSa2 = new List<int>();
        List<int> djeljiviSa3 = new List<int>();
        List<int> ostali = new List<int>();

        int broj;

        Console.WriteLine("Unosi brojeve (0 za kraj):");

        while (true)
        {
            Console.Write("Broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj == 0)
                break;

            if (broj % 2 == 0 && broj % 3 == 0)
                djeljiviSa2i3.Add(broj);
            else if (broj % 2 == 0)
                djeljiviSa2.Add(broj);
            else if (broj % 3 == 0)
                djeljiviSa3.Add(broj);
            else
                ostali.Add(broj);
        }

        Console.WriteLine("\n--- REZULTATI ---");
        Console.WriteLine("Brojevi djeljivi s 2 i 3: " + string.Join(", ", djeljiviSa2i3));
        Console.WriteLine("Brojevi djeljivi s 2 ali ne sa 3: " + string.Join(", ", djeljiviSa2));
        Console.WriteLine("Brojevi djeljivi s 3 ali ne s 2: " + string.Join(", ", djeljiviSa3));
        Console.WriteLine("Ostali brojevi: " + string.Join(", ", ostali));
    }
}
