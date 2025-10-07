

Console.Write("Unesite broj: ");
decimal broj = decimal.Parse(Console.ReadLine());

if (broj >= 0 && broj <= 12)
{
    Console.WriteLine("Broj je u intervalu [0, 12].");
}
else
{
    Console.WriteLine("Broj nije u intervalu [0, 12].");
}