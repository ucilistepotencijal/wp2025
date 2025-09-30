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

        Console.WriteLine($"Površina jednakokračnog trokuta je: {izracunPovrsine(a, b)}");
    }

    catch (System.Exception)
    {
        Console.WriteLine("Dogodila se greška, ponovno unesi vrijednosti: ");
    }
}
partial class Program
{
    static double izracunPovrsine(double a, double b)
    {
        return (a * b) / 2;
    }
}





