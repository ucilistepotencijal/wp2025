using GDPR;

List<Student> studenti = new List<Student>();

while (true)
{
    Student s = new Student();

    //Ime
    while (true)
    {
        Console.Write("Unesi ime studenta (ili kraj za prekid unosa): ");
        s.Ime = Console.ReadLine();

        if (s.Ime.ToLower() == "kraj")
        {
            break;
        }

        if (s.Ime is string)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ime mora sadržavati samo slova. Unesi ponovno ime!");
        }
    }

    if (s.Ime.ToLower() == "kraj")
    {
        break;
    }

    //Prezime
    while (true)
    {
        Console.Write("Unesi prezime studenta: ");
        s.Prezime = Console.ReadLine();

        if (s.Prezime is string) 
        {
            break;
        }
        else
        {
            Console.WriteLine("Prezime mora sadržavati samo slova. Unesi ponovno prezime: ");
        }
    }

    //Godina rođenja
    studenti.Add(s);

    while (true)
    {
        Console.Write("Unesi godinu rođenja (bez točke): ");
        string unos = Console.ReadLine();

        if (unos.Contains('.'))
        {
            Console.WriteLine("Godina rođenja ne smije sadržavati točku. Unesi ponovno!");
            continue;
        }
        try
        {
            s.GodinaRodenja = int.Parse(unos); //Spremanje u objekt, ne ispis starosti odmah
            break;
        }
        catch (Exception e)
        {

            Console.WriteLine("Unos je pogrešan: " + e.Message + ". Molim unesite ponovno godinu!");
        }
    }

    //Mjesto rođenja
    Console.Write("Unesi mjesto rodenja: ");
    s.MjestoStudiranja = Console.ReadLine();

    //OIB
    Console.Write("Unesi OIB: ");
    s.OIB = Console.ReadLine();

    Console.WriteLine("--------------- Popis studenata -------------");

    foreach (Student x in studenti)
    {
        Console.WriteLine($"Inicijali: {x.Inicijali()}");
        if (x.GodinaRodenja > 0) //Ispisivalo mi 0 - 2025
        {
            Console.WriteLine($"Starost: {x.FormatiranjeGodina(x.Starost())}");
        }
        Console.WriteLine($"OIB je {(x.ProvjeriOIB() ? "ispravan" : "neispravan")}");
        Console.WriteLine("\n");
    }

    Console.WriteLine("-------------- Studenti iz Osijeka stariji od 24 godine --------------");

    foreach (Student x in studenti)
    {
        if (x.MjestoStudiranja.ToLower() == "osijek" && x.Starost() > 24)
        {
            Console.WriteLine($"{s.Ime} {s.Prezime}");
        }
    }
}



