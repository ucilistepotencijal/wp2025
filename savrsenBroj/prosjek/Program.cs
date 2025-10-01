

using System.Linq.Expressions;

Console.Write("unesi prosijecnu ocijenu: ");
double ocj = double.Parse(Console.ReadLine());

Console.WriteLine("uspjeh je {0} ", prosjek(ocj));

bool bIsprav = false;
double ocjena = -1;

while (!bIsprav)
{
    Console.Write("unesi prosjecnu ocjenu: ");
    try
    {
        if (ocj < 1 || ocj > 5)
        {
            throw new Exception("out of range");
        }
        bIsprav = true;
    }
    catch (Exception ex)
    {

    }
    
}


partial class Program
{
    static string prosjek(double prosjek)
    {
        if (prosjek >= 4.5)
        {
            return "5";
        }
        else if (prosjek >= 3.5)
        {
            return "4";
        }
        else if (prosjek >= 2.5)
        {
            return "3";
        }
        else if (prosjek >= 1.5)
        {
            return "2";
        }
        else
        {
            return "1";
        }

    }
}