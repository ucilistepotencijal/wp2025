using System.Collections;

ArrayList brojevi = Unos();
Console.WriteLine("__________Ispis svih brojeva__________");
Ispis(brojevi);

ArrayList parni = IzvuciParne(brojevi);
Console.WriteLine("__________Ispis parnih brojeva__________");
Ispis(parni);

ArrayList neparni = IzvuciNeparne(brojevi);
Console.WriteLine("_________Ispis neparnih brojeva___________");
Ispis(neparni);

partial class Program
{
    static ArrayList Unos()
    {
        //Unosim brojeve dok se ne unese 0
        int i = 0;
        ArrayList brojevi = new ArrayList();
        while (true)
        {
            i++;
            Console.Write("Unesi {0}. broj: ", i);
            int broj = int.Parse(Console.ReadLine());
            if (broj == 0)
            {
                break;
            }
            brojevi.Add(broj);
        }
        return brojevi;
    }
    static void Ispis (ArrayList brojevi)
    {
        foreach (int broj in brojevi)
        {
            Console.WriteLine("{0}", broj);
        }
    }
    static ArrayList IzvuciNeparne(ArrayList brojevi)
    {
        ArrayList neparni = new ArrayList();
        foreach (int broj in brojevi)
        {
            if (broj % 2 != 0)
            {
                neparni.Add(broj);
            }
        }
        return neparni;
    }
    static ArrayList IzvuciParne(ArrayList brojevi)
    {
        ArrayList parni = new ArrayList();
        foreach(int broj in brojevi)
        {
            if (broj % 2 == 0)
            {
                parni.Add(broj);
            }
        }
        return parni;
    }
    static ArrayList IzbaciNeparne (ArrayList brojevi)
    {
        for (int i = brojevi.Count; i >= 0; i--)
        {
            if ((int)brojevi[i] % 2 != 0)
            {
                brojevi.RemoveAt(i);
            }
        }
        return brojevi;
    }

}