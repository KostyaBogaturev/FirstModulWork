using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class Toy : ForChildren
    {
        public Sex SexSegrigation { get; set; }


        public Toy()
        {
            Subtype = SubtypesForChildren.Toys;
        }
    }
}
