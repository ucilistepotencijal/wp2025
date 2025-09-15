//Za uneseni broj provjeriti je li veći od 100, 200 ili 300

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi jedan troznamenkasti cijeli broj: ");
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
    Console.WriteLine("Broj nije veći od 100");
}

//drugi način

if (broj > 100 && broj <= 200)
{
    Console.WriteLine("Broj je veći od 100");
}
else if (broj > 200 && broj <= 300)
{
    Console.WriteLine("Broj je veći od 200");
}
else if (broj > 300)
{
    Console.WriteLine("Broj je veći od 300");
}
else
{
    Console.WriteLine("Broj nije veći od 100");
}
