


int parni = 0;
int neparni = 0;
int unos = 0;


do
{
    Console.Write("Unesi prirodan broj: ");
    unos = int.Parse(Console.ReadLine());

    if (unos % 2 == 0 && unos != 0)
    {
        parni++;
    }
    else if (unos % 2 != 0)
    {
        neparni++;
    }
    else
    {
        break;
    }

} while (unos != 0);

Console.WriteLine("Broj parnih brojeva u nizu je {0}", parni);
Console.WriteLine("Broj neparnih brojeva u nizu je {0}", neparni);






