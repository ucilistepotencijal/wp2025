//kreiranje novog datuma 1.1.0001.
DateTime novaGodina = new DateTime();

//kreiranje novog datuma (godina,mjesec,dan)
DateTime novaGodina2 = new DateTime(2026, 1, 1);

Console.WriteLine(novaGodina2);
Console.WriteLine(novaGodina2.ToShortDateString());
Console.WriteLine(novaGodina2.ToString("d.M.yy."));
Console.WriteLine(novaGodina2.ToString("dd.MM.yy."));
Console.WriteLine(novaGodina2.ToString("ddd dd.MM.yyyy"));
Console.WriteLine(novaGodina2.ToString("dddd.MMM.dd.MM.yyyy"));
Console.WriteLine(novaGodina2.ToString("dddd.MMMM.dd.yyyy."));

//unos sa tipkovnice
Console.Write("Unesi datum: ");
DateTime datum = new DateTime.Parse(Console.ReadLine());
Console.WriteLine(datum.ToShortDateString());

//Uspoređivanje datuma
if (datum < novaGodina2)
{
    Console.WriteLine("Datum je prije Nove godine");
}
else if (datum > novaGodina2)
{
    Console.WriteLine("Datum je poslije Nove godine");
}
else
{
    Console.WriteLine("Sretna Nova Godina");
}
Console.WriteLine("Trenutni datum je:{0}", DateTime.Today.ToShortDateString());
Console.WriteLine("Trenutni datum je:{0}", DateTime.Today); //ispis datuma i vremena - Today postavlja vrijem u ponoć
Console.WriteLine("Trenutni datum i vrijeme je:{0}", DateTime.Now.ToString("d.M.yyyy.HH:mm:ss:fff:"));

Console.WriteLine("Nova godina pada na{0}", novaGodina2.DayOfWeek);
Console.WriteLine("Nova godina pada na{0}", novaGodina2.ToString("dddd"));

Console.WriteLine("Danas je {0} dan u godini! " DateTime.Today.DayOfYear);

//Datumska aritmetika
Console.WriteLine("Novoj godini dodajem 45 dana:{0}", novaGodina2.AddDays(45).ToShortDateString());
Console.WriteLine("Novoj godini oduzimam 45 dana:{0}", novaGodina2.AddDays(-45).ToShortDateString());

//Razlika datuma TimeSpan
TimeSpan doNovegodine = novaGodina2 - DateTime.Now;
Console.WriteLine("Do Nove godine ima {0} dana!",doNovegodine.Days);
Console.WriteLine("Do Nove godine ima {0} dana!",doNovegodine.TotalDays);
Console.WriteLine("Do Nove godine ima {0} dana!",doNovegodine.Hours);
Console.WriteLine("Do Nove godine ima {0} dana!",doNovegodine.TotalHours);

//Provjera prijestupne godine
if(DateTime.IsLeapYear(2026))
{
   
}
