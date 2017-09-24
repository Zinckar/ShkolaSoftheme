namespace DataStructures
{
    public interface IDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);

        bool Remove(TKey key);

        TValue this[TKey key]
        {
            get;
            set;
        }

        bool TryGetValue(TKey key, out TValue value);

        void Update(TKey key, TValue value);
    }
}