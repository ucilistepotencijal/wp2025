/* Napiši program koji provjerava jeli unesena rijec ili recenica palindrom
Napomena: Treba zanemariti razmake, interpunkcijske znakove i velika i mala slova */

Console.Write("Unesi rečenicu ili riječ: ");
string recenica = Console.ReadLine();
if (Palindrom(recenica))
{
    Console.WriteLine("Riječ ili rečenica je palindrom!");
}
else
{
    Console.WriteLine("RIječ ili rečenica nije palindrom!");
}
partial class Program
{
    static bool Palindrom(string recenica)
    {
        recenica = recenica.Replace(" ", "").Replace(',', ' ').Replace('!', ' ').Replace('?', ' ').Trim().ToLower();
        string novaRecenica = "";
        foreach (char item in recenica.Reverse())
        {
            novaRecenica += item;
        }
        bool jestPalindrom = novaRecenica == recenica;
        return jestPalindrom;
    }
}