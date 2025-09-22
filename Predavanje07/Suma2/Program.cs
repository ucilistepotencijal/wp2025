/* Napiši program koji traži unos prirodnih brojeva sve dok se ne unese 0, a zatim ispisuje
njihovu sumu. */

int unos = -1;
int suma = 0;

while (unos != 0)
{
    Console.Write("Unesi prirodni broj: ");
    unos = int.Parse(Console.ReadLine());

    suma = suma + unos; // ili: suma += unos
}
Console.WriteLine("Suma prirodnih brojeca je " + suma);