/* Glavni program:
1) Omogućiti unos učenika i osigurati ga od grešaka 
a. Ime
b. Prezime
c. DatumRodjenja
d. Prosjek
2) Implementirati događaj NaPromjenuDatumaRodjenja
3) Ispisati unesenog učenika u konzolu i u datoteku ucenik.txt. */

using Zadatak03;

List<Ucenik> ucenici = new List<Ucenik>();
Ucenik ucenik = new Ucenik();

while (true)
{
    Console.Write("Unesi ime: ");
    string ime = Console.ReadLine();

    if (!string.IsNullOrEmpty(ime))
    {
        ucenik.Ime = ime;
        break;
    }
    else
    {
        Console.WriteLine("Unos nije dobar, unesi ime: ");
    }
}

while (true)
{
    Console.Write("Unesi prezime: ");
    string prezime = Console.ReadLine();

    if (!string.IsNullOrEmpty(prezime))
    {
        ucenik.Prezime = prezime;
        break;
    }
    else
    {
        Console.WriteLine("Unos nije dobar, unesi prezime: ");
    }
}

while (true)
{
    Console.Write("Unesi datum rodjenja (dd/mm/gggg): ");
    string unos = Console.ReadLine();

    try
    {
        ucenik.DatumRodjenja = DateTime.Parse(unos);
        break;
    }
    catch
    {
        Console.WriteLine("Neispravan unos!");
    }
}

while (true)
{
    Console.Write("Unesi prosjek: ");
    string unos = Console.ReadLine();

    try
    {
        double prosjek = double.Parse(unos);
        if (prosjek >= 1 && prosjek <= 5)
        {
            ucenik.Prosjek = prosjek;
            break;
        }
    }
    catch
    {
        Console.WriteLine("Neispravan unos!");
    }
}

ucenici.Add(ucenik);

Console.WriteLine("Uspješan unos!");
Console.WriteLine("Ime: " + ucenik.Ime);
Console.WriteLine("Prezime: " + ucenik.Prezime);
Console.WriteLine("Datum rodjenja: " + ucenik.DatumRodjenja.ToShortDateString());
Console.WriteLine("Prosjek: " + ucenik.Prosjek);

File.AppendAllText("ucenik.txt", "Ime: " + ucenik.Ime + "\nPrezime: " + ucenik.Prezime +
    "\nDatum rodjenja: " + ucenik.DatumRodjenja.ToShortDateString() + "\nProsjek: " + ucenik.Prosjek);






