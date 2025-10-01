/* Napiši program u kojem će se tražiti unos rečenice a zatim će se u izborniku moći odabrati
jedna od funkcija:
-RastaviRecenicu – vraća sve riječi unutar rečenice ispisane jednu ispod druge malim
slovima (zanemarujući interpunkcijske znakove točka i zarez)
Napomena: Koristiti Split metodu na stringu za rastavljanje rečenice na riječi, te napraviti
vlastitu metodu koja će na svakoj riječi maknuti točku ili zarez. 
- PrebrojiRijeci – vraća broj riječi u rečenici
- PronadjiRijec – pronalazi koliko se puta pojavljuje riječ u rečenici (s malim i velikim
početnim slovom)
- IzbaciRijec – izbacuje riječ iz rečenice (s malim i velikim početnim slovom)
i ispisuje ju
- PresloziRecenicu – Slaže novu rečenicu preslagujući riječi iz rečenice nasumičnim
odabirom
Napomena: koristiti Random() klasu za slučajni odabir

Korisnik treba imati mogućnost ponovnog odabira bilo koje od funkcija */

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

//dodati while i try
Console.WriteLine("Unesi rečenicu: ");
string recenica = Console.ReadLine();
Console.WriteLine("Odaberi: \nA - RastaviRecenicu \nB - PrebrojiRijeci \nC - PronadjiRijec \nD - IzbaciRijec " +
    "\nE - PresloziRecenicu");
string izbor = Console.ReadLine();
if (izbor.ToLower() == "a")
{
    RastaviRecenicu(recenica);
}
else if (izbor.ToLower() == "b")
{
    PrebrojiRijeci(recenica);
}
else if (izbor.ToLower() == "c")
{
    PronadjiRijec(recenica);
}
else if (izbor.ToLower() == "d")
{
    IzbaciRijec(recenica);
}
else if (izbor.ToLower() == "e")
{
    PresloziRecenicu(recenica);
}

partial class Program
{
    static void RastaviRecenicu(string unos)
    {
        string[] rijeci = unos.Split(" ", StringSplitOptions.None);
        Console.Write("Riječi u rečenici su:");
        foreach (string rijec in rijeci)
        {
            Console.WriteLine(rijec.ToLower());
        }
    }

    //te napraviti vlastitu metodu koja će na svakoj riječi maknuti točku ili zarez. ?

    static void PrebrojiRijeci(string unos)
    {
        List<string> list = new List<string>();
        string[] rijeci = unos.Split(" ", StringSplitOptions.None);
        foreach (string rijec in rijeci)
        {
            list.Add(rijec);
        }
        Console.WriteLine($"Broj riječi u rečenici je:{list.Count()}");
    }

    static void PronadjiRijec(string unos) // pronalazi koliko se puta pojavljuje riječ u rečenici(s malim i velikim početnim slovom)
    {
        string[] rijeci = unos.Split(' ', StringSplitOptions.None);
        for (int i = 0; i < rijeci.Length; i++)
        {
            rijeci[i] = rijeci[i].ToLower();
        }
        //List<string> = new List<string>(); dovršiti
    }

    static void IzbaciRijec(string unos) //izbacuje riječ iz rečenice(s malim i velikim početnim slovom) i ispisuje ju
    {

    }

    static void PresloziRecenicu(string unos) //Slaže novu rečenicu preslagujući riječi iz rečenice nasumičnim odabirom
    {
       
       
    }
}
