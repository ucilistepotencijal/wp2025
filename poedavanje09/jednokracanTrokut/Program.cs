
Console.Write("unesi duljinu osnovice a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("unesi visinu b: ");
double b = double.Parse(Console.ReadLine());

ispisPovrsine(a, b);

partial class Program
{
    static void ispisPovrsine(double a, double b)
    {
        double P = (a * b) / 2;
        Console.WriteLine($"površina jednakokračnog trokuta je: {P}");
    }
}