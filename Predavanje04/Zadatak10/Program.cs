//Korisnik traži unos sa konzole koji sprema u cjelobrojnu varijablu. Napiši program koji ispisuje
//"Broj je veći od 10" ako je, odnosno "Broj je manji ili jednak 10" ako nije veći od 10.




Console.Write("unesite broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj > 10)
{
    Console.WriteLine("Broj je veći od 10");
}
else
{
    Console.WriteLine("Broj je manji ili jednak 10");
}


Console.WriteLine("-------------------");

//Prošireni if - digresija
if (broj > 10)
{
    Console.WriteLine("Broj je veći od 10");
}
else if (broj == 10)
{
    Console.WriteLine("Broj je jednak 10");
}
else
{
    Console.WriteLine("Broj je manji od 10");
}