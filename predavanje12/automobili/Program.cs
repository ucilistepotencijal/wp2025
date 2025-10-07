using automobili;
Automobil automobil = new Automobil();

Console.Write("unesi marku: ");
automobil.Marka = Console.ReadLine();
Console.Write("unesi ks: ");
automobil.KS = Console.ReadLine();
Console.Write("unesi cijenu: ");
automobil.osnovnaCijena = Console.ReadLine();

Console.WriteLine("iznos poreza: {0}", automobil.iznosPoreza());
Console.WriteLine("ukupna cijena: {0}", automobil.ukupnaCijena());


