﻿using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class BodyCare :Cosmetic
    {

        public BodyCare()
        {
            Subtype = CosmeticSubtypes.BodyCare;
        }
    }
}
