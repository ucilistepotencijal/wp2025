using System;

class Program
{
    static void Main()
    {
        int broj;
        int najmanji = int.MaxValue;
        int najveci = int.MinValue;

        Console.WriteLine("Unosite prirodne brojeve (0 za kraj):");

        while (true)
        {
            Console.Write("Unesi broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj == 0)
                break;

            if (broj < najmanji)
                najmanji = broj;

            if (broj > najveci)
                najveci = broj;
        }

        if (najmanji == int.MaxValue && najveci == int.MinValue)
        {
            Console.WriteLine("Niste unijeli niti jedan broj.");
        }
        else
        {
            Console.WriteLine($"Najmanji uneseni broj: {najmanji}");
            Console.WriteLine($"Najveći uneseni broj: {najveci}");
        }
    }
}

