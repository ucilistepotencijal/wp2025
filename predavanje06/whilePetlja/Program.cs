

string ime = "";

while (ime != "kraj")
{
    Console.WriteLine("upisi svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("dobar dan {0}!", ime);
    }
}
Console.WriteLine();

do
{
    Console.WriteLine("upisi svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("dobar dan {0}!", ime);
    }
} while (ime != "kraj");
Console.WriteLine();

