
List<int> parni = new List<int>();
List<int> neparni = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("unesi element s indeksom {0}: ");
    int broj = int.Parse(Console.ReadLine());

    if (broj % 2 == 0)
    {
        parni.Add(broj);
    }
    else
    {
        parni.Add(broj);
    }
}
    Console.WriteLine();

    Console.WriteLine("-----parni brojevi----");
    foreach (int p in parni)
    {
        Console.WriteLine(p);
    }
    foreach (int n in neparni)
    {
        Console.WriteLine(n);
    }





