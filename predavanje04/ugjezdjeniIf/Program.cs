Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("unesi cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 0)
{
    Console.WriteLine("pozitivan je");
}
else
{
    if (broj < 0)
    {
        Console.WriteLine("negativan je");
    }
    else
    {
        Console.WriteLine("nula je");
    }
}