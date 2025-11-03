
Console.Write("Unesi rečenicu ili riječ: ");
string recenica = Console.ReadLine();
if (Palindrom(recenica))
{
    Console.WriteLine("Riječ ili rečenica je palindrom!");
}
else
{
    Console.WriteLine("Riječ ili rečenica nije palindrom!");
}

partial class Program
{
    static bool Palindrom(string recenica)
    {
        recenica = recenica.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "").Trim().ToLower();
        string novaRecenica = "";
        foreach (char item in recenica.Reverse())
        {
            novaRecenica += item;
        }
        bool jestPalindrom = novaRecenica == recenica;
        return jestPalindrom;
    }
}
