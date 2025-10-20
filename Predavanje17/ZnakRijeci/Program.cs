// 3. Napiši program koji traži unos jedne riječi i unos jednog znaka i zatim ispisuje koliko se
// puta taj znak pojavjuje u toj rječ

using System;
using System.Formats.Tar;
using System.Reflection;

Console.Write("Unesi riječ: ");
string rijec = Console.ReadLine();

Console.Write("Unesi jedan znak: ");
char x = char.Parse(Console.ReadLine());

int xURijec = 0;

for (int i = 0; i < rijec.Length; i++)
{
    if (rijec[i] == x)
    {
        xURijec++;
    }

}
Console.WriteLine("{0} se pojavljuje {1} puta u riječi {2}", x, xURijec, rijec);
