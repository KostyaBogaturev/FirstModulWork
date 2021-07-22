using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class DietSuplement : Vitamine
    {
        public DietSuplement()
        {
            Subtype = VitamineSubtypes.DietSuplement;
        }
    }
}
