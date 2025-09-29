
Console.Write("unesi prvi broj: ");
decimal prvi = decimal.Parse(Console.ReadLine());

Console.Write("unesi drugi broj: ");
decimal drugi = decimal.Parse(Console.ReadLine());

ispis(prvi, drugi);
partial class Program
{
    static void ispis(decimal a, decimal b)
    {
        Console.WriteLine(a + b);
    }
}

