// See https://aka.ms/new-console-template for more information

Console.Write("Unesite broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 300)
{
    Console.WriteLine("Broj je veći od 300");
}
else if (broj > 200)
{
    Console.WriteLine("Broj je veći od 200");
}
else if (broj > 100)
{
    Console.WriteLine("Broj je veći od 100");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 100");
}



if (broj > 100 && broj <= 200)
{
    Console.WriteLine("Broj je veći od 100");
}
else if (broj > 200 && broj <= 300)
{
    Console.WriteLine("Broj je veći od 200");
}
else if (broj > 300 )
{
    Console.WriteLine("Broj je veći od 300");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 100");
}