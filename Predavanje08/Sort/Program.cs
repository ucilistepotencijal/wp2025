



List<int> brojevi = new List<int>();
int unos;

Console.WriteLine("Unosite prirodne brojeve (0 za kraj):");


do
{
    Console.Write("Unesi broj: ");
    unos = int.Parse(Console.ReadLine());

    if (unos > 0)
    {
        brojevi.Add(unos);
    }

} while (unos != 0);



