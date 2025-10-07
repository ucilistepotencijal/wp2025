// Napiši program u kojem se traži unos broja i ispisuje je li
// broj u intervalu [0,12] ili nije

Console.Write("Upiši bilo koji broj: ");
decimal number = decimal.Parse(Console.ReadLine());

if (number >= 0 && number <= 12)
{
    Console.WriteLine("Broj {0} je u intervalu [0,12]!", number);
}
else
{
    Console.WriteLine("Broj {0} nije u intervalu [0,12]!", number);
}