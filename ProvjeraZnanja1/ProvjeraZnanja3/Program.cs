//Zadatak 3: Napravi program koji traži unos 10 brojeva. Program ispisuje koliko je
//uneseno brojeva djeljivih sa 3 i koliki je njihov umnožak.

List<int> spremnik = new List<int>();
int brojac = 0;
int mnozenje = 1;

while (true)
{
    try
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Unesi broj: ");
            int uneseniBroj = int.Parse(Console.ReadLine());
            spremnik.Add(uneseniBroj);
        }

        for (int i = 0; i < 10; i++)
        {
            if (spremnik[i] % 3 == 0)
            {
                brojac++;
                mnozenje *= spremnik[i];
            }
        }

        if(brojac == 1)
        {
            int brojDijeljivS3 = 0;
            for (int i = 0; i < spremnik.Count; i++)
            {
                if(spremnik[i] % 3 == 0)
                {
                    brojDijeljivS3 = spremnik[i];
                    break;
                }
            }
            Console.WriteLine($"Od unesenih 10 brojeva, {brojac} je dijeljiv s 3, a broj dijeljiv s 3 je {brojDijeljivS3}.");
        }
        
        else if (brojac > 1) Console.WriteLine($"Od unesenih 10 brojeva, {brojac} ih je dijeljivo s 3, a umnožak tih brojeva je {mnozenje}.");
        else Console.WriteLine("Nijedan od unesenih brojeva nije dijeljiv s 3!");
    }
    catch (Exception e)
    {

        Console.Write("Ups..dogoodila se greška: " + e.Message + "Molim ponovite unos!"); //na žalost mora se ispočetka sve unijeti ako je nešto krivo ali ne znam to trenutno kako napraviti
    }
} 