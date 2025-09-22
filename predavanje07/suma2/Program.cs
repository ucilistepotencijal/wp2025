

using System.Diagnostics.CodeAnalysis;

int unos = -1;
int suma = 0;

while (unos != 0)
{
    Console.WriteLine("unesi prirodan broj: ");
    unos = int.Parse(Console.ReadLine());

    suma = suma + unos;
}
Console.WriteLine("suma prirodnih brojeva je "+ suma );