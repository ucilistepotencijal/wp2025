
    Console.Write("unesite tekst: ");
    string tekst = Console.ReadLine();

    char[] znakovi = tekst.ToCharArray();
    Array.Reverse(znakovi);
    string obrnuto = new string(znakovi);

    Console.WriteLine("naopaki tekst: " + obrnuto);

    