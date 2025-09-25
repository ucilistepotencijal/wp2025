


int parni = 0;
int neparni = 0;
int unos = 0;



while (unos != 0)
{
    Console.Write("Unesi prirodan broj: ");
    unos = int.Parse(Console.ReadLine());

}
for (int i = 0; i < unos; i++)
{
    if (unos % 2 == 0)
    {
        parni += unos;
    }
    else
    {
        neparni += unos;
    }

}
Console.WriteLine("Broj parnih brojeva u nizu je {0}", parni);
Console.WriteLine("Broj neparnih brojeva u nizu je {0}", neparni);


