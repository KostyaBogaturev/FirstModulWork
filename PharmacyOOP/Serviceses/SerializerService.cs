using Newtonsoft.Json;
using PharmacyOOP.Contracts;
using System.Collections.Generic;
using System.IO;

namespace PharmacyOOP.Serviceses
{
    public class SerializerService<T> : ISerializerService<T>
    {
        private JsonSerializer _jsonSerializer = new JsonSerializer();

        public string Path { get; set; }

        public SerializerService(string path)
        {
            Path = path;
        }

        public IEnumerable<T> Deserialize()
        {
            IEnumerable<T> result;

            using (StreamReader sr = new StreamReader(Path))
            {
                result = (IEnumerable<T>)_jsonSerializer.Deserialize(sr, typeof(IEnumerable<T>));
            }
            return result;
        }

        public void Serialize(T item)
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                _jsonSerializer.Serialize(sw, item);
            }
        }
    }
}
