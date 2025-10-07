
using System.Threading.Channels;
using klaseObjekti;

osoba osoba = new osoba();
osoba.ime = "Pero";
osoba.prezime = "Peric";

string punoIme = osoba.vratiPunoIme();
Console.WriteLine();

Console.WriteLine("puno ime osobe je " +  punoIme);

osoba osoba2 = new osoba();
Console.WriteLine("unesi ime:  ");
osoba2.ime = Console.ReadLine();

Console.Write("unesi prrezime:  ");
osoba2.prezime = Console.ReadLine();

Console.WriteLine("puno ime je {0}", osoba2.vratiPunoIme());

osoba osoba3 = new osoba
{
    ime = "josip",
    prezime = "josipovic"
};

Console.WriteLine(osoba3.vratiPunoIme());
