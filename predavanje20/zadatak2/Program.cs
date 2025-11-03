
Dictionary<string,string>rjecnik =  new Dictionary<string,string>();
string unos = "";
while (unos.ToLower() != "kraj")
{
    Console.Write("unesi rijec (za kraj unesi kraj)");
    unos = Console.ReadLine();
    string prvoSlovo = unos[0].ToString().ToUpper();

    if(unos.ToLower() != "kraj" && unos != "")
    {
        if (rjecnik.ContainsKey(prvoSlovo))
        {
            rjecnik[prvoSlovo] += ", " + unos;
        }
        else
        {
            rjecnik.Add(prvoSlovo, unos);
        }
    }
}
List<string> lista = rjecnik.Keys.ToList();
lista.Sort();
foreach (string key in lista)
{
    Console.WriteLine("rijeci koje pocinju sa slovom {0}: {1}", key, rjecnik[key]);
}