

(double x, double y) UnesiTocku(string ime)
{
    Console.WriteLine($"unesi koordinate točke {ime}:");
    Console.Write("x: "); 
    double x = double.Parse(Console.ReadLine());
    Console.Write("y: "); 
    double y = double.Parse(Console.ReadLine());
    return (x, y);
}

var p = UnesiTocku("p");
var r = UnesiTocku("r");

double d = Math.Sqrt(Math.Pow(p.x - r.x, 2) + Math.Pow(p.y - r.y, 2));
Console.WriteLine($"Udaljenost P–R: {d}");