/* Zadatak2: Napišite program koji traži unos riječi sve dok se ne unese riječ "kraj".
1.Program sprema riječi u rječnik
Program ispisuje:
Riječi koje počinju slovom A: ...
Riječi koje počinju slovom B: ...
Riječi koje počinju slovom C: ...
*/

Dictionary <string, string> rjecnik = new Dictionary<string, string>();
string unos = "";
while(unos.ToLower() != "kraj")
{
    Console.Write("Unesi riječ (za kraj unesi 'kraj')");
    unos = Console.ReadLine();
    string prvoslovo = unos[0].ToString().ToUpper(); //stavljamo ToString() jer metoda ToUpper() radi samo na stringu (a unos[0] je char)

    if (unos.ToLower() != "kraj" && unos!= " ")
    {
        if (rjecnik.ContainsKey(prvoslovo))
        {
            rjecnik[prvoslovo] += " " + unos;
        }
        else
        {
            rjecnik.Add(prvoslovo, unos);
        }
    }
}
List<string> lista = rjecnik.Keys.ToList();
lista.Sort();
foreach (string key in lista)
{
    Console.WriteLine("Riječi koje počinju slovom {0}: {1}", key, rjecnik[key]);
}