/* 8. Napiši program u kojem se traži unos prirodnog broja n. Korisnik zatim unosi n prirodnih
brojeva, a zatim se ispisuje njihov prosjek. */

Console.Write("Unesi koliko brojeva želiš unijeti: ");
int n = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write($"Unesi {i}. broj: ");
    int broj = int.Parse(Console.ReadLine());
    suma += broj;
}

double prosjek = (double)suma / n;
Console.WriteLine("Prosjek unesenih brojeva je: " + prosjek);