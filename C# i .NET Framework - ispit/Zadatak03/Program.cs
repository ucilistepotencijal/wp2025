//Zadatak 3:

using System;
using System;
using System.IO;
using System.IO;
using System.Text;
using Zadatak03;

class Program
{
    static void Main()
    {
        Učenik u = new Učenik();

        // 2) Pretplata na događaj
        u.NaPromjenuDatumaRodjenja += () =>
        {
            Console.WriteLine($"📅 Datum rođenja promijenjen! Učenik sada ima {u.Starost()} godina.");
        };

        // 1) Omogućavanje unosa učenika uz provjeru grešaka
        try
        {
            Console.Write("Unesi ime: ");
            u.Ime = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(u.Ime))
                throw new Exception("Ime ne smije biti prazno!");

            Console.Write("Unesi prezime: ");
            u.Prezime = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(u.Prezime))
                throw new Exception("Prezime ne smije biti prazno!");

            Console.Write("Unesi datum rođenja (npr. 15.3.2008): ");
            u.DatumRodjenja = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesi prosjek (1-5): ");
            u.Prosjek = double.Parse(Console.ReadLine());
            if (u.Prosjek < 1 || u.Prosjek > 5)
                throw new Exception("Prosjek mora biti između 1 i 5!");
        }
        catch (Exception e)
        {
            Console.WriteLine("❌ Greška pri unosu: " + e.Message);
            return;
        }

        // 3) Ispis u konzolu
        Console.WriteLine("\n✅ Podaci o učeniku:");
        Console.WriteLine($"Ime i prezime: {u.Ime} {u.Prezime}");
        Console.WriteLine($"Datum rođenja: {u.DatumRodjenja.ToShortDateString()}");
        Console.WriteLine($"Starost: {u.Starost()} godina");
        Console.WriteLine($"Prosjek: {u.Prosjek} ({u.ProsjekRijecima()})");

        // 3) Ispis u datoteku ucenik.txt
        string sadrzaj =
            $"Ime i prezime: {u.Ime} {u.Prezime}\n" +
            $"Datum rođenja: {u.DatumRodjenja.ToShortDateString()}\n" +
            $"Starost: {u.Starost()} godina\n" +
            $"Prosjek: {u.Prosjek} ({u.ProsjekRijecima()})";

        File.WriteAllText("ucenik.txt", sadrzaj);
        Console.WriteLine("\n📁 Podaci su spremljeni u datoteku 'ucenik.txt'.");

        // Opcionalno: testiranje događaja
        Console.Write("\nUnesi novi datum rođenja za test događaja: ");
        u.DatumRodjenja = DateTime.Parse(Console.ReadLine());
    }
}




