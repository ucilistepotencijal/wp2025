
try
{
    Console.Write("upiši naziv mjeseca: ");
    string mjesec = Console.ReadLine().Trim().ToLower();

    string[] mjeseci = { "siječanj", "veljača", "ožujak", "travanj", "svibanj", "lipanj",
                                 "srpanj", "kolovoz", "rujan", "listopad", "studeni", "prosinac" };

    int i = Array.IndexOf(mjeseci, mjesec);

    if (i >= 0)
        Console.WriteLine("redni broj mjeseca {0} je {1}.",mjesec, i*1);
    else
        throw new Exception ("taj mjesec ne postoji.");
}
catch (Exception ex)
{
    Console.WriteLine("greška: " + ex.Message);
}
