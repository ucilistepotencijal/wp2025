

/* Napiši program u kojem se traži unos duljina kateta a i b pravokutnog trokuta i zaƟm se u
potprogramu ispisuje duljina hipotenuze.
c=√a2+b2 */

//napomene:
//drugi korijen: Math.Sqrt()
//a na kvadrat: Math.Pow(a,2) ili a * a

using System.Collections;

Console.Write("Unesi duljinu katete a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Unesi duljinu katete b: ");
double b = double.Parse(Console.ReadLine());

DuljinaHipotenuze(a, b);
partial class Program
{
    static void DuljinaHipotenuze(double a, double b)
    {
        Console.WriteLine(Math.Sqrt((a * a) + (b * b)));
    }
}

