using PharmacyOOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Abstractions
{
    public abstract class Vitamine: Product
    {
        public VitamineSubtypes Subtype { get; set; }

        public Vitamine()
        {
            Type= ProductTypes.Vitamine
        }
    }
}
