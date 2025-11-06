namespace WebShopDAL
{
    public class Init
    {
        public static Proizvodi PopuniWebShop()
        {
            Proizvodi proizvodi = new Proizvodi()
            {
                new Proizvod{Naziv = "Mlijeko", Opis = "bijela tekućina", Dostupan = true, JedCijena = 0.99 },
                new Proizvod{Naziv = "Sir", Opis = "pokvareno mlijeko", Dostupan = true, JedCijena = 2.99 },
                new Proizvod{Naziv = "Kruh", Opis = "namirnica", Dostupan = true, JedCijena = 1.19 },
                new Proizvod{Naziv = "Salama", Opis = "podriguša", Dostupan = false, JedCijena = 1.99 },
            };
            return proizvodi;
        }
    }
}
