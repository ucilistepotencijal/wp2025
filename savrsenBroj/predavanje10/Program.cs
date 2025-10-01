




Console.Write("unesi temperaturu u stupnjevima C: ");
double c = double.Parse(Console.ReadLine());

pretvori(c);

partial class Program
{
    static void pretvori(double c)
    {

        double f = (9.0 / 5.0) * c + 32;
        Console.WriteLine($"{c} C = {f} F");
    }
}