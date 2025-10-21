
using DAL_događaji2;

Osoba o = new Osoba();
o.NaPromjenuImenaDelegat += new Osoba.NaPromjenuImenaDelegat(o_NaPromjenuImena);
o.NaPozivMetodePunoImeDelegat += new Osoba.NaPozivMetodePunoImeDelegat(o_NaPozivMetodePunoIme);
o.Ime = "Ivo";
o.Prezime = "Ivić";
Console.WriteLine(o.PunoIme());

Polaznik p = new Polaznik();
p.NaPromjenuProgramaObrazovanja += new Polaznik.NaPromjenuProgramaObrazovanjaDelegat(p_NaPromjenuProgramaObrazovanja);
p.NaPozivMetodePunoImeDelegat += new Osoba.NaPozivMetodePunoImeDelegat(o_NaPozivMetodePunoIme);
p.Ime = "Pero";
p.Prezime = "Perić";
p.ProgramObrazovanja = ".NET MVC";
Console.WriteLine(p.PunoIme());

Polaznici polaznici = new Polaznici();
polaznici.Add(p);
foreach (Polaznik item in polaznici)
{
    Console.WriteLine(item.Ime);
}



partial class Program
{
    static void o_NaPromjenuImena(object sender, EventArgs e)
    {
        Console.WriteLine("promjenjeno je ime!");
        Console.WriteLine("novo ime je: {0}", ((Osoba)sender).Ime);
    }

    static void o_NaPozivMetodePunoIme(object sender, EventArgs e)
    {
        Console.WriteLine("pozvana je metoda PunoIme() objekta s imenom{0}", ((Osoba)sender).Ime);
    }
    static void p_NaPromjenuProgramaObrazovanja(object sender, EventArgs e)
    {
        Console.WriteLine("cestitamo {0}, upisali ste {1}", ((Osoba)sender).Ime);
    }

}