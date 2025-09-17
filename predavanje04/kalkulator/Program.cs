

double brojA, brojB;
string operacija;

Console.Write("unesi prvi broj: ");
brojA = double.Parse(Console.ReadLine());

Console.Write("unesi drugi broj: ");
brojB = double.Parse(Console.ReadLine());

Console.Write("unesi računsku operaciju: ");
operacija = Console.ReadLine();

double rezultat = 0;

if  (operacija ==  "+")
{
    rezultat = brojA + brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "-")
{
    rezultat = brojA - brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "*")
{
    rezultat = brojA * brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "/")
{
    rezultat = brojA / brojB;
    Console.WriteLine(rezultat);
}
else
{
    Console.WriteLine("nepoznata racunska operacija!");
}
Console.WriteLine(rezultat);




