
        List<int> brojevi = new List<int>();
int broj = -1;

        Console.Write("Unesite brojeve (0 za kraj): ");
        while (true)
        {
            Console.Write("Unesi broj: ");
            try
            {

            }
            broj = int.Parse(Console.ReadLine());
            if (broj == 0)
            {
                break;
            }
            else
            {
                brojevi.Add(broj);
            }

            IntervalBrojevi(brojevi);
        }
        catch(Exeption e)
        {



        }
    public static void IntervalBrojevi(List<int> brojevi)
    {
        var intervalBrojevi = brojevi.Where(b => b >= 1 && b <= 11);
        foreach (int item in intervalBrojevi)
        {
            Console.WriteLine(item + ", ");
        }

    }