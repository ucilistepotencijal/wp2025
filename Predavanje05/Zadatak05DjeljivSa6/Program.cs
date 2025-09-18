Console.WriteLine("Verujem li da ce se CAZZO ozeniti?");
string prsten = "";

while (prsten.ToLower() != "da" && prsten.ToLower() != "ne")
{
    Console.Write("Da li je prsten na ruci? ");
    prsten = Console.ReadLine();

    if (prsten.ToLower() == "da")
    {
        Console.WriteLine("Verujem!");
    }
    else if (prsten.ToLower() == "ne")
    {
        Console.WriteLine("Neverujem!");
    }
    else
    {
        Console.WriteLine("Molim odgovoriti sa DA ili NE!");
    }

}



