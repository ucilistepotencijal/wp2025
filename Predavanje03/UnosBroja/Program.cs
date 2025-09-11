namespace UnosBroja
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklaracija varijable
            Int32 broj;

            //inicijalizacija varijable
            broj = 5;

            //Eksplicitna pretvorba
            int drugiBroj = Convert.ToInt32(12);
            decimal broj3 = 13;
            decimal broj4 = 15.5m;

            //deciMal
            //castanje
            broj = (int)broj4;

            Console.WriteLine(broj);
            Console.WriteLine(drugiBroj);
            Console.WriteLine(broj3);
            Console.WriteLine(broj4);

            Console.WriteLine("Unesi neki tekst: ");
            string unos = Console.ReadLine();

            Console.WriteLine("Unost: " + unos);

            Console.WriteLine("Unesi neki broj: ");
            int unseniBroj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj: ");
            int unesi_Broj_2 = int.Parse(Console.ReadLine());

            Console.WriteLine(unseniBroj + unesi_Broj_2);
        }
    }
}

