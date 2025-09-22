//Napiši program koji ispisuje sumu prvih 100 prirodnih brojeva
// 1 + 2 + 3 + 4 + ... + 95 + 96 + 97 + 98 + 99 + 100

int suma = 0;

for (int i = 0; i <= 100; i++)
{
    suma += i; // ili: suma = suma + i;
}

Console.WriteLine("Zbroj prvih 100 prirodnih brojeva je " + suma);