//Za uneseni broj treba provjeriti je li veći od 100, veći od 200 ili veći od 300
using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 300)
{
    Console.WriteLine("Broj je veći od 300!");
}
else if (broj > 200)
{
    Console.WriteLine("Broj je veći od 200!");
}
else if (broj > 100)
{
    Console.WriteLine("Broj je veći od 100!");
}
else
{
    Console.WriteLine("Broj nije veći od 100!");
}

//Drugi način

if (broj > 100 && broj <= 200)
{
    Console.WriteLine("Broj je veći od 100!");
}
else if (broj > 200 && broj <= 300)
{
    Console.WriteLine("Broj je veći od 200!");
}
else if (broj > 300)
{
    Console.WriteLine("Broj je veći od 300!");
}
else
{
    Console.WriteLine("Broj je manji od 100!");
}