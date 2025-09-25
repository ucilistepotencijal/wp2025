

List<int> par = new List<int>();
List<int> nepar = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi unesi broj {0}: ", i);
    int broj = int.Parse(Console.ReadLine());
    if (broj % 2 == 0)
    {
        par.Add(broj);
    }
    else
    {
        nepar.Add(broj);
    }
}
Console.WriteLine();

Console.WriteLine("parni: ");
foreach (int p in par)
{
    Console.WriteLine(p);
}

Console.WriteLine("neparni: ");
foreach (int n in nepar)
{
    Console.WriteLine(n);
}