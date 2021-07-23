using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class Dermatological: Medicine
    {
        public string DermaType { get; set; }

        public Dermatological()
        {
            Subtype = MedicineSubtypes.Dermatological;
        }
    }
}
