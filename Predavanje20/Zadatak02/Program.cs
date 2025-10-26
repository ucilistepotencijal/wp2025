
using System.Threading.Channels;

Dictionary<string,string> rjecnik=new Dictionary<string,string>();
string unos = "";
while (unos.ToLower() != "kraj") ;
{
    Console.WriteLine("Unesi riječ( za kraj unesi 'kraj') ");
    unos = Console.ReadLine();
    string prvoslovo = unos[0].ToString().ToUpper();

    if (unos.ToLower() != "kraj" && unos!= "")
    {
        if (rjecnik.ContainsKey(prvoslovo))
        {
            rjecnik[prvoslovo] = unos;
        }
        else
        {
            rjecnik.Add(unos, prvoslovo);
        }

    }
}
List<string> lista = rjecnik.Keys.ToList();
lista.Sort();
foreach (string key in lista)
{
    Console.WriteLine("Riječi koje počinju slovom {0}: {1}", key, rjecnik[key]);
}