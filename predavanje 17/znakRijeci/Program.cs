Console.Write("unesi rijec: ");
string rijec = Console.ReadLine();

Console.Write("unesi znak: ");
string unos = Console.ReadLine();
char znak = unos[0];

int brojPonavljanja = 0;
int pozicija = rijec.IndexOf(znak);

while (pozicija != -1)
{
    brojPonavljanja++;
    pozicija = rijec.IndexOf(znak, pozicija + 1);
}

Console.WriteLine($"znak '{znak}' se pojavljuje {brojPonavljanja} puta u rijeci \"{rijec}\".");
