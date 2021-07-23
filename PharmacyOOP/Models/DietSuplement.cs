using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class DietSuplement : Vitamine
    {
        public int WeightRestriction { get; set; }

        public DietSuplement()
        {
            Subtype = VitamineSubtypes.DietSuplement;
        }
    }
}
