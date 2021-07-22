using PharmacyOOP.Abstractions;

namespace PharmacyOOP.Contracts
{
    public interface ICustomer
    {
        void AddToOrder(Product product);

        void MakeOrder();

    }
}
