

partial class Program
{
    interface IMojInterfejs
    {
        //Svojstva
        int mojBroj { get; set; }

        //Metode
        int vratiNesto();
    }

    public class Osoba : IMojInterfejs
    {
        public int mojBroj { get; set; }

        public int vratiNesto()
        {
            return 0;
        }
    }

    public class Student : IMojInterfejs
    {
        public int mojBroj { get; set; }

        public int vratiNesto()
        {
            return 5;
        }
    }
}