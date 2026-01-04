Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine();
string[] rijeci = RastaviRecenicu(recenica);
foreach (string rijec in rijeci)
{
    Console.WriteLine(rijec.ToLower());
}
Console.WriteLine("Broj riječi u rečenici je {0}.", PrebrojiRijeci(recenica));

Console.Write("Unesi riječ koju želiš pretražiti: ");
string rijecZaPretragu = Console.ReadLine();
int brojacRijeci = PronadjiRijec(recenica, rijecZaPretragu);
Console.WriteLine("Riječ {1} se pojavljuje {2} puta u rečenici {0}", recenica, rijecZaPretragu, brojacRijeci);

Console.Write("Unesi riječ koju želiš izbaciti: ");
string rijecZaIzbaciti = Console.ReadLine();
string novaRecenica = IzbaciRijec(recenica, rijecZaIzbaciti);
Console.WriteLine("Nova rečenica je: " + novaRecenica);

Console.WriteLine("Rečenica sa nasumičnim riječima: " + PresloziRecenicu(recenica));
partial class Program
{
    static string PresloziRecenicu(string recenica)
    {
        Random rnd = new Random();
        string[] rijeci = RastaviRecenicu(recenica);
        for (int i = rijeci.Length - 1; i >= 0; i--)
        {
            int j = rnd.Next(i);
            (rijeci[i], rijeci[j]) = (rijeci[j].ToLower(), rijeci[i].ToLower());

            //Alternativno:
            //string temp = rijeci[i];
            //rijeci[i] = rijeci[j];
            //rijeci[j] = temp;
        }

        return string.Join(' ', rijeci) + ".";
    }

    static string IzbaciRijec(string recenica, string rijecZaIzbaciti)
    {
        string[] rijeci = recenica.Split(' ');
        for (int i = rijeci.Length - 1; i >= 0 ; i--)
        {
            if (MakniInterpunkciju(rijeci[i]).ToLower() == rijecZaIzbaciti.ToLower())
            {
                rijeci[i] = "";
            }
        }
        string novaRecenica = string.Join(" ", rijeci);
        return novaRecenica;
    }

    static int PronadjiRijec(string recenica, string rijec)
    {
        string[] rijeci = RastaviRecenicu(recenica);
        int brojac = 0;
        foreach (string r in rijeci)
        {
            if (rijec.ToLower() == r.ToLower())
            {
                brojac++;
            }
        }
        return brojac;
    }

    static int PrebrojiRijeci(string recenica)
    {
        string[] rijeci = RastaviRecenicu(recenica);
        return rijeci.Length;
    }

    static string[] RastaviRecenicu(string recenica)
    {
        string[] rijeci = recenica.Split(' ');
        for (int i = 0; i < rijeci.Length; i++)
        {
            rijeci[i] = MakniInterpunkciju(rijeci[i]);
        }
        return rijeci;
    }

    static string MakniInterpunkciju(string rijec)
    {
        rijec = rijec.Replace('.', ' ').Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Trim();
        return rijec;
    }
}