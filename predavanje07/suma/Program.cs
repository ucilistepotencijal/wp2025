//Napiši program koji ispisuje sumu prvih 100 prirodnih brojeva.
// 1 + 2 + 3 + 4 + 5 + .... + 95 + 96 + 97 + 98 + 99 + 100
// n*(n+1)/2

int suma = 0;
for (int i = 1; i <= 100; i++)
{
    suma += i; // ili: suma = suma + i;
}

Console.WriteLine("Zbroj prvih 100 prirodnih brojeva je " + suma);

