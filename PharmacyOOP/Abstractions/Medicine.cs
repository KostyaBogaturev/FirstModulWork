using PharmacyOOP.Enums;

namespace PharmacyOOP.Abstractions
{
    public abstract class Medicine:Product
    {
        public MedicineSubtypes Subtype { get; set; }

        public Medicine()
        {
            Type = ProductTypes.Medicine;
        }
    }
}
