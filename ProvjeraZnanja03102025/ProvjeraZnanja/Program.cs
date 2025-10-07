

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Rječnik: naziv mjeseca -> broj mjeseca
        Dictionary<string, int> mjeseci = new Dictionary<string, int>()
        {
            {"siječanj", 1},
            {"veljača", 2},
            {"ožujak", 3},
            {"travanj", 4},
            {"svibanj", 5},
            {"lipanj", 6},
            {"srpanj", 7},
            {"kolovoz", 8},
            {"rujan", 9},
            {"listopad", 10},
            {"studeni", 11},
            {"prosinac", 12}
        };

        Console.Write("Unesite naziv mjeseca: ");
        string unos = Console.ReadLine();

        // Pretvori u mala slova i ukloni razmake s početka i kraja
        string kljuc = unos.Trim().ToLower();

        if (mjeseci.ContainsKey(kljuc))
        {
            Console.WriteLine($"Redni broj mjeseca '{unos}' je {mjeseci[kljuc]}.");
        }
        else
        {
            Console.WriteLine("Taj mjesec ne postoji.");
        }
    }
}
