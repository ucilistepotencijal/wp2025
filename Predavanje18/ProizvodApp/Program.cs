
using ProizvodApp;

Proizvod p = new Proizvod();
try
{
    p.NaizracunCijene += new Proizvod.NaizracunCijeneDelegat(p_NaIzracunCijene);

    Console.Write("Unesi naziv proizvoda: ");
    p.Naziv = Console.ReadLine();
    Console.Write("Unesi osnovnu cijenu proizvoda: ");
    p.OsnovnaCijena = double.Parse(Console.ReadLine());
    Console.Write("Unesi maržu: ");
    p.Marza = double.Parse(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Dogodila se greška! Detalji: {0}", e.Message);
}

Console.WriteLine("Ukupna cijena proizvoda {0} je {1}", p.Naziv, p.IzracunajCijenu());

partial class Program
{
    static void p_NaIzracunCijene(object sender, EventArgs e)
    {
        Proizvod p = (Proizvod)sender;
        Console.WriteLine("Izračunata je ukupna cijena: " + p.OsnovnaCijena + p.OsnovnaCijena * p.Marza);
    }
}
