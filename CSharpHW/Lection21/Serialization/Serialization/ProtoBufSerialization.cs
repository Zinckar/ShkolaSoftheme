using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace Serialization
{
    public class ProtoBufSerialization<T> : ISerialization<T>
    {
        private const string FileName = "protoBufSerializerResult.bin";

        public void Serialize(List<T> list)
        {
            using (var file = File.Create(FileName))
            {
                Serializer.Serialize(file, list);
            }
        }

        public List<T> Deserialize()
        {
            using (var file = File.OpenRead(FileName))
            {
                return Serializer.Deserialize<List<T>>(file);
            }
        }
    }
}