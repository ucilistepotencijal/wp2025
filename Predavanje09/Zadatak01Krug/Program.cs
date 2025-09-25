
double r = UnesiPolumjer();

double o = Opseg(r);
Console.WriteLine(o);

double pov = Povrsina(r);
Console.WriteLine(pov);


partial class Program
{
   
    static double Opseg (double broj)
    {
        
        return 2 * broj * Math.PI;
    }
    static double Povrsina (double broj)
    {
        return Math.Pow(broj, 2) * Math.PI;
    }
    static double UnesiPolumjer()
    {
        Console.WriteLine("Unesi polumjer kruga: ");
        double r = double.Parse(Console.ReadLine());
        return r;
    }
    
    
}
