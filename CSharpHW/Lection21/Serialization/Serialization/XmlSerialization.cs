using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public class XmlSerialization<T> : ISerialization<T>
    {
        private const string FileName = "xmlSerializerResult.xml";

        public void Serialize(List<T> list)
        {
            var xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                xmlFormatter.Serialize(fs, list);
            }
        }

        public List<T> Deserialize()
        {
            var xmlFormatter = new XmlSerializer(typeof(List<T>));

            using (var fs = new FileStream(FileName, FileMode.Open))
            {
                return (List<T>)xmlFormatter.Deserialize(fs);
            }
        }
    }
}