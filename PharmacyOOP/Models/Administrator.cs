using PharmacyOOP.Abstractions;
using PharmacyOOP.Contracts;
using PharmacyOOP.Enums;
using System;
using System.Collections.Generic;

namespace PharmacyOOP.Models
{
    public class Administrator : User, IAdministrator
    {
        public Administrator()
        {
            Role = Roles.Administrator;
        }

        public override void AddToOrder(Product product)
        {
            throw new NotImplementedException();
        }

        public void Create(Product product)
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

        public void Remove(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
