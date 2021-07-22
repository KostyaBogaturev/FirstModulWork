using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class Dermatological: Medicine
    {
        public Dermatological()
        {
            Subtype = MedicineSubtypes.Dermatological;
        }
    }
}
