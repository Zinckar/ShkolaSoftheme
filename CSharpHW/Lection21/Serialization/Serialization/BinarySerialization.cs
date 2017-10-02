using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class BinarySerialization<T> : ISerialization<T>
    {
        private const string FileName = "binarySerializerResult.dat";
        public void Serialize(List<T> list)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                formatter.Serialize(fs, list);
            }
        }

        public List<T> Deserialize()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(FileName, FileMode.Open))
            {
                return (List<T>)formatter.Deserialize(fs);
            }
        }
    }
}