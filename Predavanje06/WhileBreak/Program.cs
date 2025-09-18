using System;

while (true) // beskonačna petlja
{
    Console.Write("Unesi ime: ");
    string ime = Console.ReadLine();

    if (ime.ToLower() == "kraj")
    {
        break;
    }

    Console.WriteLine("Dobar dan, {0}!", ime);
}

    Console.WriteLine();

string ime2 = "";
// pomoćna varijabla (flag) tipa boolean
bool ponovi = true;

while (ponovi)
{
    Console.Write("Unesi ime: ");
    ime2 = Console.ReadLine();

    if (ime2.ToLower() == "kraj")
    {
        ponovi = false;
    }
    else
    {
        Console.WriteLine("Dobar dan, {0}!", ime2);
    }

    Console.WriteLine();
}
