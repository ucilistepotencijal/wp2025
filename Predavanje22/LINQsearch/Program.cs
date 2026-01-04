using LINQsearch;

List<Brod> brodovi = new List<Brod>();
brodovi.Add(new Brod { Naziv = "Jadranka", Model = "A1000", Lokacija = "Dubrovnik", Kapacitet = 5, KS =20});
brodovi.Add(new Brod { Naziv = "Dragica", Model = "A2000", Lokacija = "Rijeka", Kapacitet = 15, KS = 40 });
brodovi.Add(new Brod { Naziv = "Perica", Model = "A3000", Lokacija = "Zadar", Kapacitet = 25, KS = 60 });
brodovi.Add(new Brod { Naziv = "Anica", Model = "A4000", Lokacija = "Rijeka", Kapacitet = 35, KS = 80 });

Console.Write("Unesi lokaciju broda: ");
string lokacija = Console.ReadLine();   
Console.Write("Unesi minimalni kapacitet: ");
int kapacitet = int.Parse(Console.ReadLine());
Console.Write("Unesi minimalnu snagu u KS: ");
double ks = double.Parse(Console.ReadLine());

List<Brod> pronadjeniBrodovi = PretraziBrodove(lokacija, kapacitet, ks, brodovi);
foreach (Brod brod in pronadjeniBrodovi)
{
    Console.WriteLine("Naziv: {0}, Model: {1} ", brod.Naziv, brod.Model);
}

partial class Program
{
    public static List<Brod> PretraziBrodove(string lokacija, int kapacitet, double ks, List<Brod> brodoviZaPretragu)
    {
        List<Brod> filtriraniBrodovi = (from b in brodoviZaPretragu
                                        where b.Lokacija == lokacija && b.Kapacitet >= kapacitet && b.KS >= ks
                                        select b).ToList();
        return filtriraniBrodovi;
    }
}

