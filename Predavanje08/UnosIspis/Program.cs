
//Deklariramo array od 10 elemenata
int[] niz = new int[10];

//unos elemenata niza
for (int i = 0; i < niz.Length; i++)
{
    Console.Write("Unesi {0}. element niza: ", i);
    niz[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("--------------- Ispis ----------------");
for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}

Console.WriteLine("--------------- Ispis unatrag ----------------");
//ne radi: niz.Reverse();
for (int i = niz.Length - 1; i >= 0; i--)
{
    Console.WriteLine(niz[i]);
}

Console.WriteLine("------------ Ispis 2 --------------------");
foreach (int item in niz)
{
    Console.WriteLine(item);
}