using System;

namespace ArrayWrapper
{
    public class ArrayWrapper<T>
    {
        public T[] Array { get; set; }

        public ArrayWrapper(T[] array)
        {
            Array = array;
        }

        public void Add(T item)
        {
            T[] arr = new T[Array.Length];
            Array.CopyTo(arr, 0);
            Array = new T[arr.Length + 1];
            arr.CopyTo(Array, 0);
            Array[arr.Length] = item;
        }

        public bool Contains(T element)
        {
            foreach (var a in Array)
            {
                if (a.Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public T GetByIndex(int index)
        {
            return Array[index];
        }
    }
}