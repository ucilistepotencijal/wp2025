// Napiši program koji traži unos jedne riječi i unos jednog znaka i zatim ispisuje koliko se
// puta taj znak pojavjuje u toj rječ

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

//2. način

Console.Write("Unesi riječ: ");
string rijec1 = Console.ReadLine();

Console.Write("Unesi jedan znak: ");
char x1 = char.Parse(Console.ReadLine());

int xURijec1 = 0;

for (int i = rijec1.Length - 1; i >= 0; i--)
{
    int pozicija = rijec1.IndexOf(x1, i);
    if (pozicija == i)
    {
        xURijec1++;       
    } 

}
Console.WriteLine("{0} se pojavljuje {1} puta u riječi {2}", x1, xURijec1, rijec1);