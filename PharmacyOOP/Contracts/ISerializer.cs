using System.Collections.Generic;

namespace PharmacyOOP.Contracts
{
    public interface ISerializer<T>
    {
        void Serialize(T item);

        IEnumerable<T> Deserialize();
    }
}
