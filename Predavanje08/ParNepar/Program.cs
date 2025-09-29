
List<int> parni = new List<int>();
List<int> neparni = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi element s indeksom {0}: ", i);
    int broj = int.Parse(Console.ReadLine());

    if (broj % 2 == 0)
    {
        parni.Add(broj);
    }
    else
    {
        neparni.Add(broj);
    }
}
Console.WriteLine();

Console.WriteLine("--------------------- Parni brojevi --------------------------");
foreach (int p in parni)
{
    Console.WriteLine(p);
}

Console.WriteLine("--------------------- Neparni brojevi --------------------------");
foreach (int n in neparni)
{
    Console.WriteLine(n);
}