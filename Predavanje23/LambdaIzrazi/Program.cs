//Primjer lambda izraza: x => x * x
Func<double, double> f1 = x => x;
double rezultat = f1(5);
Console.WriteLine(rezultat);

Func<int, int, int> f2 = (x,y) => x * y;
int rezultat2 = f2 (5 ,6);
Console.WriteLine(rezultat2);

Func<string> f3 = () => DateTime.Now.ToShortDateString();
string rezultat3 = f3();
Console.WriteLine(rezultat3);

//Foreach sa lambda izrazom
string rezultat4 = "";
List<string> imena  = new List<string>()
{
    "Pero",
    "Ana",
    "Marko",
    "Iva",
    "Josip"
};
imena.ForEach(i => rezultat4 +=(i + " ;"));
Console.WriteLine(rezultat4);

int imenaSaSlovomO = imena.Count(i => i.Contains("o"));
Console.WriteLine("Broj imena koje sadrže slovo o: " + imenaSaSlovomO);

int[] brojevi = { 1, 3, 5, 9, 15, 24 };
List<int> kvadrati = brojevi.Select(i => i * i).ToList();
string rezultat5 = "";
kvadrati.ForEach(i => rezultat5 +=(i+ ", "));
Console.WriteLine(rezultat5);

IEnumerable<int>sintaksaUpita= from b in brojevi
                               where b % 2 == 0
                               orderby b
                               select b;

