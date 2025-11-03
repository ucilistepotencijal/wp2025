using zadatak_3;
using System;

Console.Write("unesi ime: ");
string ime = Console.ReadLine();

Console.Write("unesi prezime: ");
string prezime = Console.ReadLine();

Ucenik u = new Ucenik(ime, prezime);

Console.Write("unesi datum rođenja: ");
u.DatumRodjenja = DateTime.Parse(Console.ReadLine());

u.NaPromjenuDatumaRodjenja += new Ucenik.PromjenaDatumaDelegat(Ucenik_PromjenaDatuma);

Console.Write("unesi prosjek (1–5): ");
u.Prosjek = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("starost učenika: {0} godina", u.Starost());
Console.WriteLine("prosjek riječima: {0}", u.ProsjekRijecima());

string datoteka = @"D:\proba.txt";

string tekst = string.Format(
    "{0} {1}, rođen {2}, starost {3} godina, prosjek {4} ({5})",
    u.Ime,
    u.Prezime,
    u.DatumRodjenja.ToShortDateString(),
    u.Starost(),
    u.Prosjek,
    u.ProsjekRijecima()
);

File.WriteAllText(datoteka, tekst);


Console.Write("unesi novi datum rođenja: ");
u.DatumRodjenja = DateTime.Parse(Console.ReadLine());

partial class Program
{
    static void Ucenik_PromjenaDatuma(object sender, EventArgs e)
    {
        Ucenik u = (Ucenik)sender;
        Console.WriteLine("promienjen datum rođenja ({0})", u.DatumRodjenja.ToShortDateString());
        Console.WriteLine("starost učenika sada je: {0} godina", u.Starost());
    }
}
