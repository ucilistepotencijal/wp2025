// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList brojevi = unos();
Console.WriteLine("ispis svih brojeva");
ispis(brojevi);

ArrayList parni = izp(brojevi);
Console.WriteLine("ispis parnih");
ispis(parni);

ArrayList neparni = iznep(brojevi);
Console.WriteLine("ispis neparnih");
ispis(neparni);

ArrayList bezneparni = izbacinep(brojevi);
Console.WriteLine("ispis bez neparnih");
ispis(bezneparni);
partial class Program
{
    static ArrayList unos()
    {
        int i = 0;
        ArrayList brojevi = new ArrayList();

        while (true)
        {
            i++;
            Console.WriteLine("unesi {0}. broj", i);
            int broj = int.Parse(Console.ReadLine());
            if (broj == 0)
            {
                break;
            }
            brojevi.Add(broj);
        }
        return brojevi;
    }

    static void ispis(ArrayList brojevi)
    {
        foreach (int broj in brojevi)
        {
            Console.WriteLine("{0}", broj);
        }
    }
    static ArrayList izp(ArrayList brojevi)
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

    static ArrayList iznep(ArrayList brojevi)
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
    static ArrayList izbacinep(ArrayList brojevi)
    {
        for (int i = 0; i< brojevi.Count; i++)
        {
            if ((int)brojevi[i] % 2 != 0)
            {
                brojevi.RemoveAt(i);
            }

        }
        return brojevi;

    }
}