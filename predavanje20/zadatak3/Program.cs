
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using zadatak3;

List<pas> psi = new List<pas>();
List<macka> macke = new List<macka>();
string unos = "da";

while (unos.ToLower() == "da")
{
    string odabir = "";
    while(odabir != "1" && odabir != "2")
    {
        Console.WriteLine("ode+aberi unos zivotinje: 1- pas, 2- macka: ");
        odabir = Console.ReadLine();
    }
    switch (odabir)
    {
        case "1":
            try
            {
                pas p = new pas();
                Console.Write("unesi ime vlasnika: ");
                p.Vlasnik = Console.ReadLine();
                Console.Write("unesi godinu rodjenja (bez tocke): ");
                p.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
                Console.Write("unesi masu u kg");
                p.Masa = int.Parse(Console.ReadLine());
                Console.WriteLine("unesi spol (o- muz+ski 1- zenski )");
                p.Spol = (Spol)int.Parse(Console.ReadLine());
                p.Budjenje += new pas.BudjenjeDelegat(p_Budjenje);
                Console.Write("unesi vrijeme bidjenja (u satima): ");
                p.VrijemeBudjenja = int.Parse(Console.ReadLine());
                p.NaSpavanje += new pas.NaSpavanjeDelegat(z_NaSpavanje);
                Console.Write("unesi vrijeme spavanja (u satima): ");
                p.VrijemeSpavanja = int.Parse(Console.ReadLine());
                Console.WriteLine("unesi ime psa: ");
                p.Ime = Console.ReadLine();
                Console.Write("unesi psaminu: ");
                p.Pasmina = Console.ReadLine();
                psi.Add(p);

            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se greška: {0}. Ponovite unos!", e.Message);
            }
            break;
        case "2":
            break;
        default:
            break;
    }
    Console.Write("zelis li unijeti jos zivotinja ");
    unos = Console.ReadLine();
}

partial class Program
{
    static void p_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((pas)sender).glasajSe());
    }
    static void m_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((macka)sender).glasajSe());
    }
    static void z_NaSpavanje(object sender, EventArgs e)
    {
        zivotinje z = (zivotinje)sender;
        if (DateTime.Now.Hour > z.VrijemeSpavanja)
        {
            Console.WriteLine(z.Spavaj);

        }
        else
        {
            Console.WriteLine(z.GlasajSe);
        }
    }
}