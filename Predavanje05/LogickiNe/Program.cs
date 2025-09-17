Console.Write("Mapiši naziv škole koju pohađaš: ");
string nazivSkole = Console.ReadLine();

if (nazivSkole != "Potencijal")
{
    Console.WriteLine("Upišite tečaj u Učilištu Potencijal!");
}
else
{
    Console.WriteLine("Bravo!");
}

//2. način
if (nazivSkole == "Potencijal")
{
    Console.WriteLine("Bravo!");
}
else
{
    Console.WriteLine("Upišite tečaj u Učilištu Potencijal!");
}

