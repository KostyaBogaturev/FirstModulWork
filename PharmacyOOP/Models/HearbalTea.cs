using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;

namespace PharmacyOOP.Models
{
    public class HearbalTea : Vitamine
    {
        public string TasteDescription { get; set; }

        public HearbalTea()
        {
            Subtype = VitamineSubtypes.HerbalTea;
        }
    }
}
