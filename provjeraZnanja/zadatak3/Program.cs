
try
{
    List<int> djeljiviSa3 = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        Console.Write("unesi broj {0}: ", i+1);
        int broj = int.Parse(Console.ReadLine());
        if (broj % 3 == 0)
        djeljiviSa3.Add(broj); //nisam siguran je li tako bas tocno napisat if ali radi,
                               //ne mogu se sjetit ako smo drugacije nesto radili
    }

    Console.WriteLine("brojeva djeljivih sa 3 ima: " + djeljiviSa3.Count);

    if (djeljiviSa3.Count > 0)
    {
        long umnozak = 1;
        foreach (int b in djeljiviSa3)
            umnozak *= b;
        Console.WriteLine("umnožak tih brojeva: " + umnozak);
    }
    else
    {
        throw new Exception ("nema djeljivih s 3.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Greška: " + ex.Message);
}