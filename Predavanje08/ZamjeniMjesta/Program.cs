/* Napiši program u kojem se traži unos 10 brojeva koji se zatim ispisuju, ali najvećem i
najmanjem treba zamijeniti mjesta. */

int[] niz = new int[10];
int max = int.MinValue;
int min = int.MaxValue;
int indeksMax = 0;
int indeksMin = 0;

for (int i = 0; i < niz.Length; i++)
{
    Console.Write("Unesi element s indeksom {0}: ", i);
    niz[i] = int.Parse(Console.ReadLine());

    if (niz[i] > max)
    {
        max = niz[i];
        indeksMax = i;
    }
    else
    {
        min = niz[i];
        indeksMin = i;
    }
}

int hold = niz[indeksMax];
niz[indeksMax] = niz[indeksMin];
niz[indeksMin] = hold;

Console.WriteLine("\nIspis nakon zamjene: ");
for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}
