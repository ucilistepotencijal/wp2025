
try
{
    double brojA, brojB;
    string operacija;

    Console.Write("unesi prvi broj: ");
    brojA = double.Parse(Console.ReadLine());

    Console.Write("unesi drugi broj: ");
    brojB = double.Parse(Console.ReadLine());

    Console.Write("unesi računsku operaciju: ");
    operacija = Console.ReadLine();

    double rezultat = 0;

    switch (operacija)
    {
        case "+":
            rezultat = brojA + brojB;
            Console.WriteLine("rezultat :" + rezultat);
            break;
        case "-":
            rezultat = brojA - brojB;
            Console.WriteLine("rezultat :" + rezultat);
            break;
        case "*":
            rezultat = brojA * brojB;
            Console.WriteLine("rezultat :" + rezultat);
            break;
        case "/":
            rezultat = brojA / brojB;
            Console.WriteLine("rezultat :" + rezultat);
            break;
        default:
            Console.WriteLine("nepoznata racunska operacija");
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine("ups.....greska!" + e.Message);
}
finally
{
    Console.WriteLine("the end");
}