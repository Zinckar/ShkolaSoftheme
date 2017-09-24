using System;

namespace LinkedList
{
    public class DoubleLinkedList<T>
    {
        private Node<T> _first;
        private Node<T> _last;
        private int _count;

        public int Length
        {
            get { return _count; }
        }


        public void Add(Node<T> node)
        {
            if (_first == null)
            {
                _first = node;
                _last = _first;
            }
            else
            {
                _last.NextNode = node;
                _last.NextNode.PreviousNode = _last;
                _last = _last.NextNode;
            }
            _count++;
        }

        public void AddAfterIndex(Node<T> node, int index)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            Node<T> newItem = node;
            int currentIndex = 0;
            Node<T> currentItem = _first;
            Node<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = currentItem;
                currentItem = currentItem.NextNode;
                currentIndex++;
            }
            if (index == 0)
            {
                newItem.PreviousNode = _first.PreviousNode;
                newItem.NextNode = _first;
                _first.PreviousNode = newItem;
                _first = newItem;
            }
            else if (index == Length - 1)
            {
                newItem.PreviousNode = _last;
                _last.NextNode = newItem;
                newItem = _last;
            }
            else
            {
                newItem.NextNode = prevItem.NextNode;
                prevItem.NextNode = newItem;
                newItem.PreviousNode = currentItem.PreviousNode;
                currentItem.PreviousNode = newItem;
            }
            _count++;
        }

        public void RemoveByIndex(int index)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            int currentIndex = 0;
            Node<T> currentItem = _first;
            Node<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = currentItem;
                currentItem = currentItem.NextNode;
                currentIndex++;
            }
            if (Length == 0)
            {
                _first = null;
            }
            else if (prevItem == null)
            {
                _first = currentItem.NextNode;
                _first.PreviousNode = null;
            }
            else if (index == Length - 1)
            {
                prevItem.NextNode = currentItem.NextNode;
                _last = prevItem;
                currentItem = null;
            }
            else
            {
                prevItem.NextNode = currentItem.NextNode;
                currentItem.NextNode.PreviousNode = prevItem;
            }
            _count--;
        }

        public bool Contains(Node<T> node)
        {
            var current = _first;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    return true;
                }
                current = current.NextNode;
            }

            return false;
        }

        public Node<T>[] ToArray()
        {
            Node<T>[] array = new Node<T>[Length];
            var current = _first;
            var countArrayElement = 0;
            while (current != null)
            {
                array[countArrayElement] = current;
                current = current.NextNode;
                countArrayElement++;
            }

            return array;
        }
    }
}
