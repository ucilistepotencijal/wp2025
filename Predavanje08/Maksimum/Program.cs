int[] niz = new int[5];
int max = int.MinValue;

for (int i = 0; i < niz.Length; i++)
{
    Console.Write("Unesi element s indeksom {0}: ", i);
    niz[i] = int.Parse(Console.ReadLine());

    if (niz[i] > max)
    {
        max = niz[i];
    }
}

Console.WriteLine("Ispis: ");

for (int i = 0; i < niz.Length; i++)
{
    if (niz[i] == max)
    { 
        Console.ForegroundColor = ConsoleColor.Red;
    }
    Console.WriteLine(niz[i]);
    Console.ResetColor();
}