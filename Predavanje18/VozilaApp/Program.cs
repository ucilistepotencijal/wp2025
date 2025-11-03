

using System.Collections;
using VozilaApp;

string zelimJos = "da";
ArrayList vozila = new ArrayList();
Automobili auti = new Automobili();

while (zelimJos == "da")
{
    //odabrati tip vozila
    Console.Write("Za unos automobila upiši 1, a za unos broda upiši 2: ");
    string odabir = Console.ReadLine();
    Console.WriteLine("----------------------------------------------------");
    if (odabir == "1")
    {
        try
        {
            Automobil auto = new Automobil();
            Console.Write("Unesi naziv automobila: ");
            auto.Naziv = Console.ReadLine();
            Console.Write("Unesi boju automobila: ");
            auto.Boja = Console.ReadLine();
            Console.Write("Unesi KS automobila: ");
            auto.KS = int.Parse(Console.ReadLine());
            Console.Write("Unesi ccm automobila: ");
            auto.Ccm = double.Parse(Console.ReadLine());
            auti.Add(auto);
        }
        catch (Exception e)
        {
            Console.WriteLine("Dogodila se greška! Detalji: " + e.Message);
        }
    }
    else if (odabir == "2")
    {
        try
        {
            Brod brod = new Brod();
            brod.NaPromjenuIstisnine += new Brod.NaPromjenuIstisnineDelegat(b_NaPromjenuIstisnine);
            Console.Write("Unesi naziv broda: ");
            brod.Naziv = Console.ReadLine();
            Console.Write("Unesi KS broda: ");
            brod.KS = int.Parse(Console.ReadLine());
            Console.Write("Unesi istisninu: ");
            brod.Istisnina = double.Parse(Console.ReadLine());
            vozila.Add(brod);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dogodila se greška! Detalji: " + ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Pogrešan odabir. Upiši 1 ili 2!");
    }
    Console.Write("Želiš li unijeti još vozila (da/ne)? ");
    zelimJos = Console.ReadLine();
}
vozila.AddRange(auti);
//Ispis vozila
Console.WriteLine("-------------------------- Sva vozila ------------------------");
foreach (object item in vozila)
{
    Vozilo v = (Vozilo)item;
    Console.WriteLine("Naziv: {0}, Boja: {1}, KS: {2}, KW: {3}", v.Naziv, v.Boja, v.KS, v.KSuKW());
}
Console.WriteLine("-------------------------- Svi automobili ------------------------");
foreach (object item in auti)
{
    Automobil a = (Automobil)item;
    Console.WriteLine(a.ToString());
}

partial class Program
{
    static void b_NaPromjenuIstisnine(object sender, EventArgs e)
    {
        Console.WriteLine("Promijenila se istinsina! Nova istisnina je: " + ((Brod)sender).Istisnina);
    }
}

