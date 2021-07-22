using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class Toy : ForChildren
    {
        public Toy()
        {
            Subtype = SubtypesForChildren.Toys;
        }
    }
}
