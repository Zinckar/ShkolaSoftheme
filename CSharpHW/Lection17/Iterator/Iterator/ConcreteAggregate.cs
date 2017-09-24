using System.Collections.Generic;

namespace Iterator
{
    class ConcreteAggregate<T> : IAggregate<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}