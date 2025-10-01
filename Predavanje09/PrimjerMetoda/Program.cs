using System.Collections;

ArrayList brojevi = Unos();
Console.WriteLine("----- Ispis svih brojeva");
Ispis(brojevi);

ArrayList parni = IzvuciParne(brojevi);
Console.WriteLine("----- Ispis parnih brojeva -----");
Ispis(parni);

ArrayList neparni = IzvuciNeparne(brojevi);
Console.WriteLine("----- Ispis neparnih brojeva -----");
Ispis(neparni);

ArrayList bezNeparnih = IzbaciNeparne(brojevi);
Console.WriteLine("------ Izbaci neparne brojeve ------");
Ispis(brojevi);
partial class Program
{
    static ArrayList Unos()
    {
        //unosim brojeve dok se ne unese 0

        int i = 0;
        ArrayList brojevi = new ArrayList();

        while (true)
        {
            i++;
            Console.WriteLine("Unesi {0}. broj", i);
            int broj = int.Parse(Console.ReadLine());

            if (broj == 0)
            {
                break;
            }
            brojevi.Add(broj);
        }
        return brojevi;
    }

    static void Ispis(ArrayList brojevi)
    {
        foreach (int broj in brojevi)
        {
            Console.WriteLine("{0}", broj);
        }
    }

    static ArrayList IzvuciNeparne(ArrayList brojevi)
    {
        ArrayList neparni = new ArrayList();
        foreach (int item in brojevi)
        {
            if (item % 2 != 0)
            {
                neparni.Add(item);
            }
        }
        return neparni;
    }

    static ArrayList IzvuciParne(ArrayList brojevi)
    {
        ArrayList parni = new ArrayList();
        foreach (int item in brojevi)
        {
            if (item % 2 == 0)
            {
                parni.Add(item);
            }
        }
        return parni;
    }

    static ArrayList IzbaciNeparne(ArrayList brojevi)
    {
        for (int i = brojevi.Count - 1; i >= 0; i--)
        {
            if ((int)brojevi[i] % 2 != 0)
            {
                brojevi.RemoveAt(i);
            }
        }
        return brojevi;
    }
}