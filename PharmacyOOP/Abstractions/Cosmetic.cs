using PharmacyOOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Abstractions
{
    public abstract class Cosmetic:Product
    {
        public CosmeticSubtypes Subtype { get; set; }

        public Cosmetic()
        {
            Type = ProductTypes.Cosmetic;
        }
    }
}
