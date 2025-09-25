Console.Write("Unesi prvi broj: ");
decimal prvi = decimal.Parse(Console.ReadLine());

Console.Write("Unesi drugi broj: ");
decimal drugi = decimal.Parse(Console.ReadLine());

Ispis(prvi, drugi);




partial class Program
{
    static void Ispis(decimal a, decimal b)
    {
        Console.WriteLine(a + b);
    }
}