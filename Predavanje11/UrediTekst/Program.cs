// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
partial class Program
{
    static string[] RastaviRecenicu(string recenica)
    {
        string[] rijeci = recenica.Split(' ');
  for (int i = 0; i < rijeci.Length; i++)
        {
            rijeci[i] = MakniInterpunkciju(rijeci[i]);
        }
        return rijeci;
    }
    static string MakniInterpunkciju(string rijec) => rijec = rijec.Replace('.', ' ').Replace(', ' ').Replace('!' , ' ').Replace(' ? ' , ' '); Trim();
        return rijec;
}
