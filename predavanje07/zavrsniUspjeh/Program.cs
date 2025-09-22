

Console.WriteLine("unesi broj predmeta: ");
int brojPredmeta  = int.Parse(Console.ReadLine());
int zbrojOcjena = 0;
bool prosao = true;

for (int i = 0; i < brojPredmeta; i++)
{
    bool ispravanUnos = false;
    int ocjena;
    do
    {
        Console.WriteLine("unesi ocijenu");
        ispravanUnos = int.TryParse(Console.ReadLine(), out ocjena);
        if (ocjena < 1 || ocjena> 5)
        {
            ispravanUnos = false;
        }

    } while (!ispravanUnos);

    if(ocjena == 1)
    {
        prosao = false; 
    }
    zbrojOcjena += ocjena;
    
}
double prosjek = (double)zbrojOcjena / brojPredmeta;

if(!prosao)
{
    Console.WriteLine("nedovoljan ");
}
else if (prosjek>=4.5)
{
    Console.WriteLine("odlican ");
}
else if (prosjek >= 3.5)
{
    Console.WriteLine("vrlo dobar ");
}
else if (prosjek >= 2.5)
{
    Console.WriteLine("dobar ");
}
else if (prosjek >= 1.5)
{
    Console.WriteLine("nedovoljan ");
}

