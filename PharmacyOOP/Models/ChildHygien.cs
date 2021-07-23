using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class ChildHygien:ForChildren
    {
        public int AgeRestriction { get; set; }

        public ChildHygien()
        {
            Subtype = SubtypesForChildren.ChildHygien;
        }
    }
}
