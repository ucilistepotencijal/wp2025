Console.Write("Unesi broj predmeta: ");
int brojPredmeta = int.Parse(Console.ReadLine());
int zbrojOcjena = 0;
bool prosao = true;

for (int i = 0; i < brojPredmeta; i++)
{
    bool ispravanUnos = false;
    int ocjena;
    do
    {
        Console.Write("Unesi ocjenu: ");
        ispravanUnos = int.TryParse(Console.ReadLine(), out ocjena);
        if (ocjena < 1 || ocjena > 5)
        {
            ispravanUnos = false;
        }

    } while (!ispravanUnos);
    if (ocjena == 1)
    {
        prosao = false;
    }
    zbrojOcjena += ocjena;
}
double prosjek = (double)zbrojOcjena / brojPredmeta;

if (!prosao)
{
    Console.WriteLine("Uspjeh je nedovoljan!");
}
else if (prosjek >= 4.5)
{
    Console.WriteLine("Uspjeh je odličan!");
}
else if (prosjek >= 3.5)
{
    Console.WriteLine("Uspjeh je vrlo dobar!");
}
else if (prosjek >= 2.5)
{
    Console.WriteLine("Uspjeh je dobar!");
}
else if (prosjek >= 1.5)
{
    Console.WriteLine("Uspjeh je dovoljan!");
}