// Napiši program koji ispisuje sumu svih 100 prirodnih brojeva.
// 1 + 2 + 3 + 4


int suma = 0;
for (int i = 1; i <= 100; i++)
{
    suma += i;
}

Console.WriteLine("Zbroj prvih 100 prirodnih brojeva je " + suma);
