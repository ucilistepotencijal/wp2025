

Console.Write("Pritisni bilo koju tipku za početaK: ");
Console.ReadKey();

DateTime pocetak = DateTime.Now;

Console.WriteLine("Pritisni bilo koju tipku za kraj: ");
Console.ReadKey();

DateTime zavsetak = DateTime.Now;

TimeSpan ukupnoVrijeme = zavsetak - pocetak;

Console.Write("Proteklo vrijeme je {0}", ukupnoVrijeme);
