using Automobili;

Automobil automobil = new Automobil();
Console.Write("Unesi marku: ");
automobil.Marka = Console.ReadLine();
Console.Write("Unesi KS: ");
automobil.KS = double.Parse(Console.ReadLine());
Console.Write("Unesi osnovnu cijenu: ");
automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

Console.WriteLine("Iznos poreza: {0}", automobil.IznosPoreza());
Console.WriteLine("Ukupna cijena: {0}", automobil.UkupnaCijena());
