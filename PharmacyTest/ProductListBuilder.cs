using PharmacyOOP.Abstractions;
using PharmacyOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using PharmacyOOP.Enums;
using System.Linq;

namespace PharmacyTest
{
    public class ProductListBuilder
    {
        private int index = 0;

        private void CreateBaseProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            product.Name = $"Name {index}";
            product.Firm = $"Firm {index}";
            product.Cost = index * 3.1;
            product.Count = index = 15;
            product.Image = $"Image {index}";
        }

        public BodyCare CreateBodyCare()
        {
            var item = new BodyCare();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Cosmetic;
            item.Subtype = CosmeticSubtypes.BodyCare;

            item.BodyPart = $"Body part {index}";
            index++;
            return item;
        }

        public SummerProduct CreateSummerProduct()
        {
            var item = new SummerProduct();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Cosmetic;
            item.Subtype = CosmeticSubtypes.SummerProduct;

            item.Alergens = new List<string>() { $"Alergen {index}" };

            index++;
            return item;
        }

        public ChildHygien CreateChildHygien()
        {
            var item = new ChildHygien();

            CreateBaseProduct(item);

            item.Type = ProductTypes.ForChildren;
            item.Subtype = SubtypesForChildren.ChildHygien;

            item.AgeRestriction = index < 16 ? index : 16;

            index++;
            return item;
        }

        public Toy CreateToy()
        {
            var item = new Toy();

            CreateBaseProduct(item);

            item.Type = ProductTypes.ForChildren;
            item.Subtype = SubtypesForChildren.Toys;

            switch (index%3)
            {
                case 0:
                    item.SexSegrigation = Sex.Female;
                    break;
                case 1:
                    item.SexSegrigation = Sex.Male;
                    break;
                case 2:
                    item.SexSegrigation = Sex.Unisex;
                    break;
                default:
                    item.SexSegrigation = Sex.Unisex;
                    break;
            }

            index++;
            return item;
        }

        public Curdiovascular CreateCurdiovascular()
        {
            var item = new Curdiovascular();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Medicine;
            item.Subtype = MedicineSubtypes.Curdiovascular;

            item.IndicationsForCaesarean = $"Indications For Caesarean {index}";
            index++;
            return item;
        }

        public Dermatological CreateDermatological()
        {
            var item = new Dermatological();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Medicine;
            item.Subtype = MedicineSubtypes.Dermatological;

            item.DermaType = $"Derma {index}";
            index++;
            return item;
        }

        public DietSuplement CreateDietSuplement()
        {
            var item = new DietSuplement();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Vitamine;
            item.Subtype = VitamineSubtypes.DietSuplement;

            item.WeightRestriction = index;

            index++;
            return item;
        }

        public HearbalTea CreateHearbalTea()
        {
            var item = new HearbalTea();

            CreateBaseProduct(item);

            item.Type = ProductTypes.Vitamine;
            item.Subtype = VitamineSubtypes.HerbalTea;

            item.TasteDescription = $"Tast Description {index}";

            index++;
            return item;
        }
    }
}
