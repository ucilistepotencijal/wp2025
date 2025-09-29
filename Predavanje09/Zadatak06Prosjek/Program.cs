
using System.Xml.Linq;

bool bIspravno = false;
double ocjena = -1;
while (true)
{
    Console.WriteLine("Unesi prosječnu ocjenu: ");
    ocjena = double.Parse(Console.ReadLine());

    try
    {
        ocjena = double.Parse(Console.ReadLine());
        if (ocjena < 1 || ocjena > 5)
        {
            throw new Exception("Variable out of range!");
        }
        bIspravno = true;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Greška: " + ex.Message);
    }
    
}

Console.WriteLine("Uspjeh je {0}.", Prosjek(ocjena));

partial class Program
{
    static string Prosjek(double prosjek)
    {
        if (prosjek >= 4.5)
        {
            return "odličan";
        }
        else if (prosjek >= 3.5)
        {
            return "vrlo dobar";
        }
        else if (prosjek >= 2.5)
        {
            return "dobar";
        }
        else if (prosjek >= 1.5)
        {
            return "dovoljan";
        }
        else
        {
            return "nedovoljan";
        }
    }  
      
}
       