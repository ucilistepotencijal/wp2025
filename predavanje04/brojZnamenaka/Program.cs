
Console.Write("unesite cijeli broj (moze biti i negativan): ");
int broj = int.Parse(Console.ReadLine());

if (broj < 0)
    broj = -broj;

if (broj < 10)
{
    Console.WriteLine("jednoznamenkast je");
}
else if (broj < 100)
{
    Console.WriteLine("dvoznamenkast je");
}
else if (broj < 1000)
{
    Console.WriteLine("troznamenkast je");
}
else
{
    Console.WriteLine("viseznamenkast je");
}