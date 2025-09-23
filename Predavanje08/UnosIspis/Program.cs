int[] niz = new int[10];

//Unos elemenata niza

for (int i = 0; i < niz.Length; i++)
{
    Console.Write("Unesi {0}. element niza: ", i);
    niz[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("_________ISPIS________");
for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}
Console.WriteLine("_________ISPIS__UNATRAG______");
// NE RADI niz.Reverse();
for (int i = niz.Length - 1; i >= 0 ; i--)
{
    Console.WriteLine(niz[i]);
}
Console.WriteLine("_________ISPIS___2_____");
foreach (int item in niz)
{
    Console.WriteLine(item);
}
