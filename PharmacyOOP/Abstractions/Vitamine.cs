using PharmacyOOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Abstractions
{
    public abstract class Vitamine: Product
    {
        public Vitamine()
        {
            Type= ProductTypes.Vitamine
        }
    }
}
