

/* 6. Napiši program u kojem se traži unos prirodnog broja, a zatim se ispisuje rastav broja na
proste faktore.
Napomena: Broj dijeliti prostim faktorom dok rezultat dijeljenja ne bude različit od 0.
Primjer: 20 = 2 * 2 * 5 */


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
        if (broj == 1)//dodala jer mi je ispisivalo samo "1= "
        {
            Console.WriteLine("1 = 1");
            continue;
        }
        if (broj < 0)
        {
            Console.WriteLine("\nUnesi prirodni broj: \n");
            continue;
        }

        int broj2 = broj; //dodajem kopiju originalno unesenog broja da ga ne mijenjam prilikom faktorizacije
        List<int> faktori = new List<int>();

        for (int i = 2; i <= broj2; i++) //"i" ide od 2 do unesenog broja. Kad više be možemo podijeliti "i" s broj2, petlja ide dalje(i++).
        {
            while (broj2 % i == 0) //provjeravam je li "i" faktor unesenog broja. Npr 12/2 = 6, 6/2 = 3, 3/2 != 0 -> što znači "Dok je "i" faktor broja, dodaj ga u listu i podijeli broj s "i"."
            {
                broj2 = broj2 / i; //dijeli broj2 s "i". Petlja se ponavlja dok se više ne može dijeliti broj2 s "i".
                faktori.Add(i); //dodajem brojeve u listu
            }
        }

        Console.Write(broj + " = ");
        for (int i = 0; i < faktori.Count; i++)
        {
            Console.Write(faktori[i]);
            if (i != faktori.Count - 1) //ako nije zadnji faktor -> ispiši *
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();

    }
    catch (Exception e)
    {
        Console.WriteLine("Ups... Dogodila se greška: " + e.Message);
    }
}
//napomena: u for petlji stavljamo i <= broj2 jer da sam stavila i < broj2, broj2 koji je preostali zadnji broj se ne bi ispisao.
