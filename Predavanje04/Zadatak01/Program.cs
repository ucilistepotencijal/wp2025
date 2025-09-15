//Korisnik traži unos sa konzole koji sprema u cjelobrojnu varijablu. Napiši program koji ispisuje
//"Broj je veći od 10" ako je, odnosno "Broj je manji ili jednak 10" ako nije veći od 10.
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 10)
{
    Console.WriteLine("Broj je veći 10!");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 10");
}


