List<int> brojevi = new List<int>();
int broj;

Console.WriteLine("Unesite prirodne brojeve (0 za kraj):");

while (true)
{
    try
    {
        broj = int.Parse(Console.ReadLine());

        if (broj < 0)
        {
            Console.WriteLine("Unesite samo prirodne brojeve (pozitivne cijele brojeve ili 0 za kraj).");
            continue;
        }

        if (broj == 0)
            break;

        brojevi.Add(broj);
    }
    catch (FormatException)
    {
        Console.WriteLine("Greška: Unos mora biti broj!");
    }
}

// Sortiranje od najvećeg ka najmanjem
brojevi.Sort();
brojevi.Reverse();

Console.WriteLine("\nSortirani brojevi (od najvećeg ka najmanjem):");
foreach (int b in brojevi)
{
    Console.WriteLine(b);
}