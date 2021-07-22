using PharmacyOOP.Abstractions;
using System;

namespace PharmacyOOP.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public IEquatable<Product> Products { get; set; }

        public Guid UserId { get; set; }

    }
}
