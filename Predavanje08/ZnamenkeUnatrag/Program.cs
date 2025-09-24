/* 5. Napiši program u kojem se traži unos prirodnog broja, a zatim se znamenke upisanog broja
ispisuju unatrag.
Napomena: Svaku znamenku upisanog broja spremiti kao poseban element kolekcije. */

//Korisnik unosi broj i radim provjeru
while (true)
{
    try
    {
        Console.Write("Unesi prirodni broj: ");
        string unos = Console.ReadLine();
        int broj = int.Parse(unos);

        if (broj == 0)
        {
            break;
        }
        if (broj < 0)
        {
            Console.WriteLine("Unesite prirodni broj!");
            continue;
        }

        //kreiram novu listu
        List<int> brojevi = new List<int>();

        //dodajem znamenke u listu
        foreach (char c in unos)
        {
            brojevi.Add(int.Parse(c.ToString()));
        }

        //okrećem redoslijed znamenki
        brojevi.Reverse();

        //ispis znamenki 
        Console.WriteLine("\nIspis unesenog broja unatrag: ");
        foreach (int b in brojevi)
        {
            Console.Write(b);
        }
        Console.WriteLine("\n");
    }
    catch (Exception e) //stavljam exception na kraj jer mi nije radio na početku koda
    {
        Console.WriteLine("Ups... Dogodila se greška: " + e.Message);
    }
}
