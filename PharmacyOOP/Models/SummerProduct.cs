using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;
using System.Collections.Generic;

namespace PharmacyOOP.Models
{
    public class SummerProduct : Cosmetic
    {

        public IEnumerable<string> Alergens { get; set; }

        public SummerProduct()
        {
            Subtype = CosmeticSubtypes.SummerProduct;
        }
    }
}
