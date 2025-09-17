
Console.Write("Upiši bilo koji broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= -9 && broj <= 9)
{
    Console.WriteLine("Broj je jednoznamenkast!");
}
else if (broj >= -99 && broj <= 99)
{
    Console.WriteLine("Broj je dvoznamenkast!");
}
else if (broj >= -999 && broj <= 999)
{
    Console.WriteLine("Broj je troznamenkast!");
}
else
{
    Console.WriteLine("Broj je višeznamenkast!");
}