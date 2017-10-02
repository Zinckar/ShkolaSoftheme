using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Serialization
{
    public class JsonSerialization<T> : ISerialization<T>
    {
        private const string FileName = "jsonSerializerResult.json";

        public void Serialize(List<T> list)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, list);
            }
        }

        public List<T> Deserialize()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));

            using (var fs = new FileStream(FileName, FileMode.Open))
            {
                return (List<T>)jsonFormatter.ReadObject(fs);
            }
        }
    }
}