Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 0)
{
    Console.WriteLine("Broj je pozitivan");
}
else 
{ 
    if (broj<0)
    {
        Console.WriteLine("Broj je negativan");
    }
    else
    {
        Console.WriteLine("Broj je nula");
    }
}
