using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class Curdiovascular : Medicine
    {
        public string IndicationsForCaesarean { get; set; }

        public Curdiovascular()
        {
            Subtype = MedicineSubtypes.Curdiovascular;
        }
    }
}
