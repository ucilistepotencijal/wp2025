Console.WriteLine("Pritisni bilo koju tipku za početak... ");
Console.ReadKey();
Console.WriteLine();

DateTime pocetak = DateTime.Now;

Console.Write("Pritisni bilo koju tipku za kraj... ");
Console.ReadKey();
Console.WriteLine();

DateTime zavsetak = DateTime.Now;

TimeSpan ukupnoVrijeme = zavsetak - pocetak;

Console.Write("Proteklo vrijeme je {0}", ukupnoVrijeme);
