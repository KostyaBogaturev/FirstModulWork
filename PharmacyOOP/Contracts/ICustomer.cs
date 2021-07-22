using PharmacyOOP.Abstractions;
using System.Collections.Generic;

namespace PharmacyOOP.Contracts
{
    public interface ICustomer
    {
        void AddToOrder(Product product);

        void MakeOrder();

        IEnumerable<Product> GetAll();

    }
}
