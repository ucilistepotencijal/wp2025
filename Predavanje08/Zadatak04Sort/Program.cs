
int[] niz = new int[broj != 0];

//Unos elemenata niza

for (int i = 0; i < niz.Length; i++)
{
    Console.Write("Unesi {0}. element niza: ", i);
    niz[i] = int.Parse(Console.ReadLine());
}


for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}





for (int i = 0; broj != 0; i++)
    {
        Console.Write("Unesi {0}. broj: ", i);
        int broj = int.Parse(Console.ReadLine());
        niz.Add(broj);

        
    }
    for (int i = 0; i < niz.Count; i++)
    {
        Console.WriteLine(niz[i]);
    }











