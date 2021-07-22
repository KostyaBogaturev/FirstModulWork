using PharmacyOOP.Contracts;
using PharmacyOOP.Enums;
using PharmacyOOP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Abstractions
{
    public abstract class User : ICustomer
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }

        public Roles Role { get; set; }

        public Order Order { get; set; }

        public abstract void AddToOrder(Product product);

        public abstract IEnumerable<Product> GetAll();

        public abstract void MakeOrder();

    }
}
