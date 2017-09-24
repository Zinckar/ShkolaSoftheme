namespace DataStructures
{
    public class DictionaryNode<TKey, TValue>
    {

        public TKey Key { get; private set; }

        public TValue Value { get; set; }

        public DictionaryNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}