

using Zadatak1002;

class Program



Console.WriteLine("Podaci o učeniku:");
Console.WriteLine(ucenik);



using System;

public class Ucenik
{
    public string Ime { get; set; }
    public string Prezime { get; set; }

    private DateTime _datumRodjenja;
    public DateTime DatumRodjenja
    {
        get => _datumRodjenja;
        set
        {
            if (_datumRodjenja != value)
            {
                _datumRodjenja = value;
                NaPromjenuDatumaRodjenja?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public double Prosjek { get; set; }

    public event EventHandler NaPromjenuDatumaRodjenja;

    public int Starost()
    {
        var today = DateTime.Today;
        int age = today.Year - DatumRodjenja.Year;
        if (DatumRodjenja.Date > today.AddYears(-age)) age--;
        return age;
    }

    public string ProsjekRijecima()
    {
        if (Prosjek < 1.5) return "nedovoljan";
        if (Prosjek < 2.5) return "dovoljan";
        if (Prosjek < 3.5) return "dobar";
        if (Prosjek < 4.5) return "vrlo dobar";
        return "odličan";
    }

    public override string ToString()
    {
        return $"Ime: {Ime}\nPrezime: {Prezime}\nDatum rođenja: {DatumRodjenja:dd.MM.yyyy}\nStarost: {Starost()} godina\nProsjek: {Prosjek} ({ProsjekRijecima()})";
    }
}
