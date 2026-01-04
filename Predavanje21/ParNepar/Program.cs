/*
  Napiši program koji traži unos prirodnih brojeva sve dok se ne unese broj 0. Nakon toga 
unesene parne brojeve sprema u datoteku parni.txt, a neparne u neparni.txt
 */
List<int> lsParni = new List<int>();
List<int> lsNeparni = new List<int>();
int unos = -1;

while (unos != 0)
{
    try
    {
        Console.Write("Unesi prirodni broj: ");
        unos = int.Parse(Console.ReadLine());

        if (unos == 0)
        {
            break;
        }
        if (unos < 0)
        {
            throw new Exception("Potrebno je unijeti prirodni broj!");
        }
        if (unos % 2 == 0)
        {
            lsParni.Add(unos);
        }
        else
        {
            lsNeparni.Add(unos);    
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Greška: " + e.Message);
    }
}

FileStream fs = new FileStream("parni.txt", FileMode.Create);
StreamWriter sw = new StreamWriter(fs);

foreach (int item in lsParni)
{
    sw.WriteLine(item);
}

sw.Close();

fs = new FileStream("neparni.txt", FileMode.Create);
sw = new StreamWriter(fs);

foreach (int item in lsNeparni)
{
    sw.WriteLine(item);
}

sw.Close();