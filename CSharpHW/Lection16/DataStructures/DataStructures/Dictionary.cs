using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private LinkedList<DictionaryNode<TKey, TValue>>[] _dictionaryArray;
        private int _capacity = 10;
        private int _count;

        public Dictionary()
        {
            _dictionaryArray = new LinkedList<DictionaryNode<TKey, TValue>>[_capacity];
        }

        public void Add(TKey key, TValue value)
        {
            var currentIndex = GetIndex(key);
            if (_count >= _capacity)
            {
                LinkedList<DictionaryNode<TKey, TValue>>[] newDictionaryArray =
                    new LinkedList<DictionaryNode<TKey, TValue>>[_capacity * 2];

                _dictionaryArray.CopyTo(newDictionaryArray, 0);

                _dictionaryArray = newDictionaryArray;
            }

            if (_dictionaryArray[currentIndex] != null)
            {
                foreach (var item in _dictionaryArray[currentIndex])
                {
                    if (item.Key.Equals(key))
                    {
                        throw new ArgumentException("The collection already contains the key");
                    }
                }
            }

            LinkedList<DictionaryNode<TKey, TValue>> list = new LinkedList<DictionaryNode<TKey, TValue>>();
            list.AddFirst(new DictionaryNode<TKey, TValue>(key, value));
            _dictionaryArray[GetIndex(key)] = list;
            _count++;
        }

        public bool Remove(TKey key)
        {
            var currentIndex = GetIndex(key);
            bool removed = false;

            if (_dictionaryArray[currentIndex] != null)
            {
                LinkedListNode<DictionaryNode<TKey, TValue>> current = _dictionaryArray[currentIndex].First;
                while (current != null)
                {
                    if (current.Value.Key.Equals(key))
                    {
                        _dictionaryArray[currentIndex].Remove(current);
                        removed = true;
                        break;
                    }

                    current = current.Next;
                }
            }
            if (removed)
            {
                _count--;
            }

            return removed;
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                if (!TryGetValue(key, out value))
                {
                    throw new ArgumentException("Key is not valid");
                }

                return value;
            }
            set { Update(key, value); }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            var currentIndex = GetIndex(key);

            value = default(TValue);

            bool found = false;

            if (_dictionaryArray[currentIndex] != null)
            {
                foreach (DictionaryNode<TKey, TValue> item in _dictionaryArray[currentIndex])
                {
                    if (item.Key.Equals(key))
                    {
                        value = item.Value;
                        found = true;
                        break;
                    }
                }
            }

            return found;
        }

        public void Update(TKey key, TValue value)
        {
            bool updated = false;

            var currentIndex = GetIndex(key);

            if (_dictionaryArray[currentIndex] != null)
            {
                foreach (DictionaryNode<TKey, TValue> pair in _dictionaryArray[currentIndex])
                {
                    if (pair.Key.Equals(key))
                    {
                        pair.Value = value;
                        updated = true;
                        break;
                    }
                }
            }

            if (!updated)
            {
                throw new ArgumentException("The collection does not contain the key");
            }
        }

        private int GetIndex(TKey key)
        {
            return Math.Abs(key.GetHashCode() % _capacity);
        }
    }
}