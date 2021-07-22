using PharmacyOOP.Abstractions;
using PharmacyOOP.Enums;
using System;
using System.Collections.Generic;

namespace PharmacyOOP.Models
{
    public class Customer : User
    {
        public Customer()
        {
            Role = Roles.Customer;
        }

        public override void AddToOrder(Product product)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void MakeOrder()
        {
            throw new NotImplementedException();
        }
    }
}
