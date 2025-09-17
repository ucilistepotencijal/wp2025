try
{
    double brojA, brojB;
    string operacija;

    Console.Write("Unesi prvi broj: ");
    brojA = double.Parse(Console.ReadLine());

    Console.Write("Unesi drugi broj: ");
    brojB = double.Parse(Console.ReadLine());

    Console.Write("Unesi računsku operaciju: ");
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
    Console.WriteLine("Ups... Dogodila se greška: " + e.Message);
}
finally
{
    Console.WriteLine("THE END");
}
