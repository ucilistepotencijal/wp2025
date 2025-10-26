using Zadatak03;
using Zadatak3;

List<Pas> psi = new List<Pas>();
List<Macka> macke = new List<Macka>();
string unos = "da";
partial class Program
{
    static void p_Budjenje(object  sender, EventArgs e)
    {
        Console.WriteLine(((Pas)sender).GlasajSe());
    }
    static void m_Budjenje(object sender, EventArgs e)
    {
        Console.WriteLine();
    }
}