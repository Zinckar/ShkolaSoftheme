using System;

namespace DataStructures
{
    public class Stack<T> : IStack<T>
    {

        private T[] _stack = new T[0];

        private int _size = 0;

        public void Push(T item)
        {
            if (_stack.Length == _size)
            {
                int newSize = (_size == 0) ? 5 : _size * 2;
                T[] newStack = new T[newSize];
                _stack.CopyTo(newStack, 0);
                _stack = newStack;

            }
            _stack[_size] = item;
            _size++;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            _size--;
            return _stack[_size];
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _stack[_size];
        }
    }
}