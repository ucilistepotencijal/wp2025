
/*
Napravi program koji traži unos brojeva sve dok se ne unese broj 0.
Program ispisuje: 
Brojevi djeljivi s 2 i 3: ...
Brojevi djeljivi s 2 ali ne sa 3: ...
Brojevi djeljivi s 3 ali ne s 2: ...
Ostali brojevi: ...
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> djeljivi2 = new List<int>();
        List<int> djeljivi3 = new List<int>();
        List<int> djeljivi23 = new List<int>();
        List<int> ostali = new List<int>();

        int broj = int.Parse(Console.ReadLine());
        while (broj != 0)
        {
            if (broj % 2 == 0 && broj % 3 == 0)
            {
                djeljivi23.Add(broj);
            }
            else if (broj % 2 == 0)
            {
                djeljivi2.Add(broj);
            }
            else if (broj % 3 == 0)
            {
                djeljivi3.Add(broj);
            }
            else
            {
                ostali.Add(broj);
            }
            broj = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("\nBrojevi djeljivi s 2 i 3:" + string.Join(",", djeljivi23));
        Console.WriteLine("Brojevi djeljivi s 2 ali ne sa 3: " + string.Join(",", djeljivi2));
        Console.WriteLine("Brojevi djeljvii s 3 ali ne s 2:" + string.Join("," ,djeljivi3));
        Console.WriteLine("Ostali brojevi:" + string.Join(",", ostali));
    }
}




 
