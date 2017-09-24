namespace Iterator
{
    class ConcreteIterator<T> : IIterator<T> where T : class
    {
        private readonly ConcreteAggregate<T> _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public T First()
        {
            _current = 0;
            return _aggregate[_current];
        }

        public T Next()
        {
            T ret = null;

            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }

            return ret;
        }

        public T CurrentItem()
        {
            return _aggregate[_current];
        }

        public bool IsDone()
        {
            return _current <= _aggregate.Count;
        }
    }
}