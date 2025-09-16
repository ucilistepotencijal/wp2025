using System.ComponentModel.Design;

Console.OutputEncoding  = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;


Console.Write("Unesi cijeli broj: ");
int number  = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Broj je pozitivan!");
}
else
{
    if (number < 0)
    {
        Console.WriteLine("Broj je negativan");
    }
    else
    {
        Console.WriteLine("Broj je nula!");
    }
}
