namespace operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kalkuator
            //unos podataka
            int broj1;

            Console.WriteLine("unesi prvi broj;");
            broj1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("unesi drugi broj: ");
            int broj2 = int.Parse(Console.ReadLine());

            int zbroj = broj1 + broj2;
            int razlika = broj1 - broj2;
            int umnozak = broj1 * broj2;
            int kolicnik = broj1 / broj2;

            Console.WriteLine(broj1 + " + " + broj2 + " = " + zbroj);
            Console.WriteLine(broj1 + " - " + broj2 + " = " + razlika);

            Console.WriteLine("{0} * {1} = {2}", broj1, broj2, umnozak );
            Console.WriteLine($"{broj1} / {broj2} = {kolicnik}");

            int a = 11;
            int b = 13;

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
