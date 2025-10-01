using System.Collections;
Console.Write("Unesi rečenicu: ");
string recenica = Console.ReadLine();
string[] rijeci = RastaviRecenicu(recenica);
foreach (string rijec in rijeci)
{
    Console.WriteLine(rijec.ToLower());
}

partial class Program
{
    static string[] RastaviRecenicu(string recenica)
    {
        string[] rijeci = recenica.Split(" ");
        for (int i = 0; i < rijeci.Length; i++)
        {
            rijeci[i] = MakniInterpunkciju(rijeci[i]);
        }
        return rijeci;

        static string MakniInterpunkciju(string rijec)
        {
            rijec = rijec.Replace('.', ' ').Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Trim();
            return rijec;
        }
    }
}
