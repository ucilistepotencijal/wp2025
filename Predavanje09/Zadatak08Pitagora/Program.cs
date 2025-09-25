
Console.Write("Unesi duljinu katete a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Unesi dujlinu katete b: ");
double b = double.Parse(Console.ReadLine());

Ispis(a, b);

partial class Program
{
    static void Ispis(double a, double b)
    {
        Console.WriteLine($"Duljina hipotenuze: {Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2))}");
    }

}