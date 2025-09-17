Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("hr-HR");

try //označili smo cijeli kod i išli smo na desni klik, snippet, surround with. I na kraju smo u catch Exception ubacili poruku "Ups...dogodila se greška!"
{
    double brojA, brojB;
    string operacija;

    Console.Write("Unesi prvi broj: ");
    brojA = double.Parse(Console.ReadLine()); //ovo unesemo ako želimo da prepozna "," kao znak decimale 

    Console.Write("Unesi drugi broj: ");
    brojB = double.Parse(Console.ReadLine());

    Console.WriteLine("Unesi računsku operaciju: ");
    operacija = Console.ReadLine();

    double rezultat = 0;

    switch (operacija)
    {
        case "+":
            rezultat = brojA + brojB;
            Console.WriteLine("Rezultat: " + rezultat);
            break;
        case "-":
            rezultat = brojA - brojB;
            Console.WriteLine("Rezultat: " + rezultat);
            break;
        case "*":
            rezultat = brojA * brojB;
            Console.WriteLine("Rezultat: " + rezultat);
            break;
        case "/":
            rezultat = brojA / brojB;
            Console.WriteLine("Rezultat: " + rezultat);
            break;
        default:
            Console.WriteLine("Nepoznata računska operacija!");
            break;
    }
}
catch (Exception e)
{

    Console.WriteLine("Ups... Dogodila se greška!" + e.Message);
}
finally
{
    Console.WriteLine("THE END");
}