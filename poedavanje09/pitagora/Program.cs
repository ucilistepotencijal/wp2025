

Console.Write("unesi duljinu katete a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("unesi duljinu katete b: ");
double b = double.Parse(Console.ReadLine());

ispisHip(a, b);

partial class Program
{
    static void ispisHip(double a, double b)
    {
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("duljina hipotenuze: " + c);
    }
}