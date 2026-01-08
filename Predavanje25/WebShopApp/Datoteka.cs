
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL;

namespace WebShopApp
{
    public static class Datoteka
    {
        public static void KreirajDatoteku(Narudzba narudzba, string nazivDatoteke)
        {
            FileStream fs = new FileStream(nazivDatoteke, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("------------------------ Narudžba -------------------------");
            sw.WriteLine("Datum narudžbe: {0}", narudzba.DatumKreiranja);
            sw.WriteLine("Dostavljeno: {0}", (narudzba.DostavaIzvrsena ? "DA" : "NE"));
            sw.WriteLine("Proizvodi: ");
            foreach (Proizvod item in narudzba.Proizvodi)
            {
                sw.WriteLine("{0}: {1} EUR", item.Naziv, Math.Round(item.UkupnaCijena, 2));
            }
            sw.WriteLine("Ukupna cijena: {0} EUR", Math.Round(narudzba.UkupnaCijena, 2));
            sw.Close();
        }

        public static string ProcitajDatoteku(string nazivDatoteke)
        {
            FileStream fs = new FileStream(nazivDatoteke, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sadrzaj = sr.ReadToEnd();
            sr.Close();
            return sadrzaj;
        }
    }
}
