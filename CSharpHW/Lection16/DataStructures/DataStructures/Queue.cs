using System;

namespace DataStructures
{
    public class Queue<T> : IQueue<T>
    {
        private T[] _queue = new T[0];

        private int _size = 0;

        private int _head = 0;

        private int _tail = -1;

        public void Enqueue(T item)
        {
            if (_queue.Length == _size)
            {
                int newSize = (_size == 0) ? 5 : _size * 2;

                T[] newQueue = new T[newSize];

                int newTail = 0;

                if (_size > 0)
                {
                    if (_tail > _head)
                    {
                        for (int i = _head; i <= _tail; i++)
                        {
                            newQueue[i] = _queue[i];
                            newTail++;
                        }
                    }
                    else
                    {
                        for (int i = _head; i < _queue.Length; i++)
                        {
                            newQueue[newTail] = _queue[i];
                            newTail++;
                        }
                        for (int i = 0; i < _tail; i++)
                        {
                            newQueue[newTail] = _queue[i];
                            newTail++;
                        }
                    }
                }
                else
                {
                    _head = 0;
                    _tail = newTail - 1;
                }
                _queue = newQueue;
            }

            if (_tail == _queue.Length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }
            _queue[_tail] = item;
            _size++;
        }

        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T value = _queue[_head];

            if (_head == _queue.Length - 1)
            {
                _head = 0;
            }
            else
            {
                _head++;
            }
            _size--;

            return value;
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return _queue[_head];
        }
    }
}