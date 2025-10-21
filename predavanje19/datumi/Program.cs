
using System.Collections.Concurrent;

DateTime novaGodima = new DateTime();

DateTime novaGodima2 = new DateTime(2026, 1, 1);

Console.WriteLine(novaGodima2);
Console.WriteLine(novaGodima2.ToShortDateString());
Console.WriteLine(novaGodima2.ToString("dd.MM.yy."));
Console.WriteLine(novaGodima2.ToString("ddd dd.MMM.yyyy."));
Console.WriteLine(novaGodima2.ToString("dddd, MMM dd.MM.yyyy."));
Console.WriteLine(novaGodima2.ToString("dddd, MMMM dd.yyyy."));


Console.Write("unesi datum: ");
DateTime datum = DateTime.Parse(Console.ReadLine());
Console.WriteLine(datum.ToShortDateString());

if (datum < novaGodima2)
{
    Console.WriteLine("datum je prije nove godine.");
}
else if (datum > novaGodima2)
{
    Console.WriteLine("datum je poslije nove godine.");
}
else
{
    Console.WriteLine("sretna nova godina!");
}
Console.WriteLine("trenutni datum je: {0}", DateTime.Today.ToShortDateString());
Console.WriteLine("trenutni datum je: {0}", DateTime.Today);
Console.WriteLine("trenutni datum i vrijeme je: {0}", DateTime.Now.ToString("d.M.yyyy. HH:mm:ss:fff"));

Console.WriteLine("nova godina pada na {0}", novaGodima2.DayOfWeek);
Console.WriteLine("nova godina pada na {0}", novaGodima2.ToString("dddd"));

Console.WriteLine("danas je {0}. dan u godini ", DateTime.Today.DayOfYear);

Console.WriteLine("novoj godini dodajem 45 dana: {0}", novaGodima2.AddDays(45).ToShortDateString());
Console.WriteLine("novoj godini oduzimam 45 dana: {0}", novaGodima2.AddDays(-45).ToShortDateString());


TimeSpan doNoveGodine = novaGodima2 - DateTime.Now;
Console.WriteLine("do nove ima {0} dana", doNoveGodine.Days);
Console.WriteLine("do nove ima {0} dana", doNoveGodine.TotalDays);
Console.WriteLine("do nove ima {0} sati", doNoveGodine.Hours);
Console.WriteLine("do nove ima {0} sati", doNoveGodine.TotalHours);

if(DateTime.IsLeapYear(2026))
{
    Console.WriteLine("godina 2026. je prjestupna");

}
else
{
    Console.WriteLine("godina 2026. nije prijestupna ");
}



