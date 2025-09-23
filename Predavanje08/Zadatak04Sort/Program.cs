

using System.Collections;

int[] niz = new int[];

//Unos elemenata niza

for (int i = 0; i < niz.Length; i++)
{

    while (i != 0)
    {
        Console.Write("Unesi {0}. element niza: ", i);
        niz[i] = int.Parse(Console.ReadLine());
    }

}

for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}




using System.Collections;

ArrayList nizElemenata = new ArrayList();

for (int i = 0; i < nizElemenata.Count; i++)
{
    while (i != 0)
    {
        Console.Write("Unesi {0}. broj: ", i );
        int broj = int.Parse(Console.ReadLine());
        nizElemenata.Add(broj);
    }
    
}
for (int i = nizElemenata.Count - 1; i >= 0; i--)
{
    Console.WriteLine(nizElemenata.[i]);
}











