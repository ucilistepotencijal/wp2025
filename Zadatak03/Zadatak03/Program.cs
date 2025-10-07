
        class Program
{
    static void Main()
    {
        int broj;
        int brojac = 0;
        long umnozak = 1;

        Console.WriteLine("Unesite 10 brojeva:");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj % 3 == 0)
            {
                brojac++;
                umnozak *= broj;
            }
        }

        Console.WriteLine($"\nBrojeva djeljivih s 3 ima: {brojac}");

        if (brojac > 0)
            Console.WriteLine($"Njihov umnožak je: {umnozak}");
        else
            Console.WriteLine("Nema brojeva djeljivih s 3, pa nema ni umnoška.");
    }
}
