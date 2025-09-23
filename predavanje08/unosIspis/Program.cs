

int[] niz = new int[10];

for (int i = 0; i < niz.Length; i++)
{
    Console.Write("unesi element niza: ", i);
    niz[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("-----ispis-----");
for(int i = 0; i< niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}
Console.WriteLine("-----ispis unazad-----");
//niz.Reverse();
for (int  i = niz.Length - 1; i >= 0; i--)
{
    Console.WriteLine(niz[i]);
}

Console.WriteLine("-----ispis2-----");
foreach (int item in niz)
{
    Console.WriteLine(item);
}