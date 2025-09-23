

using System.Collections;

ArrayList niz = new ArrayList();

for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi {0}. broj: ", i + 1);
    int broj = int.Parse(Console.ReadLine());
    niz.Add(broj);
}
for (int i = niz.Count - 1; i >= 0; i--)
{
    Console.WriteLine(niz[i]);
}



