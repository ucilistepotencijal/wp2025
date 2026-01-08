
using WebShopApp;
using WebShopDAL;

Proizvodi inicijalniProizvodi = Init.PopuniWebShop();
Proizvodi kosarica = new Proizvodi();
Console.WriteLine("-------------------- Popis proizvoda --------------------");
int brojac = 1;
foreach (Proizvod item in inicijalniProizvodi)
{
    Console.WriteLine(brojac + ". " + item.Naziv + ": " + Math.Round(item.UkupnaCijena, 2) + " EUR, dostupan: " + (item.Dostupan ? "DA" : "NE"));
    brojac++;
}
Console.WriteLine("---------------------------------------------------------");

string upit = "da";
while (upit.ToLower() != "ne")
{
    try
    {
        Console.Write("Odaberite redni broj da biste ubacili proizvod u košaricu: ");
        int redniBroj = int.Parse(Console.ReadLine());
        if (((Proizvod)inicijalniProizvodi[redniBroj - 1]).Dostupan)
        {
            kosarica.Add(((Proizvod)inicijalniProizvodi[redniBroj - 1]));
            Console.WriteLine("Proizvod {0} je dodan u košaricu!", ((Proizvod)inicijalniProizvodi[redniBroj - 1]).Naziv);
        }
        else
        {
            throw new Exception("Proizvod nije dostupan!");
        }
        Console.Write("Želite li kupiti još proizvoda? (da/ne) ");
        upit = Console.ReadLine();
    }
    catch (Exception e)
    {
        Console.WriteLine("Greška! Detalji: " + e.Message);
    }
}

Narudzba gotovaNarudzba = new Narudzba();
gotovaNarudzba.NarudzbaKreirana += new Narudzba.NarudzbaKreiranaDelegat(KreirajNarudzbu);
gotovaNarudzba.DatumKreiranja = DateTime.Now;
gotovaNarudzba.Proizvodi = new Proizvodi();
foreach (Proizvod item in kosarica)
{
    gotovaNarudzba.UkupnaCijena += item.UkupnaCijena;
    gotovaNarudzba.Proizvodi.Add(item);
}

//Upis u datoteku
Datoteka.KreirajDatoteku(gotovaNarudzba, "narudzba" + gotovaNarudzba.DatumKreiranja.ToString("yyyyMMddHHmmss") + ".txt");

//Ispis iz datoteke
Console.WriteLine(Datoteka.ProcitajDatoteku("narudzba" + gotovaNarudzba.DatumKreiranja.ToString("yyyyMMddHHmmss") + ".txt"));
partial class Program
{
    public static void KreirajNarudzbu(object sender, EventArgs e)
    {
        Narudzba narudzba = (Narudzba)sender;
        Console.WriteLine("Narudžba je kreirana u {0}, {1}",
            narudzba.DatumKreiranja.ToString("dddd"), narudzba.DatumKreiranja);
    }
}
