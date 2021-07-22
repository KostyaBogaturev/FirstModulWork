using PharmacyOOP.Enums;
using PharmacyOOP.Models;
using System;

namespace PharmacyOOP.Abstractions
{
    public abstract class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Firm { get; set; }

        public double Cost { get; set; }

        public int Count { get; set; }

        public string Image { get; set; }

        public ProductTypes Type { get; set; }

        public IEquatable<Pharmacy> Pharmacies { get; set; }
    }
}
