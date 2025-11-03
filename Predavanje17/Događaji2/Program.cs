
using DAL_Dogadjaji2;

Osoba o = new Osoba();
o.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(o_NaPromjenuImena);
o.NaPozivMetodePunoIme += new Osoba.NaPozivMetodePunoImeDelegat(o_NaPozivMetodePunoIme);
o.Ime = "Ivo";
o.Prezime = "Ivić";
Console.WriteLine(o.PunoIme());

Polaznik p = new Polaznik();
p.NaPromjenuProgramaObrazovanja += new Polaznik.NaPromjenuProgramaObrazovanjaDelegat(p_NaPromjenuProgramaObrazovanja);
p.NaPozivMetodePunoIme += new Osoba.NaPozivMetodePunoImeDelegat(o_NaPozivMetodePunoIme);
p.Ime = "Pero";
p.Prezime = "Perić";
p.ProgramOBrazovanja = ".NET MVC";
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
        Console.WriteLine("Promijenjeno je ime!");
        Console.WriteLine("Novo ime je: {0}", ((Osoba)sender).Ime);
    }

    static void o_NaPozivMetodePunoIme(object sender, EventArgs e)
    {
        Console.WriteLine("Pozvana je metoda PunoIme() objekta s imenom {0}", ((Osoba)sender).Ime); //
    }

    static void p_NaPromjenuProgramaObrazovanja(object sender, EventArgs e)
    {
        Polaznik polaznik = (Polaznik)sender;
        Console.WriteLine("Čestitamo {0}, upisali ste {1}", polaznik.PunoIme(), polaznik.ProgramOBrazovanja);
    }

}
