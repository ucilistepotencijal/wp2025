using Dogadjaji;

Osoba o = new Osoba();
//3. vezanje implementacije događaja u glavnom programu
o.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
o.Ime = "Pero";
Console.WriteLine();

partial class Program
{
    static void osoba_NaPromjenuImena(object sender, EventArgs e)
    {
        Console.WriteLine("Osoba je promijenila ime: {0}", ((Osoba)sender).Ime);
    }
}

