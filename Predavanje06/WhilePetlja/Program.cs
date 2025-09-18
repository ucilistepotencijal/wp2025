
// Želim da korisnik upisuje svoje ime sve dok ne napiše "kraj"
string ime;
ime = "";

// While - ne mora se izvršiti niti jednom

while (ime  != "kraj")
{
    Console.Write("Upiši svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("Dobar dan {0}!", ime);
    }
        
}
Console.WriteLine();

// Do while petlja - izvršiti će se najmanje 1 put

do
{
    Console.Write("Upiši svoje ime: ");
    ime = Console.ReadLine();

    if (ime != "kraj")
    {
        Console.WriteLine("Dobar dan {0}!", ime);
    }

} while (ime != "kraj");
Console.WriteLine();

