using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyOOP.Contracts
{
    public interface ISerializerService<T>
    {
        void Serialize(T item);

        IEnumerable<T> Deserialize();
    }
}
