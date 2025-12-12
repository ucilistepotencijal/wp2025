using System.ComponentModel.DataAnnotations;

namespace Validacije.Models
{
    public class NeViseOdTriDanaAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is MetaRacun)
            {
                MetaRacun racun = (MetaRacun)value;
                if (racun.DatumRacuna < DateTime.Now.AddDays(-3))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
