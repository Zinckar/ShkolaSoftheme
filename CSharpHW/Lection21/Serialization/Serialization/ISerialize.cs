using System.Collections.Generic;

namespace Serialization
{
    public interface ISerialization<T>
    {
        void Serialize(List<T> list);

        List<T> Deserialize();
    }
}