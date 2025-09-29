/* 2. Napiši program u kojem se za unesene duljine kateta u funkciji računa površina
jednakokračnog trokuta i ispisuje na zaslon.
P= (a∗b)/2 */

using System.Collections;

while (true)
{
    try
    {
        Console.Write("Unesi duljinu prve katete: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Unesi duljinu druge katete: ");
        double b = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0)
        {
            Console.WriteLine("Duljina ne može biti 0, ponovno unesi vrijednosti:");
            continue;
        }

        PovrsinaJkTrokuta(a, b);

    }

    catch (System.Exception)
    {
        Console.WriteLine("Dogodila se greška, ponovno unesi vrijednosti: ");
    }
}
partial class Program
{
    static void PovrsinaJkTrokuta(double a, double b)
    {
        Console.WriteLine("\nPovršina jednakokracnog trokuta čije su duljine kateta {0} i {1}: {2}", a, b, ((a * b) / 2));
    }

}





