
Console.Write("unesi polumjer r: ");
double r = double.Parse(Console.ReadLine());

ispisKrug(r);

partial class Program
{
    static void ispisKrug(double r)
    {
        double opseg = 2 * r * Math.PI;
        double povrsina = r * r * Math.PI;

        Console.WriteLine($"opseg kruga: {opseg}");
        Console.WriteLine($"površina kruga: {povrsina}");
    }
}