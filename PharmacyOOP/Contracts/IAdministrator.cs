using PharmacyOOP.Abstractions;
using System;

namespace PharmacyOOP.Contracts
{
    public interface IAdministrator
    {
        void Create(Product product);

        void Remove(Guid Id);

        void Update(Guid id, Product product);
    }
}
