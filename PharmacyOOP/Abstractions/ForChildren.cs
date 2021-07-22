using PharmacyOOP.Enums;

namespace PharmacyOOP.Abstractions
{
    public abstract class ForChildren:Product
    {
        public SubtypesForChildren Subtype { get; set; }

        public ForChildren()
        {
            Type = ProductTypes.ForChildren;
        }
    }
}
