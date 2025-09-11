namespace UnosBroja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 broj;

            broj = 5;

            int drugiBroj = Convert.ToInt32(12);
            decimal broj3 = 13;
            decimal broj4 = 15.5m;

            broj = (int)broj4;


            Console.WriteLine(broj);
            Console.WriteLine(drugiBroj);
            Console.WriteLine(broj3);
            Console.WriteLine(broj4);

            Console.WriteLine("unesi neki tekst: ");
            string unos = Console.ReadLine();   

            Console.WriteLine("unos: " + unos);

            Console.WriteLine("unesi neki broj:");
            int uneseniBroj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("unesi drugi broj:");
            int uneseni_Broj_2 = int.Parse(Console.ReadLine());

            Console.WriteLine(uneseniBroj + uneseni_Broj_2);


        }
    }
}
