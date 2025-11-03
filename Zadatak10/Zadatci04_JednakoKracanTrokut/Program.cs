
/*
Napiši program u kojem se za unesene duljine kateta u funkciji računa površina
jednakokračnog trokuta i ispisuje na zaslon.
*/


Console.Write("unesi duljinu osnovice a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("unesi visinu b: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Površina jednakokračnog trokuta je: {izracunPovrsine(a, b)}");

partial class Program
{
    static double izracunPovrsine(double a, double b)
    {
        return (a * b) / 2;
    }
}
