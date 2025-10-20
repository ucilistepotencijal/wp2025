//5. Napiši program koji traži unos jedne rečenice i unos jedne rječi
// i zatim ispisuje koliko se puta ta riječ pojavljuje u toj rečenici.

Console.Write("Unesi recenicu: ");
string recenica = Console.ReadLine();
Console.Write("Unesi rijec: ");
string rijec = Console.ReadLine();

recenica = recenica.Replace("!", "").Replace(".", "").Replace(",", "").Trim().ToLower();

string[] rijeci = recenica.Split(" ");
int brojac = 0;

foreach (string r in rijeci)
{
    if (r == rijec)
    {
        brojac++;
    }
    
}

if (brojac > 0)
{
    Console.WriteLine($"Riječ se pojavljuje {brojac} puta.");
}
else
{
    Console.WriteLine("Riječ se ne pojavljuje u rečenici.");
}
    

