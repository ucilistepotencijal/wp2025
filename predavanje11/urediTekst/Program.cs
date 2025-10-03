
Console.Write("unesi recenucu: ");
string recenica = Console.ReadLine();
string[] rijeci = rastaviRec(recenica);
foreach (string rijec in rijeci)
{
    Console.WriteLine(rijec.ToLower() );
}
Console.WriteLine("broj rijeci u recenici je {0}" + prebrijiRijeci(recenica));

Console.Write("unesi rijec koju zelis pretraziti: ");
string rijecZaPretragu = Console.ReadLine();
int brojacRijeci = pronadjiRijec(recenica, rijecZaPretragu);
Console.WriteLine("rijec {1} se pojavljuje {2} puta u recenici {0}", recenica, rijecZaPretragu, brojacRijeci);

Console.Write("unesi rijec koju zelis izbaciti ");
string rijecZaIzbaciti = Console.ReadLine();
string novaRecenica = izbaciRijec(recenica,rijecZaIzbaciti);
Console.WriteLine("nova recenica je: "+ novaRecenica);

Console.WriteLine("recenica sa nasumicnim rijecima: "+ presloziRecenicu(recenica));

partial class Program
{
    static string presloziRecenicu(string recenica)
    {
        Random rnd = new Random();
        string[] rijeci = rastaviRec(recenica);
        for (int i = rijeci.Length; i > 0; i--)
        { 
            int j = rnd.Next(i);
            (rijeci[i], rijeci[j]) = (rijeci[i].ToLower() , rijeci[j].ToLower());

        }
        return string.Join(" ", rijeci);
    }
    static string izbaciRijec(string recenica, string rijeciZaIzbaciti)
    {
        string[] rijeci = recenica.Split(' ');
        for(int i = rijeci.Length -1; i>=0; i--)
        {
            if (makniInterpunkciju(rijeci[i]).ToLower() == rijeciZaIzbaciti.ToLower())
            {
                rijeci[i] = "";
            }
        }
        string novaRecenica = string.Join(" ", rijeci);
        return novaRecenica;
    }
    static int pronadjiRijec(string recenica, string rijec)
    {
        string[] rijeci = rastaviRec(recenica);
        int brojac = 0;
        foreach(string r in rijeci)
        {
            if(rijec.ToLower() == r.ToLower())
            {
                brojac++;
            }
        }
        return brojac;
    }
    static int prebrijiRijeci(string recenica)
    {
        string[] rijeci = rastaviRec(recenica);
        return rijeci.Length;
    }
    static string[] rastaviRec(string rec)
    {
        string[] rijeci = rec.Split(' ');
        for (int i = 0; i < rijeci.Length; i++)
        {
            rijeci[i] = makniInterpunkciju(rijeci[i]);
        }
        return rijeci;
    }
    static string makniInterpunkciju(string rijec)
    {
        rijec = rijec.Replace('.', ' ').Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Trim();
        return rijec;
    }

    
}