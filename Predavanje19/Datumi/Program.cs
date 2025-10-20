//kreiranje novog datuma 1.1.0001.
DateTime novaGodina = new DateTime();

//kreiranje novog datuma (godina, mjesec, dan)
DateTime novaGodina2 = new DateTime(2026, 1, 1);


Console.WriteLine(novaGodina2);
Console.WriteLine(novaGodina2.ToShortDateString()); //samo datum, bez vremena
Console.WriteLine(novaGodina2.ToString("dd.MM.yy")); //mjesec se piše velikim slovima jer je malim slovima riječ o minutama
Console.WriteLine(novaGodina2.ToString("ddd dd.MM.yyyy."));
Console.WriteLine(novaGodina2.ToString("dddd, MMM dd.MM.yyyy."));
Console.WriteLine(novaGodina2.ToString("dddd, MMMM dd. yyyy."));

//Unos s tipkovnice
Console.Write("Unesi datum: ");
DateTime datum = DateTime.Parse(Console.ReadLine());
Console.WriteLine(datum.ToShortDateString());

//uspoređivanje datuma
if (datum < novaGodina2)
{
    Console.WriteLine("Datum je prije nove godine.");
}
else if (datum > novaGodina2)
{
    Console.WriteLine("Datum je poslije nove godine.");
}
else
{
    Console.WriteLine("Sretna nova godina!");
}

Console.WriteLine("Trenutni datum je: {0}", DateTime.Today.ToShortDateString());
Console.WriteLine("Trenutni datum je: {0}", DateTime.Today); //ispis datuma i vremena - Today() postavlja vrijeme na ponoć
Console.WriteLine("Trenutni datum i vrijeme je: {0}", DateTime.Now.ToString("d.M.yyyy. HH:mm:ss:fff"));

Console.WriteLine("Nova godina pada na {0}", novaGodina2.DayOfWeek);
Console.WriteLine("Nova godina pada na {0}", novaGodina2.ToString("dddd"));

Console.WriteLine("Danas je {0}. dan u godini!", DateTime.Today.DayOfYear);

//Datumaska aritmetika
Console.WriteLine("Novoj godini dodajem 45 dana: {0}", novaGodina2.AddDays(45).ToShortTimeString());
Console.WriteLine("Novoj godini oduzimam 45 dana: {0}", novaGodina2.AddDays(-45).ToShortTimeString());

//Razlika datuma - TimeSpan
TimeSpan doNoveGodine = novaGodina2 - DateTime.Now;
Console.WriteLine("Do nove godine ima {0} dana!", doNoveGodine.Days);
Console.WriteLine("Do nove godine ima {0} dana!", doNoveGodine.TotalDays);
Console.WriteLine("Do nove godine ima {0} sati!", doNoveGodine.Hours);
Console.WriteLine("Do nove godine ima {0} sati!", doNoveGodine.TotalHours);

//Povjera prijestupne godine
if (DateTime.IsLeapYear(2026))
{
    Console.WriteLine("Godina 2026. je prijestupna.");
}
else
{
    Console.WriteLine("Godina 2026. nije prijestupna.");
}

//1. u klasi radimo delegat - property 3 komada, readonly property starost
//    u rodjendan seter i geter
//    u glavnom podizanje dogadaja