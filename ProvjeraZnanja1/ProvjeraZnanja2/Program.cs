//Zadatak 2: Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
//Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva

using System.ComponentModel.Design;

partial class Program
{
    static void Main()
    {
        List<int> brojevi = new List<int>();

        while (true)
        {
            try
            {
                Console.Write("Unesi prirodan broj(unesi 0 za kraj): ");
                int broj = int.Parse(Console.ReadLine());

                if (broj < 0)
                {
                    Console.WriteLine("Broj mora biti veći od 0! Molim ponovite unos!");
                    continue;
                }

                while (broj > 0)
                {
                    brojevi.Add(broj);
                    break;
                }
                if (broj == 0)
                {
                    Console.WriteLine($"Najveći broj od unesenih brojeva je {brojevi.Max()}");
                    Console.WriteLine($"Najmanji broj od unesenih brojeva je {brojevi.Min()}");
                }

            }
            catch (Exception e)
            {

                Console.Write("Ups..dogoodila se greška: " + e.Message + "Molim ponovite unos!");
            }
        }
    }
}