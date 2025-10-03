using System.Runtime.InteropServices.JavaScript;

Console.Write("unesi recenicu ili rijec: ");
string recenica = Console.ReadLine();
if (palindrom(recenica))
{
    Console.WriteLine("rijec ili recenica ke pal" );
}
else
{
    Console.WriteLine("rijec ili recenica nije pal");
}

partial class Program
{
    static bool palindrom(string recenica)
    {
        recenica = recenica.Replace('.', ' ').Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Trim().ToLower();
        string novaRec = ""; 
        foreach (char item in recenica.Reverse())
        {
            novaRec += item;
        }
        bool jePalindrom = novaRec == recenica;
        return jePalindrom;
    }
}