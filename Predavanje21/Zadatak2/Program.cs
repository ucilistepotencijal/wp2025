
/*
2. DvaTri
Napiši program koji zapisuje u datoteke sve brojeve iz intervala [0,100] koji su djeljivi s brojem 2
ili brojem 3 na sljedeći način:
- 2ili3NoviRed.txt – svaki broj u novi red
-2ili3SaZaretima.txt – svaki broj odvojen zarezom2. DvaTri
Napiši program koji zapisuje u datoteke sve brojeve iz intervala [0,100] koji su djeljivi s brojem 2
ili brojem 3 na sljedeći način:
- 2ili3NoviRed.txt – svaki broj u novi red
-2ili3SaZaretima.txt – svaki broj odvojen zarezom
*/

FileStream fsl = new FileStream("2ili3NoviRed.txt", FileMode.Create);
StreamWriter sw1 = new StreamWriter(fsl);

FileStream fs2 = new FileStream("2ili3saZarezima.txt", FileMode.Create);
StreamWriter sw2 = new StreamWriter(fs2);

for (int i = 0; i <= 100; i++)
{
    if (i % 2 ==0 || i % 3 ==0)
    {
        sw1.WriteLine(i);
        if (i > 0)
        {
            sw2.Write(" , " + i);
        }
        else
        {
            sw2.Write(i);
        }
    }
}
sw1.Close();
sw2.Close();

