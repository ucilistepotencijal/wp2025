/* 4. Napiši program u kojem se traži unos prirodnih brojeva dok se ne unese 0 i zatim se uneseni
brojevi ispisuju poredani po veličini.
Napomena: Za ispis elemenata sortaranog niza koristiti petlju foreach.
Try Catch Finally!!! */

List<int> brojevi = new List<int>();

while(true)
{
    try
    {
        Console.Write("Unesi prirpdni broj (unesi 0 za prekid programa): ");
        string unos = Console.ReadLine();
        int broj = int.Parse(unos);

        if (broj == 0)
        {
            break;
        }
        if (broj < 0)
        {
            Console.WriteLine("Unesite prirodni broj!");
            continue;
        }

        brojevi.Add(broj);
    }
    catch (Exception e)
    {
        Console.WriteLine("Ups... Dogodila se greška: " + e.Message);
    }

    brojevi.Sort();

    Console.WriteLine("\nUneseni brojevi su: ");
    foreach (int b in brojevi)
    {
        Console.WriteLine(b);
    }
}
