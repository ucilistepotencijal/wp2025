// Napiši program koji ispisuje sve prirodne brojeve iz segmenta [1, 500] djeljive sa 3.

Console.WriteLine("Prirodni brojeve iz segmenta [1, 500] djeljivi sa 3 su: ");
for (int i = 1; i <=500; i++)
{
    if (i % 3 == 0)
    Console.Write(i + ", ");
}


