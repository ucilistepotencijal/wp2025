/* 3. Napiši program u kojem se traži unos 10 prirodnih brojeva. Parni i neparni brojevi spremaju
se odvojeno u dva objekta klase List<int>, a zaƟm se ispisuju te dvije kolekcije. */

List<int> parni = new List<int>();
List<int> neparni = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Unesi element s indeksom {0}: ", i);
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

Console.WriteLine("\nParni brojevi");
foreach (int p in parni)
{
    Console.WriteLine(p);
}
Console.WriteLine("\nNearni brojevi");
foreach (int n in neparni)
{
    Console.WriteLine(n);
}
