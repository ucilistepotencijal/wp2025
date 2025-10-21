
using Događaji;

Osoba o = new Osoba();

o.Ime = "pero";
o.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
Console.WriteLine();

partial class Program
{
    static void osoba_NaPromjenuImena(object sender, EventArgs e)
    {
        Console.WriteLine("osoba je promjenila ime: {0}", ((Osoba)sender).Ime);
    }
}