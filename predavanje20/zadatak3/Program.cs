using System.Globalization;
using Zadatak3;

List<Pas> psi = new List<Pas>();
List<Macka> macke = new List<Macka>();
string unos = "da";

while (unos.ToLower() == "da")
{
    string odabir = "";
    while (odabir != "1" && odabir != "2")
    {
        Console.Write("Odaberi unos životinje: 1 - pas, 2- mačka: ");
        odabir = Console.ReadLine();
    }
    switch (odabir)
    {
        case "1":
            try
            {
                Pas p = new Pas();
                Console.Write("Unesi ime vlasnika: ");
                p.Vlasnik = Console.ReadLine();
                Console.Write("Unesi godinu rođenja (bez točke): ");
                p.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
                Console.Write("Unesi masu u kg: ");
                p.Masa = int.Parse(Console.ReadLine());
                Console.Write("Unesi spol (0 - muški, 1 - ženski): ");
                p.Spol = (Spol)int.Parse(Console.ReadLine());
                p.Budjenje += new Pas.BudjenjeDelegat(p_Budjenje);
                Console.Write("Unesi vrijeme buđenja (u satima): ");
                p.VrijemeBudjenja = int.Parse(Console.ReadLine());
                p.NaSpavanje += new Pas.NaSpavanjeDelegat(z_NaSpavanje);
                Console.Write("Unesi vrijeme spavanja (u satima): ");
                p.VrijemeSpavanja = int.Parse(Console.ReadLine());
                Console.Write("Unesi ime psa: ");
                p.Ime = Console.ReadLine();
                Console.Write("Unesi pasminu: ");
                p.Pasmina = Console.ReadLine();
                psi.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se greška: {0}. Ponovite unos!", e.Message);
            }
            break;
        case "2":
            try
            {
                Macka m = new Macka();
                Console.Write("Unesi ime vlasnika: ");
                m.Vlasnik = Console.ReadLine();
                Console.Write("Unesi godinu rođenja (bez točke): ");
                m.GodinaRodjenja = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
                Console.Write("Unesi masu u kg: ");
                m.Masa = int.Parse(Console.ReadLine());
                Console.Write("Unesi spol (0 - muški, 1 - ženski): ");
                m.Spol = (Spol)int.Parse(Console.ReadLine());
                m.Budjenje += new Macka.BudjenjeDelegat(m_Budjenje);
                Console.Write("Unesi vrijeme buđenja (u satima): ");
                m.VrijemeBudjenja = int.Parse(Console.ReadLine());
                m.NaSpavanje += new Macka.NaSpavanjeDelegat(z_NaSpavanje);
                Console.Write("Unesi vrijeme spavanja (u satima): ");
                m.VrijemeSpavanja = int.Parse(Console.ReadLine());
                Console.Write("Unesi boju mačke: ");
                m.Boja = Console.ReadLine();               
                macke.Add(m);
            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se greška: {0}. Ponovite unos!", e.Message);
            }
            break;
        default:
            break;
    }
    Console.Write("Želiš li unijeti još životinja (da / ne): ");
    unos = Console.ReadLine();
}

List<Zivotinja> zivotinje = new List<Zivotinja>();
zivotinje.AddRange(psi);
zivotinje.AddRange(macke);
foreach (Zivotinja z in zivotinje)
{
    Console.WriteLine($"{z.ToString()}, {z.Starost} g., {z.Spol}, {z.GlasajSe()}");
}

partial class Program
{
    static void p_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Pas)sender).GlasajSe());
    }

    static void m_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine(((Macka)sender).GlasajSe());
    }

    static void z_NaSpavanje(object sender, EventArgs e)
    {
        // Ako je prošlo vrijeme spavanja, poziva se metoda Spavaj (Zzzz....)
        // u suprotnom se poziva metoda GlasajSe()
        Zivotinja z = (Zivotinja)sender;
        if (DateTime.Now.Hour > z.VrijemeSpavanja)
        {
            Console.WriteLine(z.Spavaj());
        }
        else
        {
            Console.WriteLine(z.GlasajSe());
        }
    }
}