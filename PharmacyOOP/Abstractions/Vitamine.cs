using PharmacyOOP.Enums;

namespace PharmacyOOP.Abstractions
{
    public abstract class Vitamine: Product
    {
        public VitamineSubtypes Subtype { get; set; }

        public Vitamine()
        {
            Type = ProductTypes.Vitamine;
        }
    }
}
