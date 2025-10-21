
using rodjendan;

Console.Write("unesi ime: ");
string ime = Console.ReadLine();
Console.Write("unesi prezime: ");
string prezime = Console.ReadLine();
Osoba o = new Osoba(ime, prezime);

o.Rodjendan += new Osoba.RodjendanDelegat(o_Rodjendan);
Console.Write("unesi datum rodjenja: ");
o.DatumRodjenja = DateTime.Parse(Console.ReadLine());
Console.WriteLine("tvoja starost je {0} godina",o.Starost);

partial class Program
{
    static void o_Rodjendan(object sender, EventArgs e)
    {
        Console.WriteLine("unesen ja datum rodjenja {0}", ((Osoba)sender).DatumRodjenja.ToShortDateString());
    }
}
