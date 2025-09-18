//1. Želim da korisnik upisuje svoje ime sve dok ne napiše kraj

string ime = "";

while (ime != "kraj")
{
    Console.Write("Upiši svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("Dobar  dan {0}!", ime);
    }
    
}

//2. Do while petlja
do
{
    Console.Write("Upiši svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("Dobar  dan {0}!", ime);
    }

} while (ime != "kraj");
Console.WriteLine();
