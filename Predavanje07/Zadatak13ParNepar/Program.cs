


int parni = 0;
int neparni = 0;
int unos = 0;



for (int i = 0; i <= unos; i++)
{
    Console.Write("Unesi prirodan broj: ");
    unos = int.Parse(Console.ReadLine());


    if (unos % 2 == 0)
    {
        parni += unos;
    }
    else if (unos % 2 != 0)
    {
        neparni += unos;
    }
    else if (unos == 0)
    {
        Console.WriteLine("Broj parnih brojeva u nizu je {0}", parni);
        Console.WriteLine("Broj neparnih brojeva u nizu je {0}", neparni);
    }
}   

