


int parni = 0;
int neparni = 0;
int unos = 1;

while (unos != 0)
{
    Console.Write("Unesi prirodan broj: ");
    unos = int.Parse(Console.ReadLine());

    if (unos % 2 == 0)
    {
        parni++;
    }
    else
    {
        neparni++;
    }
}
Console.WriteLine("Broj parnih brojeva u nizu je {0}", parni);
Console.WriteLine("Broj neparnih brojeva u nizu je {0}", neparni);


