using Rodjendan;

Console.Write("Unesi ime: ");
string ime = Console.ReadLine();
Console.Write("Unesi prezime: ");
string prezime = Console.ReadLine();
Osoba o = new Osoba(ime, prezime);

o.Rodjendan += new Osoba.RodjendanDelegat(o_Rodjendan);
Console.Write("Unesi datum rođenja: ");
o.DatumRodjenja = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Tvoja starost je {0} godine.", o.Starost);

o.Rodjendan -= new Osoba.RodjendanDelegat(o_Rodjendan);
Console.Write("Unesi datum rođenja: ");
o.DatumRodjenja = DateTime.Parse(Console.ReadLine());


partial class Program
{
    static void o_Rodjendan(object sender, EventArgs e)
    {
        Console.WriteLine("Unesen je datum rođenja {0}", ((Osoba)sender).DatumRodjenja
            .ToShortDateString());
    } 
}
