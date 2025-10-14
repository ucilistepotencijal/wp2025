//Događaji su posebne metode koje se izvršavaju kad dođe do promjenje u programu
//Mi ćemo napraviti dgađaj koji će se pokrenuti kad se nešto dogodi (Upalit će se neka metoda). Mi to možemo napraviti i zasebno ali sad gledamo princip kako događaj funkcionira

using Dogadjaji;

Osoba o = new Osoba();
//3. Vezanje implementacije događaja u glavnom programu
o.NaPromjenuimena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
o.Ime = "Pero";
Console.WriteLine();
partial class Program //jer radimo statičku metodu van main metode?
{
    static void osoba_NaPromjenuImena(object sender, EventArgs e)
    {
        Console.WriteLine("Osoba je promijenila ime: {0}", ((Osoba)sender).Ime); //sender moramo castati u osobu
    }
}