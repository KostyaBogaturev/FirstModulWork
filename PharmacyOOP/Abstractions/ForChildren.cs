using PharmacyOOP.Enums;

namespace PharmacyOOP.Abstractions
{
    public abstract class ForChildren:Product
    {
        public ForChildren()
        {
            Type = ProductTypes.ForChildren;
        }
    }
}
