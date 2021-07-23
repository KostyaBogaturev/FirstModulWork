using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class BodyCare :Cosmetic
    {
        public string BodyPart { get; set; }

        public BodyCare()
        {
            Subtype = CosmeticSubtypes.BodyCare;
        }
    }
}
