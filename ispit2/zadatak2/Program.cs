
List<int> djeljiviSa2i3 = new List<int>();
List<int> djeljiviSa2 = new List<int>();
List<int> djeljiviSa3 = new List<int>();
List<int> ostali = new List<int>();

while (true)
{
    Console.Write("unesi broj (0 za kraj): ");
    int broj;

    if (!int.TryParse(Console.ReadLine(), out broj))
    {
        Console.WriteLine("unesi isparavan broj");
        continue;
    }

    if (broj == 0)
        break;
    if (broj % 2 == 0 && broj % 3 == 0)
        djeljiviSa2i3.Add(broj);
    else if (broj % 2 == 0)
        djeljiviSa2.Add(broj);
    else if (broj % 3 == 0)
        djeljiviSa3.Add(broj);
    else
        ostali.Add(broj);
}

Console.WriteLine("brojevi djeljivi s 2 i 3: " + string.Join(", ", djeljiviSa2i3));
Console.WriteLine("brojevi djeljivi s 2 ali ne sa 3: " + string.Join(", ", djeljiviSa2));
Console.WriteLine("brojevu djeljivi s 3 ali ne s 2: " + string.Join(", ", djeljiviSa3));
Console.WriteLine("ostali brojevi: " + string.Join(", ", ostali));
        