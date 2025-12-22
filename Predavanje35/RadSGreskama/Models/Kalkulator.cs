namespace RadSGreskama.Models
{
    public class Kalkulator
    {
        public decimal PrviBroj { get; set; }
        public decimal DrugiBroj { get; set; }
        public decimal Rezultat { get; set; }
        public void Dijeli()
        {
            Rezultat = PrviBroj / DrugiBroj;
        }
        public void Zbroji()
        {
            Rezultat = PrviBroj + DrugiBroj;
        }   
    }
}
