// See https://aka.ms/new-console-template for more information

Console.Write("unesite broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 10)
{
    Console.WriteLine("Broj je veći od 10");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 10");
}


if (broj > 10)
{
    Console.WriteLine("Broj je veći od 10");
}
else if (broj ==10)
{
    Console.WriteLine("broj je jednak 10");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 10");
}