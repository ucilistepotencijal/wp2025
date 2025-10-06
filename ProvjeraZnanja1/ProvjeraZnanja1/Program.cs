//Zadatak 1: Napravi program koji za upisani tekstualni naziv mjeseca ispisuje njegov
//redni broj. Za krivo upisani naziv mjeseca, ispisuje se da taj mjesec ne postoji.

partial class Program
{
    static void Main()
    {
        Console.Write("Upiši naziv mjeseca: ");
        string mjesec = Console.ReadLine().ToLower();

        while (true)
        {
            try
            {
                if (mjesec == "sijecanj") Console.Write("1.");
                else if (mjesec == "veljaca") Console.Write("2.");
                else if (mjesec == "ozujak") Console.Write("3.");
                else if (mjesec == "travanj") Console.Write("4.");
                else if (mjesec == "svibanj") Console.Write("5.");
                else if (mjesec == "lipanj") Console.Write("6.");
                else if (mjesec == "srpanj") Console.Write("7.");
                else if (mjesec == "kolovoz") Console.Write("8.");
                else if (mjesec == "rujan") Console.Write("9.");
                else if (mjesec == "listopad") Console.Write("10.");
                else if (mjesec == "studeni") Console.Write("11.");
                else if (mjesec == "prosinac") Console.Write("12.");
                else Console.Write("Ovaj mjesec ne postoji");
                break;
            }
            catch (Exception e)
            {
                Console.Write("Ups..dogoodila se greška: " + e.Message + "Molim ponovite unos!"); //možda ni ne treba budući da mi za svaku grešku ispisuje else, ali ostavljam
            }
        }
    }
}