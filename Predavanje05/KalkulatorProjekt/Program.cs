using System.Threading.Channels;

double brojA, brojB;
string operacija;




Console.Write("Unesi prvi cijeli broj: ");
brojA = double.Parse(Console.ReadLine());

Console.Write("Unesi drugi cijeli broj: ");
brojB = double.Parse(Console.ReadLine());

Console.Write("Unesi računsku operaciju: ");
operacija = Console.ReadLine();

double rezultat = 0;

if (operacija == "+")
{
    rezultat = brojA + brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "-")
{
    rezultat = brojA - brojB;
    Console.WriteLine(rezultat);
}
else if(operacija == "*")
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
    Console.WriteLine("Nepoznata računska operacija!");
}
