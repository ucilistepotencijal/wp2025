FileStream fs1 = new FileStream("2ili3NoviRed.txt", FileMode.Create);
StreamWriter sw1 = new StreamWriter(fs1);

FileStream fs2 = new FileStream("2ili3SaZarezima.txt", FileMode.Create);
StreamWriter sw2 = new StreamWriter(fs2);

for(int i = 0; i < 10; i++)
{
    if (i % 2 == 0 || i % 3 == 0)
    {
        sw1.WriteLine(i);
        if (i > 0)
        {
            sw2.Write(", " + i);
        }
        else
        {
            sw2.Write(i);
        }
    }
}
sw1.Close();    
sw2.Close();
